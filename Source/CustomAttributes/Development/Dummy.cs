using System;

namespace Ada.Framework.Core.CustomAttributes.Development
{
    /// <summary>
    /// Especifica que un objeto es un Dummy o valor de prueba y debe cambiarse.
    /// </summary>
    /// <remarks>
    ///     Registro de versiones:
    ///     
    ///         1.0 02/03/2015 Marcos Abraham Hernández Bravo (Ada Ltda.): versión inicial.
    /// </remarks>
    [System.AttributeUsage(System.AttributeTargets.All)]
    public class Dummy : Attribute
    {
        /// <summary>
        /// Obtiene o establece un valor que indica si el Dummy debe ser reemplazado.
        /// </summary>
        /// <remarks>
        ///     Registro de versiones:
        ///     
        ///         1.0 02/03/2015 Marcos Abraham Hernández Bravo (Ada Ltda.): versión inicial.
        /// </remarks>
        public bool Cambiar { get; set; }

        /// <summary>
        /// Constructor que inicializa las propiedades del atributo.
        /// </summary>
        /// <remarks>
        ///     Registro de versiones:
        ///     
        ///         1.0 02/03/2015 Marcos Abraham Hernández Bravo (Ada Ltda.): versión inicial.
        /// </remarks>
        /// <param name="cambiar">Valor que indica si se debe cambiar el valor o será el definitivo.</param>
        public Dummy(bool cambiar)
        {
            Cambiar = cambiar;
        }
    }
}
