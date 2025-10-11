using ProductManagementWindowsForms.DAL;
using System.Data;
using System.Data.SqlClient;

namespace ProductManagementWindowsForms.BL;
internal class Products
{
    DataAccessLayer dataAccessLayer = new DataAccessLayer();
    public DataTable GetAllProducts ()
    {
        dataAccessLayer.Open();

        DataTable dataTable = new DataTable();
        dataTable = dataAccessLayer.SelectData("GetAllProducts", null);
        dataAccessLayer.CLose();
        return dataTable;

    }

    public void AddProduct ( int CategoryId, string ProductLabel, string ProductId,
     int Qte, string Price, byte[] img )
    {
        dataAccessLayer.Open();

        SqlParameter[] sqlParameters = new SqlParameter[6];

        sqlParameters[0] = new SqlParameter("@CategoryId", SqlDbType.Int);
        sqlParameters[0].Value = CategoryId;

        sqlParameters[1] = new SqlParameter("@ProductLabel", SqlDbType.VarChar, 30);
        sqlParameters[1].Value = ProductLabel;

        sqlParameters[2] = new SqlParameter("@ProductId", SqlDbType.VarChar, 30);
        sqlParameters[2].Value = ProductId;

        sqlParameters[3] = new SqlParameter("@Qte", SqlDbType.Int);
        sqlParameters[3].Value = Qte;

        sqlParameters[4] = new SqlParameter("@Price", SqlDbType.VarChar, 50);
        sqlParameters[4].Value = Price;

        sqlParameters[5] = new SqlParameter("@Image", SqlDbType.Image);
        sqlParameters[5].Value = img;

        dataAccessLayer.ExecuteCommand("AddProduct", sqlParameters);
        dataAccessLayer.CLose();
    }

}
