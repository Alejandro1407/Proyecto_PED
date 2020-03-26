using Desafio.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdministradorOrtopediaVelásquez.Servicios
{
    class CatalogoServicio
    {
        public Task<Lista<ortesis>> ObtenerOrtesisAsync(String param) {

            return Task.Run(() =>
           {
               Lista<ortesis> Ortesis = new Lista<ortesis>();
               OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities();
               try {
                   Ortesis = (from ortesis in db.ortesis
                              join t in db.tipoOrtesis on ortesis.tipo equals t.id
                              where ortesis.nombre.Contains(param)
                              select ortesis).ToArray();
                   return Ortesis;
               }
               catch (Exception e) {
                   return null;
               }

           });

        }//ObtenerOrtesisAsync

        public Task<bool> AgregarProtesisAsync(protesis p) {
            return Task.Run(() =>
            {
                using (OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities()) {
                    try
                    {
                        db.protesis.Add(p);
                        db.SaveChanges();
                        return true;
                    }
                    catch (Exception e) {
                        return false;
                    }

                }

            });
        }//AgregarProtesisAsync

        public Task<bool> EditarProtesisAsync(protesis p, int id)
        {
            return Task.Run(() =>
            {
                using (OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities()) {
                    try {
                        protesis x = db.protesis.Find(id);
                        x.codigo = p.codigo;
                        x.nombre = p.nombre;
                        x.precio = p.precio;
                        x.tipo = p.tipo;
                        x.descripcion = p.descripcion;
                        x.foto = p.foto;
                        db.SaveChanges();
                        return true;
                    }
                    catch (Exception e) {
                        return false;
                    }

                }
            });
        }//EditarProtesisAsync

        public Task<bool> EditarOrtesisAsync(ortesis o, int id)
        {
            return Task.Run(() =>
            {
                using (OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities())
                {
                    try
                    {
                        ortesis x = db.ortesis.Find(id);
                        x.codigo = o.codigo;
                        x.nombre = o.nombre;
                        x.precio = o.precio;
                        x.tipo = o.tipo;
                        x.descripcion = o.descripcion;
                        x.foto = o.foto;
                        db.SaveChanges();
                        return true;
                    }
                    catch (Exception e)
                    {
                        return false;
                    }

                }
            });
        }//EditarProtesisAsync


        public Task<bool> AgregarOrtesisAsync(ortesis o)
        {
            return Task.Run(() =>
            {
                using (OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities())
                {
                    try
                    {
                        db.ortesis.Add(o);
                        db.SaveChanges();
                        return true;
                    }
                    catch (Exception e)
                    {
                        return false;
                    }

                }

            });
        }//AgregarOrtesisAsync

        public Task<bool> AgregarTipoProtesisAsync(tipoProtesis tp) {
            return Task.Run(() =>
            {
                using (OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities())
                    try
                    {
                        db.tipoProtesis.Add(tp);
                        db.SaveChanges();
                        return true;
                    }
                    catch (Exception e) {
                        return false;
                    }

            });
        }//AgregarTipoProtesisAsync

        public Task<bool> EditarTipoProtesisAsync(tipoProtesis tp,int id) {
            return Task.Run(() =>
            {
                using (OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities()) { 
                    try
                    {
                        tipoProtesis x = db.tipoProtesis.Find(id);
                        x.nombre = tp.nombre;
                        x.descripcion = tp.descripcion;
                        x.foto = tp.foto;
                        db.SaveChanges();
                        return true;
                    }
                    catch (Exception e) {
                        return false;
                    }
                }
            });
        }//EditarTipoProtesisAsync
       
        public Task<bool> AgregarTipoOrtesisAsync(tipoOrtesis to) {
            return Task.Run(() =>
            {
                using (OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities()) { 
                    try {
                        db.tipoOrtesis.Add(to);
                        db.SaveChanges();
                        return true;
                    }
                    catch (Exception e) {
                        return false;
                    }
                }
            });
        }

        public Task<bool> EditarTipoOrtesisAsync(tipoOrtesis tp, int id)
        {
            return Task.Run(() =>
            {
                using (OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities())
                {
                    try
                    {
                        tipoOrtesis x = db.tipoOrtesis.Find(id);
                        x.nombre = tp.nombre;
                        x.descripcion = tp.descripcion;
                        x.foto = tp.foto;
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

        public Task<bool> EliminarProtesisAsync(int id) {
            return Task.Run(() =>
            {
                using (OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities()) { 
                    try
                    {
                        protesis p = db.protesis.Find(id);
                        db.protesis.Remove(p);
                        db.SaveChanges();
                        return true;
                    }
                    catch (Exception e) {
                        return false;
                    }
                }
            });
        }

        public Task<bool> EliminarTipoProtesisAsync(int id)
        {
            return Task.Run(() =>
            {
                using (OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities())
                {
                    try
                    {
                        tipoProtesis tp = db.tipoProtesis.Find(id);
                        db.tipoProtesis.Remove(tp);
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

        public Task<bool> EliminarOrtesisAsync(int id)
        {
            return Task.Run(() =>
            {
                using (OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities())
                {
                    try
                    {
                        ortesis o = db.ortesis.Find(id);
                        db.ortesis.Remove(o);
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

        public Task<bool> EliminarTipoOrtesisAsync(int id)
        {
            return Task.Run(() =>
            {
                using (OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities())
                {
                    try
                    {
                        tipoOrtesis to = db.tipoOrtesis.Find(id);
                        db.tipoOrtesis.Remove(to);
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

        public Task<Lista<protesis>> ObtenerProtesisAsync(String param) {

            return Task.Run(() =>
            {
                Lista<protesis> Protesis = new Lista<protesis>();
                OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities();
                try
                {
                    Protesis = (from protesis in db.protesis
                                join t in db.tipoProtesis on protesis.tipo equals t.id
                                where protesis.nombre.Contains(param)
                                select protesis).ToArray();
                    return Protesis;
                }
                catch (Exception e)
                {
                    return null;
                }
            });

        }//ObtenerProtesisAsync

        public Task<List<tipoOrtesis>> ObtenerTiposOrtesisAsync(String param) {

            return Task.Run(() =>
            {
                List<tipoOrtesis> TipoOrtesis = new List<tipoOrtesis>();
                OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities();
                try {
                    TipoOrtesis = (from tipoOrtesis in db.tipoOrtesis
                                   where tipoOrtesis.nombre.Contains(param)
                                    select tipoOrtesis).ToList();
                    return TipoOrtesis;
                }
                catch (Exception e) {
                    return null;
                }
            });
        }//ObtenerTiposOrtesisAsync

        public Task<tipoOrtesis> ObtenerTipoOrtesiAsync(int id) {
            return Task.Run(() =>
            {
                using (OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities()) { 
                    try
                    {
                        tipoOrtesis to = db.tipoOrtesis.Find(id);
                        return to;
                    }
                    catch (Exception e) {
                        return null;
                    }
                }
            });
        }//ObtenerTipoOrtesiAsync

        public Task<List<tipoProtesis>> ObtenerTiposProtesisAsync(String param)
        {

            return Task.Run(() =>
            {
                List<tipoProtesis> TipoProtesis = new List<tipoProtesis>();
                OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities();
                try
                 {
                    TipoProtesis = (from tipoProtesis in db.tipoProtesis
                                    where tipoProtesis.nombre.Contains(param)
                                    select tipoProtesis).ToList();
                    return TipoProtesis;

                 }
                 catch (Exception e)
                 {
                     return null;
                 }
                
            });
        }//ObtenerTipoProtesisAsync

        public Task<tipoProtesis> ObtenerTipoProtesiAsync(int id)
        {
            return Task.Run(() =>
            {
                using (OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities())
                {
                    try
                    {
                        tipoProtesis tp = db.tipoProtesis.Find(id);
                        return tp;
                    }
                    catch (Exception e)
                    {
                        return null;
                    }
                }
            });
        }//ObtenerTipoOrtesiAsync

        public Task<protesis> ObtenerProtesiAsync(int id) {
            return Task.Run(() =>
            {
                OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities();
                try
                {
                    protesis p = db.protesis.Find(id);
                    return p;
                }
                catch (Exception e) {
                    return null;
                }
            });

        }//ObtenerProtesiAsync

        public Task<ortesis> ObtenerOrtesiAsync(int id)
        {
            return Task.Run(() =>
            {
                OrtopediaVelásquezEntities db = new OrtopediaVelásquezEntities();
                try
                {
                    ortesis o = db.ortesis.Find(id);
                    return o;
                }
                catch (Exception e)
                {
                    return null;
                }
            });

        }//ObtenerOrtesiAsync
    }//Clase
}//NameSpace
