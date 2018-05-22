using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSWebApp
{
    public static class DBHelper
    {
        public static String director = "director";
        public static String responsable = "responsable";
        public static String trabajador = "trabajador";


        #region Inserts

        public static void InsertUsuario(String nombre, String apellido, String rol, String contr)
        {
            using (var context = new CSDB())
            {
                var usr = new Usuario()
                {
                    nombre = nombre,
                    apellidos = apellido,
                    rol = rol,
                    contr = contr
                };
                context.Usuarios.Add(usr);
                context.SaveChanges();
            }
        }

        public static void InsertPaquete(String nombre, float estimacion, Usuario responspaquete)
        {
            using (var context = new CSDB())
            {
                var pqt = new Paquete
                {
                    nombre = nombre,
                    estimacion = estimacion,
                };

                context.Usuarios.Find(responspaquete.id).Paquetes.Add(pqt); 
                context.SaveChanges();
            }
        }

        public static void InsertTarea(String nombre, string des,float hest, DateTime fechaLim,String nombreP)
        {
            using (var context = new CSDB())
            {
                var tar = new Tarea
                {
                    nombre = nombre,
                    des = des,
                    hest = hest,
                    hreales = 0,
                    progreso = 0,
                    incidenc = "",
                    fechaLim = fechaLim,
                    finalizado = false

                };

                context.Paquetes.Find(nombreP).TareasPaquete.Add(tar);
                context.SaveChanges();
              

            }
        }

        /*public static void InsertSolicitud(String nombre, string des, float hest, DateTime fechaLim, String nombreP)
        {
            using (var context = new CSDB())
            {
            }
        }
        */

        #endregion

        #region Getters

        public static Usuario getUsuariobyID(int id)
        {
            using (var context = new CSDB())
            {
                return context.Usuarios.Find(id);
            }
        }
        public static List<Paquete> GetPaquetesUsuarios(Usuario usuario)
        {
            using (var context = new CSDB())
            {
                return context.Usuarios.Find(usuario.id).Paquetes.ToList<Paquete>();
            }
        }
        public static List<Tarea> GetTareasPaquete(String nombreP)
        {
            using (var context = new CSDB())
            {
                return context.Paquetes.Find(nombreP).TareasPaquete.ToList<Tarea>();
            }
        }
        public static List<Tarea> GetTareasUsuario(String id)
        {
            using (var context = new CSDB())
            {

                List<Tarea> res = new List<Tarea>();
                List<Paquete> paquetes = context.Usuarios.Find(id).Paquetes.ToList();
                foreach( var  paquete in paquetes)
                {
                   foreach(var tarea in paquete.TareasPaquete)
                    {
                        res.Add(tarea);
                    }
                }
                return res;
            }
        }


        #endregion
    }
}