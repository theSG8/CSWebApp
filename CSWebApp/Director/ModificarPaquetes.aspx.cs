using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSWebApp.Director
{
    public partial class ModificarPaquetes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            GridView1.Visible = true;
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            DBHelper.InsertPaquete(TextBox1.Text, float.Parse(TextBox2.Text), int.Parse(TextBox3.Text));
            GridView1.Visible = false;
            System.Windows.Forms.MessageBox.Show("Paquete añadido correctamente");
            
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

        }
    }
}