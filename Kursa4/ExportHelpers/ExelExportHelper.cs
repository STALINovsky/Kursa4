using DataBaseAccess;
using IronXL;
using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursa4.ExportHelpers
{
    public class ExelExportHelper
    {
        private static List<KeyValuePair<string, Func<Order, string>>> orderSelectors = new()
        {
            new("Id", x => $"{x.Id}"),
            new("OrderStatus", x => $"{x.OrderStatus}"),
            new("ConsumerId", x => $"{x.Consumer.Id}"),
            new("ConsumerName", x => $"{x.Consumer.Name}"),
            new("EmploeeId", x => $"{x.Emploee.Id}"),
            new("EmploeeName", x => $"{x.Emploee.Name}"),
            new("ProductsIds", x => $"{string.Join(", ", x.PurchaseProducts.Select(x => x.Id))}"),
            new("Products", x => $"{string.Join(", ", x.PurchaseProducts.Select(x => x.Name))}"),
            new("Total", x => $"{x.PurchaseProducts.Sum(x => x.Price * x.PurchaseCount)}"),
        };


        private static List<KeyValuePair<string, Func<Emploee, string>>> emploeeSelectors = new()
        {
            new("Id", x => $"{x.Id}"),
            new("Name", x => $"{x.Name}"),
            new("Surname", x => $"{x.Surname}"),
            new("BirthDate", x => $"{x.BirthDate}"),
            new("PhoneNumber", x => $"{x.PhoneNumber}"),
            new("Salary", x => $"{x.Salary}"),
        };

        private static List<KeyValuePair<string, Func<Consumer, string>>> consumerSelectors = new()
        {
            new("Id", x => $"{x.Id}"),
            new("Name", x => $"{x.Name}"),
            new("Surname", x => $"{x.Surname}"),
            new("BirthDate", x => $"{x.BirthDate}"),
        };

        private static List<KeyValuePair<string, Func<PurchaseProduct, string>>> purchaseProductSelectors = new()
        {
            new("Id", x => $"{x.Id}"),
            new("Name", x => $"{x.Name}"),
            new("Description", x => $"{x.Description}"),
            new("Price", x => $"{x.Price}"),
            new("PurchaseCount", x => $"{x.PurchaseCount}"),
            new("ConsumerId", x => $"{x.Consumer.Id}"),
            new("ConsumerName", x => $"{x.Consumer.Name}"),
        };


        public static void ExportData(BDLabsDbContext dbContext, DateTime startDate, DateTime endDate)
        {
            var ordersdata = dbContext.Orders
                .Include(x => x.Consumer)
                .Include(x => x.Emploee)
                .Include(x => x.PurchaseProducts)
                .Where(x => x.CreateDate >= startDate && x.CreateDate <= endDate)
                .ToArray();

            var workBook = WorkBook.Create(ExcelFileFormat.XLS);

            var orderSheet = workBook.CreateWorkSheet("orders");
            ExportDataToSheet(orderSheet, ordersdata, orderSelectors);

            var employeeSheet = workBook.CreateWorkSheet("employee");
            ExportDataToSheet(employeeSheet, ordersdata.Select(x => x.Emploee).ToArray(), emploeeSelectors);

            var consumerSheet = workBook.CreateWorkSheet("consumer");
            ExportDataToSheet(consumerSheet, ordersdata.Select(x => x.Consumer).ToArray(), consumerSelectors);
            
            var orderedBooksSheet = workBook.CreateWorkSheet("Ordered books");
            ExportDataToSheet(orderedBooksSheet, ordersdata.SelectMany(x => x.PurchaseProducts).ToArray(), purchaseProductSelectors);

            workBook.SaveAs("NewExcelFile.xls");
        }

        public static void ExportDataToSheet<T>(WorkSheet sheet, IList<T> data, List<KeyValuePair<string, Func<T, string>>> selectors)
        {
            var headerList = selectors.Select(x => x.Key).ToArray();
            FillHeder(sheet, headerList);
            for (int rowIndex = 1; rowIndex <= data.Count; rowIndex++)
            {
                var rowData = GetObjectAsListOfString(data[rowIndex - 1], selectors);
                for (int columnIndex = 0; columnIndex < rowData.Length; columnIndex++)
                {
                    sheet.SetCellValue(rowIndex, columnIndex, rowData[columnIndex]);
                }
            }
        }

        public static void FillHeder(WorkSheet sheet, string[] columnNames)
        {
            for (int i = 0; i < columnNames.Length; i++)
            {
                sheet.SetCellValue(0, i, columnNames[i]);
            }
        }

        public static string[] GetObjectAsListOfString<T>(T value, List<KeyValuePair<string, Func<T, string>>> selectors)
        {
            return selectors.Select(x => x.Value.Invoke(value)).ToArray();
        }

        private static DataRow FillRow<T>(DataRow row, T value, List<KeyValuePair<string, Func<T, string>>> selectors)
        {
            foreach (var selector in selectors)
            {
                row[selector.Key] = selector.Value.Invoke(value);
            }

            return row;
        }
    }
}
