using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duser;
using Repository.Models;

namespace Repository.Factories
{
    public class ContactInformationFactory : AutoFac<ContactInformationTable>
    {
        public ContactZip GetByJoined()
        {
            string SQL = "SELECT ContactInformationTable.ID, ContactName, ContactAddress, ZipCode, City, ContactEmail, ContactPhone, ContactCVR FROM ContactInformationTable INNER JOIN ZipCodesTable ON ContactZipCode = Zipcode";

            return ExecuteSQL<ContactZip>(SQL)[0];
        } 
    }
}
