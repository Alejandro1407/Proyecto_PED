using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministradorOrtopediaVelásquez.Servicios
{
    class SesionServicio
    {
        public Task<usuario> LoguearseAsync(String user, String contrasenia) {
            return Task.Run(() =>
            {
                using (OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities())
                {
                    try {
                       usuario p = (from usuarios in db.usuario
                                           where usuarios.email.Equals(user) && usuarios.contrasenya.Equals(contrasenia) && usuarios.tipoUsuario.Value.Equals(1)
                                           select usuarios).FirstOrDefault();
                        return p;
                    }
                    catch (Exception e) {
                        usuario p = new usuario();
                        p.nombres = "Exception";
                        return p;
                    }
                }
            });
        }//LoguearseAsync

        public Task<bool> AgregarAdministrador(usuario u)
        {
            return Task.Run(() =>
            {
                using (OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities())
                {
                    try
                    {

                        db.usuario.Add(u);
                        db.SaveChanges();
                        return true;
                    }
                    catch (Exception e)
                    {
                        return false;
                    }

                }
            });
        }
        public Task<bool> EliminarAdministrador(int id) {
            return Task.Run(() =>
            {
                try
                {
                    using (OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities()) {
                        usuario u = db.usuario.Find(id);
                        db.usuario.Remove(u);
                        db.SaveChanges();
                        return true;
                    } 
                }
                catch (Exception e) {
                    return false;
                }
            });
        }

        public Task<bool> ChangePass(int id,String newPass) {
            return Task.Run(() =>
            {
                using (OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities()) {
                    try
                    {
                        usuario u = db.usuario.Find(id);
                        u.contrasenya = newPass;
                        db.SaveChanges();
                        return true;
                    }
                    catch (Exception e) {
                        return false;
                    }
                }
            });
        }

        public Task<List<usuario>> ObtenerAdministradoresAsync()
        {
            return Task.Run(() =>
            {
                OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities();
                try
                {
                    List<usuario> administradores = (from usuarios in db.usuario
                                                     where usuarios.tipoUsuario.Value.Equals(1)
                                                     select usuarios).ToList();
                    return administradores;
                }
                catch (Exception e)
                {
                    return null;
                }
            });
        }//ObtenerAdminsitradoresAsync

        public Task<List<usuario>> ObtenerAdministradorAsync(int id) {
            return Task.Run(() =>
            {
                OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities();
                try
                {
                    List<usuario> administradores = (from usuarios in db.usuario
                                                     where usuarios.tipoUsuario.Value.Equals(1) && usuarios.id.Equals(id)
                                                     select usuarios).ToList();
                    return administradores;
                }
                catch (Exception e) {
                    return null;
                }
            });
        }//ObtenerAdminsitradorAsync


    }//Clase
}//NameSpace
