using DataBaseAccess;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using Kursa4.Report;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Kursa4
{
    public partial class Form1 : Form
    {
        private BDLabsDbContext _context = new();

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = new BDLabsDbContext();
            OrderGrid.DefaultView.DataController.AllowIEnumerableDetails = true;
            _context.Manufacturers.Load();
            _context.Providers.Load();
            _context.Components.Load();
            _context.PurchasedComponents.Load();
            _context.Orders.Load();
            SetDataInGridView();

            ComponentManufacturer.DataSource = _context.Manufacturers.Local.ToBindingList();
            ComponentProvider.DataSource = _context.Providers.Local.ToBindingList();
            PurchasedComponentSource.DataSource = _context.Components.Local.ToBindingList();
            PurchasedComponentOrder.DataSource = _context.Orders.Local.ToBindingList();
        }

        public void SetDataInGridView()
        {
            ManufacturerGrid.DataSource = _context.Manufacturers.Local.ToBindingList();
            ProviderGrid.DataSource = _context.Providers.Local.ToBindingList();
            ComponentGrid.DataSource = _context.Components.Local.ToBindingList();
            OrderGrid.DataSource = _context.Orders.Local.ToBindingList();
            PurchasedComponentGrid.DataSource = _context.PurchasedComponents.Local.ToBindingList();

            ManufacturerGrid.DefaultView.DataController.AllowIEnumerableDetails = true;
            ProviderGrid.DefaultView.DataController.AllowIEnumerableDetails = true;
            OrderGrid.DefaultView.DataController.AllowIEnumerableDetails = true;
        }

        private void ManufacturerCreateButton_Click(object sender, EventArgs e)
        {
            Manufacturer manufacturer = new()
            {
                ManufacturerName = ManufacturerName.Text.Trim(),
                Description = ManufacturerDescription.Text.Trim()
            };

            _context.Manufacturers.Add(manufacturer);
            _context.SaveChanges();
        }

        private void ManufacturerSaveButton_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            ManufacturerGrid.Update();

            MessageBox.Show("Changes was saved successfully");
        }

        private void ManufacturerDeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int[] selRows = ((GridView)ManufacturerGrid.MainView).GetSelectedRows();
                if (selRows.Count() == 0)
                {
                    MessageBox.Show("Nothing to delete");
                    return;
                }

                var selRow = (ManufacturerGrid.MainView).GetRow(selRows[0]) as Manufacturer;
                _context.Remove(selRow);
                _context.SaveChangesAsync();

                MessageBox.Show($"Employee with id = {selRow.Id} was deleted successfully");
            }
        }

        private void ProviderCreateButton_Click(object sender, EventArgs e)
        {
            Provider provider = new()
            {
                ProviderName = ProviderName.Text.Trim(),
                Description = ProviderDescription.Text.Trim(),
            };

            _context.Providers.Add(provider);
            _context.SaveChanges();
            MessageBox.Show("Provider was added successfully");
        }

        private void ProviderDeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int[] selRows = ((GridView)ProviderGrid.MainView).GetSelectedRows();
                if (selRows.Count() == 0)
                {
                    MessageBox.Show("Nothing to delete");
                    return;
                }

                var selRow = (ProviderGrid.MainView).GetRow(selRows[0]) as Provider;
                _context.Remove(selRow);
                _context.SaveChangesAsync();

                MessageBox.Show($"Provider with id = {selRow.Id} was deleted successfully");
            }
        }

        private void ProviderSaveButton_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            ProviderGrid.Update();

            MessageBox.Show("Changes was saved successfully");
        }

        private void ComponentCreateButton_Click(object sender, EventArgs e)
        {
            Component component = new()
            {
                ComponentName = ComponentName.Text.Trim(),
                Description = ComponentDescription.Text.Trim(),
                Provider = ComponentProvider.SelectedValue as Provider,
                Manufacturer = ComponentManufacturer.SelectedValue as Manufacturer,
                Price = (int)ComponentPrice.Value
            };

            _context.Components.Add(component);
            _context.SaveChanges();
        }

        private void ComponentDeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int[] selRows = ((GridView)ComponentGrid.MainView).GetSelectedRows();
                if (selRows.Count() == 0)
                {
                    MessageBox.Show("Nothing to delete");
                    return;
                }

                var selRow = (ComponentGrid.MainView).GetRow(selRows[0]) as Component;
                _context.Remove(selRow);
                _context.SaveChangesAsync();

                MessageBox.Show($"Product with id = {selRow.Id} was deleted successfully");
            }
        }

        private void ComponentSaveButton_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            ComponentGrid.Update();

            MessageBox.Show("Changes was saved successfully");
        }

        private void SaveOrder_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            OrderGrid.Update();
            PurchasedComponentGrid.MainView.RefreshData();

            MessageBox.Show("Changes was saved successfully");
        }

        private void CreateOrder_Click(object sender, EventArgs e)
        {
            Order order = new()
            {
                CreateDate = DateTime.Now,
                OrderStatus = Model.Enums.OrderStatus.Draft,
            };

            _context.Orders.Add(order);
            _context.SaveChanges();
        }


        private void PurchasedComponentCreateButton_Click(object sender, EventArgs e)
        {
            PurchasedComponent purchasedComponent = new()
            {
                ComponentName = ((Component)PurchasedComponentSource.SelectedValue).ComponentName,
                Description = ((Component)PurchasedComponentSource.SelectedValue).Description,
                ManufacturerName = ((Component)PurchasedComponentSource.SelectedValue).Manufacturer.Description,
                Price = ((Component)PurchasedComponentSource.SelectedValue).Price,
                ProviderName = ((Component)PurchasedComponentSource.SelectedValue).Provider.ProviderName,
                Count = (int)PurchasedComponentCount.Value,
                Order = PurchasedComponentOrder.SelectedValue as Order,

            };

            PurchasedComponentGrid.MainView.RefreshData();
            OrderGrid.MainView.RefreshData();
            _context.PurchasedComponents.Add(purchasedComponent);
            _context.SaveChanges();
        }

        private void PurchasedComponentSaveButton_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            PurchasedComponentGrid.Update();
            OrderGrid.MainView.RefreshData();

            MessageBox.Show("Changes was saved successfully");
        }

        private void PurchasedComponentDeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int[] selRows = ((GridView)PurchasedComponentGrid.MainView).GetSelectedRows();
                if (selRows.Count() == 0)
                {
                    MessageBox.Show("Nothing to delete");
                    return;
                }

                var selRow = (PurchasedComponentGrid.MainView).GetRow(selRows[0]) as PurchasedComponent;
                _context.Remove(selRow);
                _context.SaveChangesAsync();

                MessageBox.Show($"PurchasedComponent with id = {selRow.Id} was deleted successfully");
            }

            OrderGrid.MainView.RefreshData();
            OrderGrid.MainView.RefreshData();
        }

        private (GridControl Grid, string FileName) GetCurrentGridData()
        {
            var index = TableTabControl.SelectedIndex;
            return index switch
            {
                0 => (ManufacturerGrid, "Manufacturer"),
                1 => (ProviderGrid, "Provider"),
                2 => (ComponentGrid, "Component"),
                3 => (PurchasedComponentGrid, "PurchasedComponent"),
                4 => (OrderGrid, "Order")
            };
            return default;
        }

        private void pdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = GetCurrentGridData();
            var view = data.Grid.MainView as GridView;
            view.OptionsPrint.PrintDetails = true;
            view.OptionsPrint.ExpandAllDetails = true;
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();

            var filepath = dialog.SelectedPath + "\\" + data.FileName + ".pdf";

            data.Grid.MainView.ExportToPdf(filepath);
        }

        private void exelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = GetCurrentGridData();
            var view = data.Grid.MainView as GridView;
            view.OptionsPrint.PrintDetails = true;
            view.OptionsPrint.ExpandAllDetails = true;
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();

            var filepath = dialog.SelectedPath + "\\" + data.FileName + ".xslx";
            data.Grid.MainView.ExportToXlsx(filepath);
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = GetCurrentGridData();
            var view = data.Grid.MainView as GridView;
            view.OptionsPrint.PrintDetails = true;
            view.OptionsPrint.ExpandAllDetails = true;
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();

            var filepath = dialog.SelectedPath + "\\" + data.FileName + ".docx";
            data.Grid.MainView.ExportToDocx(filepath);
        }

        private void rtfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = GetCurrentGridData();
            var view = data.Grid.MainView as GridView;
            view.OptionsPrint.PrintDetails = true;
            view.OptionsPrint.ExpandAllDetails = true;
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();

            var filepath = dialog.SelectedPath + "\\" + data.FileName + ".rtf";
            data.Grid.MainView.ExportToRtf(filepath);
        }

        private void htmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = GetCurrentGridData();
            var view = data.Grid.MainView as GridView;
            view.OptionsPrint.PrintDetails = true;
            view.OptionsPrint.ExpandAllDetails = true;
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();

            var filepath = dialog.SelectedPath + "\\" + data.FileName + ".html";

            data.Grid.MainView.ExportToPdf(filepath);
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var report = new Report1();
            var printTool = new ReportPrintTool(report);
            printTool.ShowRibbonPreview();
        }
    }
}
