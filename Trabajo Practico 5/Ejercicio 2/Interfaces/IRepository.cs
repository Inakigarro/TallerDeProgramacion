using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2.Controladores
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Agregar(TEntity pEntity);
        void Eliminar(TEntity pEntity);
        TEntity Obtener(int pId);
        IEnumerable<TEntity> ObtenerTodos();
    }
}
