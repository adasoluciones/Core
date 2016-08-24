using System;

namespace Ada.Framework.Core.CustomAttributes.Object
{
    /// <summary>
    /// Especifica que un objeto no tiene subpropiedades que se puedan editar.Esta clase no se puede heredar.
    /// </summary>
    /// <remarks>
    ///     Registro de versiones:
    ///     
    ///         1.0 02/03/2015 Marcos Abraham Hernández Bravo (Ada Ltda.): versión inicial.
    /// </remarks>
    [AttributeUsage(AttributeTargets.All)]
    public sealed class Inmutable : Attribute
    {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        ///     Registro de versiones:
        ///     
        ///         1.0 02/03/2015 Marcos Abraham Hernández Bravo (Ada Ltda.): versión inicial.
        /// </remarks>
        public bool EsInmutable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        ///     Registro de versiones:
        ///     
        ///         1.0 02/03/2015 Marcos Abraham Hernández Bravo (Ada Ltda.): versión inicial.
        /// </remarks>
        /// <param name="esInmutable"></param>
        public Inmutable(bool esInmutable)
        {
            EsInmutable = esInmutable;
        }
    }
}
