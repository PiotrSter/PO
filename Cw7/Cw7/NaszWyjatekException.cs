using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Cw7
{
    public class NaszWyjatekException: SystemException
    {
        int liczba4;

        protected NaszWyjatekException(string message)
            : base(message)
        {

        }

        protected NaszWyjatekException(string message, Exception innerExpection)
            :base(message, innerExpection)
        {

        }

        protected NaszWyjatekException(SerializationInfo info, StreamingContext context)
            :base(info, context)
        {

        }
    }
}
