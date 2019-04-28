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
        public Task<List<usuario>> LoguearseAsync(String user, String contrasenia) {
            return Task.Run(() =>
            {
                using (OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities())
                {
                    try {
                        List<usuario> p = (from usuarios in db.usuario
                                           where usuarios.email.Equals(user) && usuarios.contrasenya.Equals(contrasenia) && usuarios.idRol.Value.Equals(1)
                                           select usuarios).ToList();
                        return p;
                    }
                    catch (Exception e) {
                        return null;
                    }
                }
            });
        }//LoguearseAsync

        public Task<List<usuario>> ObtenerAdministradoresAsync()
        {
            return Task.Run(() =>
            {
                OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities();
                try
                {
                    List<usuario> administradores = (from usuarios in db.usuario
                                                     where usuarios.idRol.Equals(1)
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
                                                     where usuarios.idRol.Equals(1) && usuarios.id.Equals(id)
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
