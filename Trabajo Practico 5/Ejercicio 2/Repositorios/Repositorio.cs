using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2.Controladores
{
    public class Repositorio<TEntity, TDbContext> : IRepository<TEntity> where TEntity : class where TDbContext : DbContext
    {
        //Atributos de la clase.
        protected TDbContext iDbContext { get; }

        //Constructor de la clase.
        public Repositorio(TDbContext pDbContext)
        {
            iDbContext = pDbContext;
        }

        public void Agregar(TEntity pEntity)
        {
            using (iDbContext)
            {
                iDbContext.Set<TEntity>().Add(pEntity);
            }   
        }

        public void Eliminar(TEntity pEntity)
        {
            iDbContext.Set<TEntity>().Remove(pEntity);
        }

        public TEntity Obtener(int pId)
        {
            return iDbContext.Set<TEntity>().Find(pId);
        }

        public IEnumerable<TEntity> ObtenerTodos()
        {
            return iDbContext.Set<TEntity>();
        }
    }
}
