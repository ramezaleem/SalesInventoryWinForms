using ProductManagementWindowsForms.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementWindowsForms.BL
{
    internal class CustomersBL
    {
        DataAccessLayer dataAccessLayer = new DataAccessLayer();

        public void AddCustomer(string firstName, string lastName, string tel, string email, byte[] picture)
        {
            dataAccessLayer.Open();

            SqlParameter[] parameters =
            {
                new SqlParameter("@FirstName", SqlDbType.NVarChar, 25) { Value = firstName },
                new SqlParameter("@LastName", SqlDbType.NVarChar, 25) { Value = lastName },
                new SqlParameter("@Tel", SqlDbType.NChar, 15) { Value = tel },
                new SqlParameter("@Email", SqlDbType.VarChar, 25) { Value = email },
                new SqlParameter("@Picture", SqlDbType.Image) { Value = picture }    
            };

            dataAccessLayer.ExecuteCommand("AddCustomer", parameters);
            dataAccessLayer.CLose();
        }



    }
}
