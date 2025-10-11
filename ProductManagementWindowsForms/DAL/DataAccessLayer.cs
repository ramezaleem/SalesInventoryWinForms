using System.Data;
using System.Data.SqlClient;

namespace ProductManagementWindowsForms.DAL;
internal class DataAccessLayer
{
    SqlConnection _sqlConnection;
    public DataAccessLayer ()
    {
        _sqlConnection = new SqlConnection("Data Source=RAMEZALEEM\\TRAINEE;Initial Catalog=Product_DBWinForms;Integrated Security=True;TrustServerCertificate=True;");
    }

    public void Open ()
    {
        if (_sqlConnection.State != ConnectionState.Open)
            _sqlConnection.Open();
    }

    public void CLose ()
    {
        if (_sqlConnection.State == ConnectionState.Open)
            _sqlConnection.Close();
    }

    public DataTable SelectData ( string storedProcedure, SqlParameter[] parameters )
    {
        SqlCommand command = new SqlCommand();
        command.Connection = _sqlConnection;
        command.CommandType = CommandType.StoredProcedure;
        command.CommandText = storedProcedure;

        for (int i = 0 ; i < parameters.Length ; i++)
        {
            command.Parameters.Add(parameters[i]);
        }

        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

        DataTable dataTable = new DataTable();
        dataAdapter.Fill(dataTable);
        return dataTable;
    }

    // Method For Insert Update Delete Data From Database
    public void ExecuteCommand ( string storedProcedure, SqlParameter[] parameters )
    {
        SqlCommand command = new SqlCommand();
        command.CommandType = CommandType.StoredProcedure;
        command.CommandText = storedProcedure;
        command.Connection = _sqlConnection;

        command.Parameters.AddRange(parameters);

        command.ExecuteNonQuery();
    }


}
