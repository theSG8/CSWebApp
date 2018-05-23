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
            DBHelper.InsertTarea(TextBox4.Text, TextBox5.Text, float.Parse(TextBox6.Text), Convert.ToDateTime(TextBox7.Text), TextBox8.Text);
            GridView2.Visible = false;
            System.Windows.Forms.MessageBox.Show("Tarea añadida correctamente");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            GridView2.Visible = true;
            GridView2.DataBind();
        }
    }
       
}