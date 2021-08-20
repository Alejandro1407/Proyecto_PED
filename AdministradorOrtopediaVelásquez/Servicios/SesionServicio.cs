using Desafio.Clases;
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
                                           where usuarios.email.Equals(user) && usuarios.contrasenya.Equals(contrasenia)
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
        }//AgregarAdministrador
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

        public Task<Lista<usuario>> ObtenerAdministradoresAsync()
        {
            return Task.Run(() =>
            {
                OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities();
                try
                {
                    Lista<usuario> administradores = (from usuarios in db.usuario
                                                     where usuarios.tipoUsuario.Value.Equals(1)
                                                     select usuarios).ToArray();
                    return administradores;
                }
                catch (Exception e)
                {
                    return null;
                }
            });
        }//ObtenerAdminsitradoresAsync


        public Task<Lista<usuario>> ObtenerUsuariosAsync(string param) {
            return Task.Run(() =>
            {
                OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities();
                try
                {
                    Lista<usuario> administradores = (from usuarios in db.usuario
                                                      where (usuarios.tipoUsuario.Value.Equals(1) || usuarios.tipoUsuario.Value.Equals(3) || usuarios.tipoUsuario.Value.Equals(4)) && (usuarios.nombres.Contains(param) || usuarios.apellidos.Contains(param) )
                                                      select usuarios).ToArray();
                    return administradores;
                }
                catch (Exception e)
                {
                    return null;
                }

            });
        }
        public Task<Lista<usuario>> ObtenerPacientesAsync(string param)
        {
            return Task.Run(() =>
            {
                OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities();
                try
                {
                    Lista<usuario> administradores = (from usuarios in db.usuario
                                                      where usuarios.tipoUsuario.Value.Equals(4) && (usuarios.nombres.Contains(param) || usuarios.apellidos.Contains(param))
                                                      select usuarios).ToArray();
                    return administradores;
                }
                catch (Exception e)
                {
                    return null;
                }

            });
        }

        public Task<Lista<usuario>> ObtenerUsuarioAsync(int id) {
            return Task.Run(() =>
            {
                OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities();
                try
                {
                    Lista<usuario> administradores = (from usuarios in db.usuario
                                                     where usuarios.id.Equals(id)
                                                     select usuarios).ToArray();
                    return administradores;
                }
                catch (Exception e) {
                    return null;
                }
            });
        }//ObtenerAdminsitradorAsync

        public Task<Lista<usuario>> ObtenerMedicoAsync(String param)
        {

            return Task.Run(() =>
            {
                Lista<usuario> Medicos = new Lista<usuario>();
                OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities();
                try
                {
                    Medicos = (from medicos in db.usuario
                               where medicos.nombres.Contains(param) && medicos.tipoUsuario.Value.Equals(2)
                               select medicos).ToArray();
                    return Medicos;
                }
                catch (Exception e)
                {
                    return null;
                }

            });

        }//ObtenerMedicosAsync

        public Task<Lista<usuario>> ObtenerMedicosAsync()
        {

            return Task.Run(() =>
            {
                Lista<usuario> Medicos = new Lista<usuario>();
                OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities();
                try
                {
                    Medicos = (from medicos in db.usuario
                               where medicos.tipoUsuario.Value.Equals(2)
                               select medicos).ToArray();
                    return Medicos;
                }
                catch (Exception e)
                {
                    return null;
                }

            });

        }//ObtenerMedicosAsync

        public Task<bool> AgregarCita(cita c)
        {
            return Task.Run(() =>
            {
                using (OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities())
                {
                    try
                    {
                        cita _c = (from cita in db.cita
                                   where cita.idMedico == c.idMedico && (cita.Horarios.Hora == c.Horarios.Hora && (  (cita.Horarios.Fecha.Value.Year == c.Horarios.Fecha.Value.Year) && (cita.Horarios.Fecha.Value.Month == c.Horarios.Fecha.Value.Month) && (cita.Horarios.Fecha.Value.Day == c.Horarios.Fecha.Value.Day) ))
                                   select cita).FirstOrDefault();

                        if (_c != null) { return default; }

                        db.cita.Add(c);
                        db.SaveChanges();
                        return true;
                    }
                    catch (Exception e)
                    {
                        return false;
                    }

                }
            });
        }//AgregarAdministrador

        public Task<Lista<cita>> ObtenerCitassAsync()
        {
            return Task.Run(() =>
            {
                OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities();
                try
                {
                    Lista<cita> administradores = (from citas in db.cita
                                                     select citas).ToArray();
                    return administradores;
                }
                catch (Exception e)
                {
                    return null;
                }
            });
        }//ObtenerCitasAsync

        public Task<Lista<cita>> ObtenerCitassAsync(string param)
        {
            return Task.Run(() =>
            {
                OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities();
                try
                {
                    Lista<cita> administradores = (from citas in db.cita
                                                   where citas.usuario.nombres.Contains(param) || citas.usuario.apellidos.Contains(param) || citas.usuario1.nombres.Contains(param) || citas.usuario1.apellidos.Contains(param)
                                                   select citas).ToArray();
                    return administradores;
                }
                catch (Exception e)
                {
                    return null;
                }
            });
        }//ObtenerCitasAsync

        public Task<Lista<cita>> ObtenerCitassAsync(string param,int id)
        {
            return Task.Run(() =>
            {
                OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities();
                try
                {
                    Lista<cita> administradores = (from citas in db.cita
                                                   where (citas.usuario.nombres.Contains(param) || citas.usuario.apellidos.Contains(param) || citas.usuario1.nombres.Contains(param) || citas.usuario1.apellidos.Contains(param)) && citas.usuario.id.Equals(id)
                                                   select citas).ToArray();
                    return administradores;
                }
                catch (Exception e)
                {
                    return null;
                }
            });
        }//ObtenerCitasAsync


        public Task<bool> CancelarcCita(int id)
        {
            return Task.Run(() =>
            {
                try
                {
                    using (OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities())
                    {
                        cita c = db.cita.Find(id);
                        db.Horarios.Remove(c.Horarios);
                        db.cita.Remove(c);
                        db.SaveChanges();
                        return true;
                    }
                }
                catch (Exception e)
                {
                    return false;
                }
            });
        }



    }//Clase
}//NameSpace
