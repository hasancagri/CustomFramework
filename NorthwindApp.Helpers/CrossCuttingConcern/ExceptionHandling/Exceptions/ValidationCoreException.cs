using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindApp.Helpers.CrossCuttingConcern.ExceptionHandling.Exceptions
{
    public class ValidationCoreException 
        : NotificationException
    {
        public ValidationCoreException(string mesaj)
            : base(mesaj)
        {

        }

        public ValidationCoreException(string mesaj, Exception hata)
            : base(mesaj, hata)
        {

        }
    }
}
