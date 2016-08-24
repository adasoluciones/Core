
namespace Ada.Framework.Core.Exceptions
{
    public sealed class ArgumentoInvalido : Enumeracion<string>
    {
        private ArgumentoInvalido(string codigo) : base(codigo) { }

        public static ArgumentoInvalido NULO = new ArgumentoInvalido("¡El valor del parametro no puede ser nulo!");
        public static ArgumentoInvalido VACIO = new ArgumentoInvalido("¡El valor del parametro no puede ser vacio!");
        public static ArgumentoInvalido NULO_VACIO = new ArgumentoInvalido("¡El valor del parametro no puede ser nulo ni vacio!");

        public new static Enumeracion<string> ObtenerEnumeracion(string valor)
        {
            switch (valor)
            {
                case "NULO":
                    return NULO;
                case "VACIO":
                    return VACIO;
                case "NULO_VACIO":
                    return NULO_VACIO;
                default:
                    return null;
            }
        }
    }
}
