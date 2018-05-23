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
            int id = Convert.ToInt32(t_email.Text);
            String pass = t_pass.Text;
            Usuario u = DBHelper.getUsuariobyID(id);

            if (u!=null)
            {
                if (u.contr == pass)
                {
                    Session.Add("usuario",u);
                    //Redirige a el que toque
                    switch (u.rol)
                    {
                        case DBHelper.director:
                            break;
                        case DBHelper.responsable:
                            break;
                        case DBHelper.trabajador:
                            break;
                    }
                }
                

            }
        



    }
}