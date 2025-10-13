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

    public void AddProduct(int categoryId, string productLabel, string productId, int qte, string price, byte[] img)
    {
        dataAccessLayer.Open();

        SqlParameter[] parameters =
        {
        new SqlParameter("@CategoryId", SqlDbType.Int) { Value = categoryId },
        new SqlParameter("@ProductLabel", SqlDbType.NVarChar, 30) { Value = productLabel },
        new SqlParameter("@ProductId", SqlDbType.NVarChar, 30) { Value = productId },
        new SqlParameter("@Qte", SqlDbType.Int) { Value = qte },
        new SqlParameter("@Price", SqlDbType.NVarChar, 50) { Value = price },
        new SqlParameter("@Image", SqlDbType.Image) { Value = img }
    };

        dataAccessLayer.ExecuteCommand("AddProduct", parameters);
        dataAccessLayer.CLose();
    }

    public void UpdateProduct(int categoryId, string productLabel, string productId, int qte, string price, byte[] img)
    {
        dataAccessLayer.Open();

        SqlParameter[] parameters =
        {
        new SqlParameter("@ProductId", SqlDbType.NVarChar, 30) { Value = productId },
        new SqlParameter("@ProductLabel", SqlDbType.NVarChar, 30) { Value = productLabel },
        new SqlParameter("@Qte_In_Stock", SqlDbType.Int) { Value = qte },
        new SqlParameter("@price", SqlDbType.NVarChar, 30) { Value = price },
        new SqlParameter("@ProductImage", SqlDbType.Image) { Value = img },
        new SqlParameter("@CategoryId", SqlDbType.Int) { Value = categoryId }
    };

        dataAccessLayer.ExecuteCommand("UpdateProduct", parameters);
        dataAccessLayer.CLose();
    }


    public void DeleteProduct(string productId)
    {
        dataAccessLayer.Open();

        SqlParameter[] parameters =
        {
        new SqlParameter("@Id", SqlDbType.VarChar, 50) { Value = productId }
    };

        dataAccessLayer.ExecuteCommand("DeleteProduct", parameters);
        dataAccessLayer.CLose();
    }


    public DataTable VerifyProductId(string productId)
    {
        dataAccessLayer.Open();

        SqlParameter[] parameters =
        {
        new SqlParameter("@ProductId", SqlDbType.NVarChar, 30) { Value = productId }
    };

        DataTable dataTable = dataAccessLayer.SelectData("VerifyProductId", parameters);
        dataAccessLayer.CLose();
        return dataTable;
    }
    public DataTable SearchProduct(string productId)
    {
        dataAccessLayer.Open();

        SqlParameter[] parameters =
        {
        new SqlParameter("@ProductId", SqlDbType.NVarChar, 50) { Value = productId }
    };

        DataTable dataTable = dataAccessLayer.SelectData("SearchProduct", parameters);
        dataAccessLayer.CLose();
        return dataTable;
    }

    public DataTable GetProductImage(string Id)
    {
        dataAccessLayer.Open();
        DataTable dataTable = new DataTable();
        SqlParameter[] parameters = new SqlParameter[1];
        parameters[0] = new SqlParameter("@Id", SqlDbType.NVarChar, 50);

        parameters[0].Value = Id;

        dataTable = dataAccessLayer.SelectData("GetProductImage", parameters);
        dataAccessLayer.CLose();
        return dataTable;
    }
}
