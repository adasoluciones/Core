using System.Collections.Generic;
using System.Linq;

namespace Ada.Framework.Core
{
    public abstract class Enumeracion<T>
    {
        public virtual T Codigo { get; private set; }
        private static IList<Enumeracion<T>> Valores = new List<Enumeracion<T>>();

        protected Enumeracion(T codigo)
        {
            Codigo = codigo;
            Valores.Add(this);
        }
        
        public bool Equals(Enumeracion<T> enumeracion)
        {
            return enumeracion.Codigo.Equals(Codigo);
        }
        
        public override string ToString()
        {
            if (Codigo == null) return null;
            return Codigo.ToString();
        }
        
        public static Enumeracion<T> ObtenerEnumeracion(T valor)
        {
            return Valores.FirstOrDefault(c => c.Codigo.Equals(valor));
        }
    }
}
