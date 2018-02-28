using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duser;
using Repository.Models;

namespace Repository.Factories
{
    public class OrderDetailsFactory : AutoFac<OrderDetailsTable>
    {
        public List<OrderDetailsRela> GetByOrderID(int id)
        {
            string SQL = "SELECT OrderDetailsTable.ID, OrderID ProductName, Price, Quantity FROM OrderDetailsTable INNER JOIN ProductsTable ON ProductsID = ProductsTable.ID Where OrderID = '" + id +"'";

            return ExecuteSQL<OrderDetailsRela>(SQL);
        }
    }
}
