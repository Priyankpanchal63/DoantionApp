using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace buru.Exceptions
{
    public class DonationLessThenZero:Exception
    {
        public DonationLessThenZero() : base("Donation not be Zero") { }
    }
}