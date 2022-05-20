using DataBaseAccess;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using Kursa4.ExportHelpers;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Enums;
using System.Data;
using System.Diagnostics;
using System.Linq;

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

            _context.Employees.Load();
            _context.Consumers.Load();
            _context.Products.Load();
            _context.Orders.Load();
            _context.PurchaseProducts.Load();
            SetDataInGridView();

            ConsumerInOrder.DataSource = _context.Consumers.Local.ToBindingList();
            EmployeeInOrder.DataSource = _context.Employees.Local.ToBindingList();
            OrderStatus.DataSource = Enum.GetValues(typeof(OrderStatus));
            ConsumerPurchaseProduct.DataSource = _context.Consumers.Local.ToBindingList();
            PurcahseProductOrder.DataSource = _context.Orders.Local.ToBindingList();
            PurchaseProductSourceProduct.DataSource = _context.Products.Local.ToBindingList();

            //OrdersGrid.Columns[2].CellTemplate = new PurchaseProductListCell();
        }

        public void SetDataInGridView()
        {
            EmployeeGrid.DataSource = _context.Employees.Local.ToBindingList();
            ConsumersGrid.DataSource = _context.Consumers.Local.ToBindingList();
            ProductGrid.DataSource = _context.Products.Local.ToBindingList();
            OrdersGrid.DataSource = _context.Orders.Local.ToBindingList();
            PurchaseProductsGrid.DataSource = _context.PurchaseProducts.Local.ToBindingList();
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

        private void EmployeeGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int[] selRows = ((GridView)EmployeeGrid.MainView).GetSelectedRows();
            if (selRows.Count() == 0)
            {
                return;
            }

            var selRow = (EmployeeGrid.MainView).GetRow(selRows[0]) as Emploee;
            EmployeeName.Text = selRow.Name;
            EmployeeSurname.Text = selRow.Surname;
            EmployeePhone.Text = selRow.PhoneNumber;
            EmployeeSalary.Value = selRow.Salary;
            EmployeeBirthDate.SelectionRange.Start = selRow.BirthDate;
        }

        private void ConsumerCreateButton_Click(object sender, EventArgs e)
        {
            Consumer consumer = new()
            {
                Name = ConsumerName.Text.Trim(),
                Surname = ConsumerSurname.Text.Trim(),
                BirthDate = ConsumerBIrthdate.SelectionRange.Start
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

        private void ConsumerGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int[] selRows = ((GridView)EmployeeGrid.MainView).GetSelectedRows();
            if (selRows.Count() == 0)
            {
                return;
            }

            var selRow = (EmployeeGrid.MainView).GetRow(selRows[0]) as Consumer;
            ConsumerName.Text = selRow.Name;
            ConsumerSurname.Text = selRow.Surname;
            ConsumerBIrthdate.SelectionRange.Start = selRow.BirthDate;
        }

        private void CreateProduct_Click(object sender, EventArgs e)
        {
            Product product = new()
            {
                Name = ProductName.Text.Trim(),
                Description = ProductDescription.Text.Trim(),
                Price = ProductPriceUpDown.Value,
                StockCount = ProductStockCountUpDown.Value.ToString()
            };

            _context.Products.Add(product);
            _context.SaveChanges();
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int[] selRows = ((GridView)ProductGrid.MainView).GetSelectedRows();
                if (selRows.Count() == 0)
                {
                    MessageBox.Show("Nothing to delete");
                    return;
                }

                var selRow = (EmployeeGrid.MainView).GetRow(selRows[0]) as Product;
                _context.Remove(selRow);
                _context.SaveChangesAsync();

                MessageBox.Show($"Product with id = {selRow.Id} was deleted successfully");
            }
        }

        private void SaveProduct_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            ProductGrid.Update();

            MessageBox.Show("Changes was saved successfully");
        }

        private void ProductGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int[] selRows = ((GridView)ProductGrid.MainView).GetSelectedRows();
            if (selRows.Count() == 0)
            {
                return;
            }

            var selRow = (EmployeeGrid.MainView).GetRow(selRows[0]) as Product;

            ProductName.Text = selRow.Name;
            ProductDescription.Text = selRow.Description;
            ProductPriceUpDown.Value = selRow.Price;
            ProductStockCountUpDown.Value = decimal.Parse(selRow.StockCount);
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
            ProductPriceUpDown.Value = decimal.Zero;
            ProductStockCountUpDown.Value = decimal.Zero;
        }

        private void SaveOrder_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            ProductGrid.Update();

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
            PurchaseProduct purchaseProduct = new()
            {
                Name = ((Product)PurchaseProductSourceProduct.SelectedValue).Name,
                Description = ((Product)PurchaseProductSourceProduct.SelectedValue).Description,
                Price = ((Product)PurchaseProductSourceProduct.SelectedValue).Price,
                PurchaseCount = (int)PurchaseProductCount.Value,
                Consumer = (Consumer)ConsumerPurchaseProduct.SelectedValue,
                Order = (Order)PurcahseProductOrder.SelectedValue,
            };

            _context.PurchaseProducts.Add(purchaseProduct);
            _context.SaveChanges();
        }

        private void DeletePurchaseProduct_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record ?", "Delete ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int[] selRows = ((GridView)PurchaseProductsGrid.MainView).GetSelectedRows();
                if (selRows.Count() == 0)
                {
                    MessageBox.Show("Nothing to delete");
                    return;
                }

                var selRow = (EmployeeGrid.MainView).GetRow(selRows[0]) as PurchaseProduct;
                _context.Remove(selRow);
                _context.SaveChangesAsync();

                MessageBox.Show($"Product with id = {selRow.Id} was deleted successfully");
            }
        }

        private void OrdersGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            const int one = 1;
            if (e.ColumnIndex == one + one)
            {
                var dataGridView = sender as DataGridView;
                var temp = dataGridView[one + one, e.RowIndex].Value as ICollection<PurchaseProduct>;
                if (temp is not null)
                {
                    e.Value = string.Join(", ", temp);
                }
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            var startDate = ExportPeriod.SelectionRange.Start;
            var endDate = ExportPeriod.SelectionRange.End;
            ExelExportHelper.ExportData(_context, startDate, endDate);
            MessageBox.Show($"Excel report was successuly generated({startDate} - {endDate})");
        }

        private (GridControl Grid, string FileName) GetCurrentGridData()
        {
            var index = TableTabControl.SelectedIndex;
            return index switch
            {
                0 => (EmployeeGrid, "Employee"),
                1 => (ConsumersGrid, "Consumers"),
                2 => (ProductGrid, "Products"),
                3 => (PurchaseProductsGrid, "Purchase Products"),
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