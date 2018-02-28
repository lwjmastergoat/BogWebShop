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
    public class UsersFactory : AutoFac<UsersTable>
    {
        public UsersTable LogIn(string Email, string Password)
        {
            string SQL = "SELECT * FROM UsersTable WHERE Email=@Email AND Password=@Password";

            using (var cmd = new SqlCommand(SQL, Conn.CreateConnection()))
            {
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Password", Password);

                var mapper = new Mapper<UsersTable>();
                var r = cmd.ExecuteReader();
                UsersTable user = new UsersTable();

                if (r.Read())
                {
                    user = mapper.Map(r);
                }

                r.Close();
                cmd.Connection.Close();
                return user;
            }
        }

    }
}
