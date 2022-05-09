using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursa4.Customizations
{
    public class PurchaseProductListCell : DataGridViewTextBoxCell
    {
        private Order _Order; 


        protected override object GetValue(int rowIndex)
        {
            return "Hello World";
        }

    }
}
