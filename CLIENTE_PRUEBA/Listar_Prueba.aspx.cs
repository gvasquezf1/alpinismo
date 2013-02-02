using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using HOST_PRUEBA;

namespace CLIENTE_PRUEBA
{
    public partial class Listar_Prueba : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ServiceReference1.AlpinismoServicesClient obj = new ServiceReference1.AlpinismoServicesClient();
                DataSet ds = new DataSet();
                ds = obj.listar();

                DataTable dt0 = new DataTable();
                dt0 = ds.Tables[0];
            }
        }
    }
}