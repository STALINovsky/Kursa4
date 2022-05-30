using DataBaseAccess;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
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
            //EmployeeInOrder.DataSource = _context.Employees.Local.ToBindingList();
            //OrderStatus.DataSource = Enum.GetValues(typeof(OrderStatus));
            //ConsumerPurchaseProduct.DataSource = _context.Clients.Local.ToBindingList();
            //PurcahseProductOrder.DataSource = _context.Orders.Local.ToBindingList();
            //OrderedBooksSource.DataSource = _context.Books.Local.ToBindingList();
        }

        public void SetDataInGridView()
        {
            ManufacturerGrid.DataSource = _context.Manufacturers.Local.ToBindingList();
            ProviderGrid.DataSource = _context.Providers.Local.ToBindingList();
            ComponentGrid.DataSource = _context.Components.Local.ToBindingList();
            OrderGrid.DataSource = _context.Orders.Local.ToBindingList();
            PurchasedComponentGrid.DataSource = _context.PurchasedComponents.Local.ToBindingList();
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
            //_context.SaveChanges();
            //BookGrid.Update();

            //MessageBox.Show("Changes was saved successfully");
        }

        private void CreateOrder_Click(object sender, EventArgs e)
        {
            //Order order = new()
            //{
            //    Client = (Client)ConsumerInOrder.SelectedValue,
            //    CreateDate = DateTime.Now,
            //    Emploee = (Employee)EmployeeInOrder.SelectedValue,
            //    OrderStatus = (OrderStatus)OrderStatus.SelectedValue,
            //};

            //_context.Orders.Add(order);
            //_context.SaveChanges();
        }


        private void CreatePurchaseProduct_Click(object sender, EventArgs e)
        {
            //OrderedBook purchaseProduct = new()
            //{
            //    Name = ((Book)OrderedBooksSource.SelectedValue).Name,
            //    Description = ((Book)OrderedBooksSource.SelectedValue).Description,
            //    Author = ((Book)OrderedBooksSource.SelectedValue).Author,
            //    Order = (Order)PurcahseProductOrder.SelectedValue,
            //};
            //OrderGrid.MainView.RefreshData();
            //_context.OrderedBooks.Add(purchaseProduct);
            //_context.SaveChanges();
        }

        private void DeletePurchaseProduct_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Are you sure you want to delete this record ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    int[] selRows = ((GridView)OrderedBooksGrid.MainView).GetSelectedRows();
            //    if (selRows.Count() == 0)
            //    {
            //        MessageBox.Show("Nothing to delete");
            //        return;
            //    }

            //    var selRow = (OrderedBooksGrid.MainView).GetRow(selRows[0]) as OrderedBook;
            //    _context.Remove(selRow);
            //    _context.SaveChangesAsync();

            //    MessageBox.Show($"Product with id = {selRow.Id} was deleted successfully");
            //}

            //OrderGrid.MainView.RefreshData();
        }

        private (GridControl Grid, string FileName) GetCurrentGridData()
        {
            //var index = TableTabControl.SelectedIndex;
            //return index switch
            //{
            //    0 => (EmployeeGrid, "Employee"),
            //    1 => (ClientGrid, "Clients"),
            //    2 => (BookGrid, "Books"),
            //    3 => (OrderedBooksGrid, "OrderedBooks"),
            //    4 => (OrderGrid, "Orders")
            //};
            return default;
        }

        private void pdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var data = GetCurrentGridData();
            //var view = data.Grid.MainView as GridView;
            //view.OptionsPrint.PrintDetails = true;
            //view.OptionsPrint.ExpandAllDetails = true;
            //FolderBrowserDialog dialog = new FolderBrowserDialog();
            //dialog.ShowDialog();

            //var filepath = dialog.SelectedPath + "\\" + data.FileName + ".pdf";

            //data.Grid.MainView.ExportToPdf(filepath);
        }

        private void exelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var data = GetCurrentGridData();
            //var view = data.Grid.MainView as GridView;
            //view.OptionsPrint.PrintDetails = true;
            //view.OptionsPrint.ExpandAllDetails = true;
            //FolderBrowserDialog dialog = new FolderBrowserDialog();
            //dialog.ShowDialog();

            //var filepath = dialog.SelectedPath + "\\" + data.FileName + ".xslx";
            //data.Grid.MainView.ExportToXlsx(filepath);
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var data = GetCurrentGridData();
            //var view = data.Grid.MainView as GridView;
            //view.OptionsPrint.PrintDetails = true;
            //view.OptionsPrint.ExpandAllDetails = true;
            //FolderBrowserDialog dialog = new FolderBrowserDialog();
            //dialog.ShowDialog();

            //var filepath = dialog.SelectedPath + "\\" + data.FileName + ".docx";
            //data.Grid.MainView.ExportToDocx(filepath);
        }

        private void rtfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var data = GetCurrentGridData();
            //var view = data.Grid.MainView as GridView;
            //view.OptionsPrint.PrintDetails = true;
            //view.OptionsPrint.ExpandAllDetails = true;
            //FolderBrowserDialog dialog = new FolderBrowserDialog();
            //dialog.ShowDialog();

            //var filepath = dialog.SelectedPath + "\\" + data.FileName + ".rtf";
            //data.Grid.MainView.ExportToRtf(filepath);
        }

        private void htmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var data = GetCurrentGridData();
            //var view = data.Grid.MainView as GridView;
            //view.OptionsPrint.PrintDetails = true;
            //view.OptionsPrint.ExpandAllDetails = true;
            //FolderBrowserDialog dialog = new FolderBrowserDialog();
            //dialog.ShowDialog();

            //var filepath = dialog.SelectedPath + "\\" + data.FileName + ".html";

            //data.Grid.MainView.ExportToPdf(filepath);
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var report = new Report1();
            //var printTool = new ReportPrintTool(report);
            //printTool.ShowRibbonPreview();
        }


    }
}
