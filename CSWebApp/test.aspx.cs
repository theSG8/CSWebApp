using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSWebApp
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           // DBHelper.InsertTarea("test", "test", 2.5f, DateTime.Now, "ahora?");
            DBHelper.AsignarTrabajadorATarea(2, 3);
        }
    }
}