using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace CSWebApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           //DBHelper.InsertUsuario("Ivan", "Valdes", DBHelper.director, "123");

             Usuario u = DBHelper.getUsuariobyID(2);
            //System.Windows.Forms.MessageBox.Show(A);
           // DBHelper.InsertPaquete("ahora?", 0.2f, u);

            List<Paquete> a = DBHelper.GetPaquetesUsuarios(u);

            DBHelper.InsertTarea("prueba", "aaa", 2.3f, DateTime.Now, "ahora?");
            System.Windows.Forms.MessageBox.Show("A");



        }



    }
}