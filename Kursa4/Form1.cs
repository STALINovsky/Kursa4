using DataBaseAccess;
using Kursa4.ExportHelpers;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Enums;
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
            ConsumerGrid.DataSource = _context.Consumers.Local.ToBindingList();
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
                var currentRow = EmployeeGrid.CurrentCell.RowIndex;
                var idCell = EmployeeGrid[0, currentRow];
                var id = (int)idCell.Value;
                var rowData = _context.Employees.Where(employee => employee.Id == id).First();

                _context.Remove(rowData);
                _context.SaveChangesAsync();

                MessageBox.Show($"Employee with id = {id} was deleted successfully");
            }
        }

        private void EmployeeGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var currentRow = EmployeeGrid.CurrentCell.RowIndex;
            var idCell = EmployeeGrid[0, currentRow];
            var id = (int)idCell.Value;
            var rowData = _context.Employees.Where(employee => employee.Id == id).First();

            EmployeeName.Text = rowData.Name;
            EmployeeSurname.Text = rowData.Surname;
            EmployeePhone.Text = rowData.PhoneNumber;
            EmployeeSalary.Value = rowData.Salary;
            EmployeeBirthDate.SelectionRange.Start = rowData.BirthDate;
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
                var currentRow = ConsumerGrid.CurrentCell.RowIndex;
                var idCell = ConsumerGrid[0, currentRow];
                var id = (int)idCell.Value;
                var rowData = _context.Consumers.Where(consumer => consumer.Id == id).First();

                _context.Remove(rowData);
                _context.SaveChangesAsync();

                MessageBox.Show($"Consumer with id = {id} was deleted successfully");
            }
        }

        private void ConsumerSaveButton_Click(object sender, EventArgs e)
        {
            _context.SaveChanges();
            ConsumerGrid.Update();

            MessageBox.Show("Changes was saved successfully");
        }

        private void ConsumerGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var currentRow = ConsumerGrid.CurrentCell.RowIndex;
            var idCell = ConsumerGrid[0, currentRow];
            var id = (int)idCell.Value;
            var rowData = _context.Consumers.Where(consumer => consumer.Id == id).First();

            ConsumerName.Text = rowData.Name;
            ConsumerSurname.Text = rowData.Surname;
            ConsumerBIrthdate.SelectionRange.Start = rowData.BirthDate;
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
                var currentRow = ProductGrid.CurrentCell.RowIndex;
                var idCell = ProductGrid[0, currentRow];
                var id = (int)idCell.Value;
                var rowData = _context.Products.Where(product => product.Id == id).First();

                _context.Remove(rowData);
                _context.SaveChangesAsync();

                MessageBox.Show($"Product with id = {id} was deleted successfully");
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
            var currentRow = ProductGrid.CurrentCell.RowIndex;
            var idCell = ProductGrid[0, currentRow];
            var id = (int)idCell.Value;
            var rowData = _context.Products.Where(product => product.Id == id).First();

            ProductName.Text = rowData.Name;
            ProductDescription.Text = rowData.Description;
            ProductPriceUpDown.Value = rowData.Price;
            ProductStockCountUpDown.Value = decimal.Parse(rowData.StockCount);
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
                var currentRow = PurchaseProductsGrid.CurrentCell.RowIndex;
                var idCell = PurchaseProductsGrid[0, currentRow];
                var id = (int)idCell.Value;
                var rowData = _context.PurchaseProducts.Where(product => product.Id == id).First();

                _context.Remove(rowData);
                _context.SaveChangesAsync();

                MessageBox.Show($"Product with id = {id} was deleted successfully");
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

        private void button1_Click(object sender, EventArgs e)
        {
            ExelExportHelper.ExportData(_context, DateTime.Now.AddDays(-1), DateTime.Now.AddDays(1));
        }
    }
}