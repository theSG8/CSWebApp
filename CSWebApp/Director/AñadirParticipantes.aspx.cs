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
            if (pass1T.Text == pass2T.Text)
            {
                DBHelper.InsertUsuario(nombreT.Text, ApellidosT.Text, DropDownList1.SelectedValue, pass1T.Text);
                System.Windows.Forms.MessageBox.Show("Participante añadido correctamente");
            } else
            {
                System.Windows.Forms.MessageBox.Show("Las contraseñas tienen que coincidir");
            }
            
        }
    }
}