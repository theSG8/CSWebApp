using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace CSWebApp.Director
{
    public partial class AñadirParticipantes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DBHelper.InsertUsuario(nombreT.Text, "Valdes", DBHelper.director, "123");
    
        }
    }
}