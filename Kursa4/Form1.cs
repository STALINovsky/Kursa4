using DataBaseAccess;
using Microsoft.EntityFrameworkCore;
using Model;
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
            SetDataInGridView();
        }

        public void SetDataInGridView()
        {
            EmployeeGrid.AutoGenerateColumns = false;
            EmployeeGrid.DataSource = _context.Employees.Local.ToBindingList();
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
    }
}