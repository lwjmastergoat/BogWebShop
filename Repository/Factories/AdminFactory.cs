using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duser;
using Repository.Models;
using System.Data.SqlClient;

namespace Repository.Factories
{
    public class AdminFactory : AutoFac<AdminTable>
    {

        public AdminTable Login(string Username, string Password)
        {
            string SQL = "SELECT * FROM AdminTable WHERE Username=@Username AND Password=@Password";

            using (SqlCommand cmd = new SqlCommand(SQL, Conn.CreateConnection()))
            {
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Password", Password);

                Mapper<AdminTable> mapper = new Mapper<AdminTable>();
                SqlDataReader reader = cmd.ExecuteReader();

                AdminTable user = new AdminTable();

                if (reader.Read())
                {
                    user = mapper.Map(reader);
                }

                reader.Close();
                cmd.Connection.Close();

                return user;
            }
        }
    }
}
