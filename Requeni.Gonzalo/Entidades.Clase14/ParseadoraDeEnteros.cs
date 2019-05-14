using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase14
{
    public static class ParseadoraDeEnteros
    {
        public static int Parse(string cadena)
        {
            int retorno = 0;
            try
            {
                retorno = int.Parse(cadena);
            }
            catch (FormatException e)
            {
                throw new ErrorParserException("El string no podrá ser convertido por error de formato", e);
            }
            catch (OverflowException e)
            {
                throw new ErrorParserException("El string no podrá ser convertido por tamaño del dato", e);
            }
            return retorno;
        }

        public static bool TryParse(string cadena, out int entero)
        {
            try
            {
                entero = int.Parse(cadena);
            }
            catch (Exception e)
            {
                entero = 0;
                return false;
                throw new ErrorParserException("El string no podrá ser convertido", e);
            }
            return true;
        }
    }
}
