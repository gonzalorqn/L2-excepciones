using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase14
{
    public class ErrorParserException : Exception
    {
        public ErrorParserException() :base()
        {

        }

        public ErrorParserException(string s) :base(s)
        {

        }

        public ErrorParserException(string s,Exception exception) :base(s,exception)
        {

        }
    }
}
