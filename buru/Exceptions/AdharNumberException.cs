using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace buru.Exceptions
{
    public class AdharNumberException:Exception
    {
        public AdharNumberException():base("Adhar number can't be same"){}
    }
}