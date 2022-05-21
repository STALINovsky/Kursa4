using DataBaseAccess;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Enums;
using System.Data;
using System.Diagnostics;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Kursa4
{
    public partial class Form1 : Form
    {
        private BDLabsDbContext _context;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = new BDLabsDbContext();
            OrdersGrid.DefaultView.DataController.AllowIEnumerableDetails = true;
            _context.Employees.Load();
            _context.Consumers.Load();
            _context.Books.Load();
            _context.Orders.Load();
            _context.OrderedBooks.Load();
            SetDataInGridView();

            ConsumerInOrder.DataSource = _context.Consumers.Local.ToBindingList();
            EmployeeInOrder.DataSource = _context.Employees.Local.ToBindingList();
            OrderStatus.DataSource = Enum.GetValues(typeof(OrderStatus));
            ConsumerPurchaseProduct.DataSource = _context.Consumers.Local.ToBindingList();
            PurcahseProductOrder.DataSource = _context.Orders.Local.ToBindingList();
            OrderedBooksSource.DataSource = _context.Books.Local.ToBindingList();

            //OrdersGrid.Columns[2].CellTemplate = new PurchaseProductListCell();
        }

        public void SetDataInGridView()
        {
            EmployeeGrid.DataSource = _context.Employees.Local.ToBindingList();
            ConsumersGrid.DataSource = _context.Consumers.Local.ToBindingList();
            BookGrid.DataSource = _context.Books.Local.ToBindingList();
            OrdersGrid.DataSource = _context.Orders.Local.ToBindingList();
            OrderedBookGrid.DataSource = _context.OrderedBooks.Local.ToBindingList();
        }

        private void EmployeeSaveButton_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            EmployeeGrid.Update();

            MessageBox.Show("Changes was saved successfully");
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            Emploee employee = new()
            {
                Name = EmployeeName.Text.Trim(),
                Surname = EmployeeSurname.Text.Trim(),
                PhoneNumber = EmployeePhone.Text.Trim(),
                BirthDate = EmployeeBirthDate.SelectionRange.Start,
                Salary = EmployeeSalary.Value
            };

            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int[] selRows = ((GridView)EmployeeGrid.MainView).GetSelectedRows();
                if (selRows.Count() == 0)
                {
                    MessageBox.Show("Nothing to delete");
                    return;
                }

                var selRow = (EmployeeGrid.MainView).GetRow(selRows[0]) as Emploee;
                _context.Remove(selRow);
                _context.SaveChangesAsync();

                MessageBox.Show($"Employee with id = {selRow.Id} was deleted successfully");
            }
        }

        private void ConsumerCreateButton_Click(object sender, EventArgs e)
        {
            Consumer consumer = new()
            {
                Name = ConsumerName.Text.Trim(),
                Surname = ConsumerSurname.Text.Trim(),
                BirthDate = ConsumerBIrthdate.SelectionRange.Start,
                PhoneNumner = ConsumerPhoneNumber.Text.Trim(), 
            };

            _context.Consumers.Add(consumer);
            _context.SaveChanges();
            MessageBox.Show("Consumer was added successfully");
        }

        private void ConsumerDeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int[] selRows = ((GridView)ConsumersGrid.MainView).GetSelectedRows();
                if (selRows.Count() == 0)
                {
                    MessageBox.Show("Nothing to delete");
                    return;
                }

                var selRow = (EmployeeGrid.MainView).GetRow(selRows[0]) as Consumer;
                _context.Remove(selRow);
                _context.SaveChangesAsync();

                MessageBox.Show($"Consumer with id = {selRow.Id} was deleted successfully");
            }
        }

        private void ConsumerSaveButton_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            ConsumersGrid.Update();

            MessageBox.Show("Changes was saved successfully");
        }

        private void CreateProduct_Click(object sender, EventArgs e)
        {
            Book book = new()
            {
                Name = ProductName.Text.Trim(),
                Description = ProductDescription.Text.Trim(),
                OrderingPrice = BookPriceUpDown.Value,
                StockCount = (int)BookPriceUpDown.Value,
                Author = BookAuthor.Text.Trim(),
            };

            _context.Books.Add(book);
            _context.SaveChanges();
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int[] selRows = ((GridView)BookGrid.MainView).GetSelectedRows();
                if (selRows.Count() == 0)
                {
                    MessageBox.Show("Nothing to delete");
                    return;
                }

                var selRow = (EmployeeGrid.MainView).GetRow(selRows[0]) as Book;
                _context.Remove(selRow);
                _context.SaveChangesAsync();

                MessageBox.Show($"Product with id = {selRow.Id} was deleted successfully");
            }
        }

        private void SaveProduct_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            BookGrid.Update();

            MessageBox.Show("Changes was saved successfully");
        }

        private void ClearEmployeeData_Click(object sender, EventArgs e)
        {
            EmployeeName.Text = EmployeeSurname.Text = EmployeePhone.Text = string.Empty;
            EmployeeSalary.Value = decimal.Zero;
            EmployeeBirthDate.SelectionRange.Start = DateTime.Now;
        }

        private void ClearConsumerData_Click(object sender, EventArgs e)
        {
            ConsumerName.Text = ConsumerSurname.Text = ConsumerPhoneNumber.Text = string.Empty;
            ConsumerBIrthdate.SelectionRange.Start = DateTime.Now;
        }

        private void ClearProductData_Click(object sender, EventArgs e)
        {
            ProductName.Text = ProductDescription.Text = string.Empty;
            BookPriceUpDown.Value = decimal.Zero;
            ProductStockCountUpDown.Value = decimal.Zero;
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
                Consumer = (Consumer)ConsumerInOrder.SelectedValue,
                CreateDate = DateTime.Now,
                Emploee = (Emploee)EmployeeInOrder.SelectedValue,
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
                Author =  ((Book)OrderedBooksSource.SelectedValue).Author,
                OrderingPrice = ((Book)OrderedBooksSource.SelectedValue).OrderingPrice,
                Consumer = (Consumer)ConsumerPurchaseProduct.SelectedValue,
                Order = (Order)PurcahseProductOrder.SelectedValue,
            };
            OrdersGrid.MainView.RefreshData();
            _context.OrderedBooks.Add(purchaseProduct);
            _context.SaveChanges();
        }

        private void DeletePurchaseProduct_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int[] selRows = ((GridView)OrderedBookGrid.MainView).GetSelectedRows();
                if (selRows.Count() == 0)
                {
                    MessageBox.Show("Nothing to delete");
                    return;
                }

                var selRow = (OrderedBookGrid.MainView).GetRow(selRows[0]) as OrderedBook;
                _context.Remove(selRow);
                _context.SaveChangesAsync();

                MessageBox.Show($"Product with id = {selRow.Id} was deleted successfully");
            }

            OrdersGrid.MainView.RefreshData();
        }

        private void OrdersGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            const int one = 1;
            if (e.ColumnIndex == one + one)
            {
                var dataGridView = sender as DataGridView;
                var temp = dataGridView[one + one, e.RowIndex].Value as ICollection<OrderedBook>;
                if (temp is not null)
                {
                    e.Value = string.Join(", ", temp);
                }
            }
        }
        private (GridControl Grid, string FileName) GetCurrentGridData()
        {
            var index = TableTabControl.SelectedIndex;
            return index switch
            {
                0 => (EmployeeGrid, "Employee"),
                1 => (ConsumersGrid, "Consumers"),
                2 => (BookGrid, "Books"),
                3 => (OrderedBooksGrid, "OrderedBooks"),
                4 => (OrdersGrid, "Orders")
            };
        }

        private void pdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = GetCurrentGridData();
            data.Grid.ExportToPdf(data.FileName + ".pdf");
        }

        private void exelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = GetCurrentGridData();
            data.Grid.ExportToXlsx(data.FileName + ".xslx");
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = GetCurrentGridData();
            data.Grid.ExportToDocx(data.FileName + ".docx");
        }

        private void rtfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = GetCurrentGridData();
            data.Grid.ExportToRtf(data.FileName + ".rtf");
        }

        private void htmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = GetCurrentGridData();
            data.Grid.ExportToPdf(data.FileName + ".pdf");
        }
    }
}