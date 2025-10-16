using ProductManagementWindowsForms.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementWindowsForms.BL
{
    internal class OrdersBL
    {
        DataAccessLayer accessLayer = new DataAccessLayer();

        public DataTable GetLastOrderId()
        {
            accessLayer.Open();

            DataTable dataTable = new DataTable();
            dataTable = accessLayer.SelectData("GetLastOrderId", null);
            accessLayer.CLose();
            return dataTable;
        }
    }


}

