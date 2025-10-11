using ProductManagementWindowsForms.DAL;
using System.Data;
using System.Data.SqlClient;

namespace ProductManagementWindowsForms.BL;
internal class Login
{
    public DataTable LoginUsers ( string Id, string password )
    {
        DataAccessLayer dataAccessLayer = new DataAccessLayer();
        SqlParameter[] parameters = new SqlParameter[2];

        parameters[0] = new SqlParameter("@Id", SqlDbType.VarChar, 50);
        parameters[0].Value = Id;


        parameters[1] = new SqlParameter("@Password", SqlDbType.VarChar, 50);
        parameters[1].Value = password;

        dataAccessLayer.Open();

        DataTable dataTable = new DataTable();
        dataTable = dataAccessLayer.SelectData("Login", parameters);

        return dataTable;

    }

}
