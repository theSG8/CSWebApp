﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CSWebApp
{
    public static class DBHelper
    {
        public  const String director = "director";
        public  const String responsable = "responsable";
        public  const String trabajador = "trabajador";


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

        public static void InsertPaquete(String nombre, float estimacion, int responspaquete)
        {
            using (var context = new CSDB())
            {
                var pqt = new Paquete
                {
                    nombre = nombre,
                    estimacion = estimacion,
                };

                context.Usuarios.Find(responspaquete).Paquetes.Add(pqt); 
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

        public static void InsertSolicitud(String titulo, String des, Usuario director)
        {
            using (var context = new CSDB())
            {
                var sol = new Solicitud
                {
                    titulo = titulo,
                    des = des
                };

                context.Usuarios.Find(director.id).Solicituds.Add(sol);
            }
        }

       

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
        public static List<Solicitud> GetSolicitudesDirector(int id)
        {
            using (var context = new CSDB())
            {
                return context.Usuarios.Find(id).Solicituds.ToList<Solicitud>();
            }
        }
        public static List<Paquete> GetPaquetes()
        {
            using (var context = new CSDB())
            {
                return context.Paquetes.ToList<Paquete>();
            }
        }
        #endregion

        #region Updaters

        public static void UpdatePaquete( String nombreP ,String nombre, float estimacion)
        {
            using (var context = new CSDB())
            {
                var pqt = context.Paquetes.Find(nombreP);
                pqt.estimacion = estimacion;
                pqt.nombre = nombre;
                context.SaveChanges();
            }  
        }

        public static void AsignarTrabajadorATarea(int trabajador, int tarea)
        {
            using (var context = new CSDB())
            {
                var tar = context.Tareas.Find(tarea);
                context.Usuarios.Find(trabajador).Tareas.Add(tar);
                context.SaveChanges();

            }
        }



        #endregion


    }
}