using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duser;
using Repository.Models;

namespace Repository.Factories
{
    public class OrderFactory : AutoFac<OrderTable>
    {
        public List<OrderUsers> GetAllJoined()
        {
            string SQL = "SELECT OrderTable.ID, Email, Name, ZipCodesTable.Zipcode, City, Address, Date FROM OrderTable INNER JOIN UsersTable ON UsersID = UsersTable.ID INNER JOIN ZipCodesTable ON UsersTable.ZipCode = ZipCodesTable.ZipCode";

            return ExecuteSQL<OrderUsers>(SQL);
        }
    }
}
