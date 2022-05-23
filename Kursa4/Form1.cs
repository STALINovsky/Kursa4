using DataBaseAccess;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using Kursa4.Reports;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Enums;

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
            _context.Employees.Load();
            _context.Clients.Load();
            _context.Books.Load();
            _context.Orders.Load();
            _context.OrderedBooks.Load();
            SetDataInGridView();

            ConsumerInOrder.DataSource = _context.Clients.Local.ToBindingList();
            EmployeeInOrder.DataSource = _context.Employees.Local.ToBindingList();
            OrderStatus.DataSource = Enum.GetValues(typeof(OrderStatus));
            ConsumerPurchaseProduct.DataSource = _context.Clients.Local.ToBindingList();
            PurcahseProductOrder.DataSource = _context.Orders.Local.ToBindingList();
            OrderedBooksSource.DataSource = _context.Books.Local.ToBindingList();
        }

        public void SetDataInGridView()
        {
            EmployeeGrid.DataSource = _context.Employees.Local.ToBindingList();
            ClientGrid.DataSource = _context.Clients.Local.ToBindingList();
            BookGrid.DataSource = _context.Books.Local.ToBindingList();
            OrderGrid.DataSource = _context.Orders.Local.ToBindingList();
            OrderedBooksGrid.DataSource = _context.OrderedBooks.Local.ToBindingList();
        }

        private void EmployeeCreateButton_Click(object sender, EventArgs e)
        {
            Employee employee = new()
            {
                Name = EmployeeName.Text.Trim(),
                Surname = EmployeeSurname.Text.Trim(),
                PhoneNumber = EmployeePhone.Text.Trim(),
                BirthDate = EmployeeBirthDate.SelectionRange.Start,
                Salary = (int)EmployeeSalary.Value
            };

            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        private void EmployeeSaveButton_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            EmployeeGrid.Update();

            MessageBox.Show("Changes was saved successfully");
        }

        private void EmpoyeeDeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int[] selRows = ((GridView)EmployeeGrid.MainView).GetSelectedRows();
                if (selRows.Count() == 0)
                {
                    MessageBox.Show("Nothing to delete");
                    return;
                }

                var selRow = (EmployeeGrid.MainView).GetRow(selRows[0]) as Employee;
                _context.Remove(selRow);
                _context.SaveChangesAsync();

                MessageBox.Show($"Employee with id = {selRow.Id} was deleted successfully");
            }
        }

        private void ClientCreateButton_Click(object sender, EventArgs e)
        {
            Client consumer = new()
            {
                Name = ConsumerName.Text.Trim(),
                Surname = ConsumerSurname.Text.Trim(),
                BirthDate = ConsumerBIrthdate.SelectionRange.Start,
                PhoneNumber = ConsumerPhoneNumber.Text.Trim(),
            };

            _context.Clients.Add(consumer);
            _context.SaveChanges();
            MessageBox.Show("Consumer was added successfully");
        }

        private void ClientDeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int[] selRows = ((GridView)ClientGrid.MainView).GetSelectedRows();
                if (selRows.Count() == 0)
                {
                    MessageBox.Show("Nothing to delete");
                    return;
                }

                var selRow = (ClientGrid.MainView).GetRow(selRows[0]) as Client;
                _context.Remove(selRow);
                _context.SaveChangesAsync();

                MessageBox.Show($"Consumer with id = {selRow.Id} was deleted successfully");
            }
        }

        private void ClientSaveButton_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            ClientGrid.Update();

            MessageBox.Show("Changes was saved successfully");
        }

        private void CreateBook_Click(object sender, EventArgs e)
        {
            Book book = new()
            {
                Name = ProductName.Text.Trim(),
                Description = ProductDescription.Text.Trim(),
                StockCount = (int)ProductStockCountUpDown.Value,
                Author = BookAuthor.Text.Trim(),
            };

            _context.Books.Add(book);
            _context.SaveChanges();
        }

        private void DeleteBook_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int[] selRows = ((GridView)BookGrid.MainView).GetSelectedRows();
                if (selRows.Count() == 0)
                {
                    MessageBox.Show("Nothing to delete");
                    return;
                }

                var selRow = (BookGrid.MainView).GetRow(selRows[0]) as Book;
                _context.Remove(selRow);
                _context.SaveChangesAsync();

                MessageBox.Show($"Product with id = {selRow.Id} was deleted successfully");
            }
        }

        private void SaveBook_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            BookGrid.Update();

            MessageBox.Show("Changes was saved successfully");
        }

        private void SaveOrder_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            BookGrid.Update();

            MessageBox.Show("Changes was saved successfully");
        }

        private void CreateOrder_Click(object sender, EventArgs e)
        {
            Order order = new()
            {
                Client = (Client)ConsumerInOrder.SelectedValue,
                CreateDate = DateTime.Now,
                Emploee = (Employee)EmployeeInOrder.SelectedValue,
                OrderStatus = (OrderStatus)OrderStatus.SelectedValue,
            };

            _context.Orders.Add(order);
            _context.SaveChanges();
        }


        private void CreatePurchaseProduct_Click(object sender, EventArgs e)
        {
            OrderedBook purchaseProduct = new()
            {
                Name = ((Book)OrderedBooksSource.SelectedValue).Name,
                Description = ((Book)OrderedBooksSource.SelectedValue).Description,
                Author = ((Book)OrderedBooksSource.SelectedValue).Author,
                Order = (Order)PurcahseProductOrder.SelectedValue,
            };
            OrderGrid.MainView.RefreshData();
            _context.OrderedBooks.Add(purchaseProduct);
            _context.SaveChanges();
        }

        private void DeletePurchaseProduct_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int[] selRows = ((GridView)OrderedBooksGrid.MainView).GetSelectedRows();
                if (selRows.Count() == 0)
                {
                    MessageBox.Show("Nothing to delete");
                    return;
                }

                var selRow = (OrderedBooksGrid.MainView).GetRow(selRows[0]) as OrderedBook;
                _context.Remove(selRow);
                _context.SaveChangesAsync();

                MessageBox.Show($"Product with id = {selRow.Id} was deleted successfully");
            }

            OrderGrid.MainView.RefreshData();
        }

        private (GridControl Grid, string FileName) GetCurrentGridData()
        {
            var index = TableTabControl.SelectedIndex;
            return index switch
            {
                0 => (EmployeeGrid, "Employee"),
                1 => (ClientGrid, "Clients"),
                2 => (BookGrid, "Books"),
                3 => (OrderedBooksGrid, "OrderedBooks"),
                4 => (OrderGrid, "Orders")
            };
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