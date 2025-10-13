using ProductManagementWindowsForms.DAL;
using System.Data;
using System.Data.SqlClient;

namespace ProductManagementWindowsForms.BL;
internal class Products
{
    DataAccessLayer dataAccessLayer = new DataAccessLayer();
    public DataTable GetAllCategories ()
    {
        dataAccessLayer.Open();

        DataTable dataTable = new DataTable();
        dataTable = dataAccessLayer.SelectData("GetAllCategories", null);
        dataAccessLayer.CLose();
        return dataTable;
    }

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

        sqlParameters[1] = new SqlParameter("@ProductLabel", SqlDbType.NVarChar, 30);
        sqlParameters[1].Value = ProductLabel;

        sqlParameters[2] = new SqlParameter("@ProductId", SqlDbType.NVarChar, 30);
        sqlParameters[2].Value = ProductId;

        sqlParameters[3] = new SqlParameter("@Qte", SqlDbType.Int);
        sqlParameters[3].Value = Qte;

        sqlParameters[4] = new SqlParameter("@Price", SqlDbType.NVarChar, 50);
        sqlParameters[4].Value = Price;

        sqlParameters[5] = new SqlParameter("@Image", SqlDbType.Image);
        sqlParameters[5].Value = img;

        dataAccessLayer.ExecuteCommand("AddProduct", sqlParameters);
        dataAccessLayer.CLose();
    }
    public void UpdateProduct(Int32 CategoryId, String ProductLabel, String ProductId, Int32 Qte, String Price, Byte[] img)
    {
        dataAccessLayer.Open();

        SqlParameter[] param = new SqlParameter[6];

        param[0] = new SqlParameter("@ProductId", SqlDbType.NVarChar, 30);
        param[0].Value = ProductId;

        param[1] = new SqlParameter("@ProductLabel", SqlDbType.NVarChar, 30);
        param[1].Value = ProductLabel;

        param[2] = new SqlParameter("@Qte_In_Stock", SqlDbType.Int);
        param[2].Value = Qte;

        param[3] = new SqlParameter("@price", SqlDbType.NVarChar, 30);
        param[3].Value = Price;

        param[4] = new SqlParameter("@ProductImage", SqlDbType.Image);
        param[4].Value = img;

        param[5] = new SqlParameter("@CategoryId", SqlDbType.Int);
        param[5].Value = CategoryId;

        dataAccessLayer.ExecuteCommand("UpdateProduct", param);

        dataAccessLayer.CLose();
    }


    public void DeleteProduct ( string Id )
    {
        dataAccessLayer.Open();

        SqlParameter[] parameters = new SqlParameter[1];

        parameters[0] = new SqlParameter("@Id", SqlDbType.NVarChar, 50);
        parameters[0].Value = Id;

        dataAccessLayer.ExecuteCommand("DeleteProduct", parameters);
        dataAccessLayer.CLose();
    }

    public DataTable VerifyProductId ( string Id )
    {
        dataAccessLayer.Open();
        DataTable dataTable = new DataTable();
        SqlParameter[] parameters = new SqlParameter[1];
        parameters[0] = new SqlParameter("@ProductId", SqlDbType.NVarChar, 30);
        parameters[0].Value = Id;

        dataTable = dataAccessLayer.SelectData("VerifyProductId", parameters);
        dataAccessLayer.CLose();
        return dataTable;
    }
    public DataTable SearchProduct ( string Id )
    {
        dataAccessLayer.Open();
        DataTable dataTable = new DataTable();
        SqlParameter[] parameters = new SqlParameter[1];
        parameters[0] = new SqlParameter("@Id", SqlDbType.NVarChar, 50);

        parameters[0].Value = Id;

        dataTable = dataAccessLayer.SelectData("SearchProduct", parameters);
        dataAccessLayer.CLose();
        return dataTable;
    }


}
