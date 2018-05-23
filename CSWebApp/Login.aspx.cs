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
            if (Request.QueryString["logout"] != null)
            {
                Session.Abandon();
                lerror.Text = "Se ha cerrado la sesión";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(t_email.Text);
            String pass = t_pass.Text;
            Usuario u = DBHelper.getUsuariobyID(id);

            if (u != null)
            {
                if (u.contr == pass)
                {
                    Session.Add("usuario", u);
                    switch (u.rol)
                    {
                        case DBHelper.director:
                            Response.Redirect("Director/MainDirector.aspx");
                            break;
                        case DBHelper.responsable:
                            Response.Redirect("Responsable/MainResponsable.aspx");
                            break;
                        case DBHelper.trabajador:
                            Response.Redirect("Trabajador/MainTrabajador.aspx");
                            break;
                    }

                }
                else
                {
                    lerror.Text = "Contraseña Incorrecta";
                }


            }
            else
            {
                lerror.Text = "El usuario no existe";
            }




        }
    }
}