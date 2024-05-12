using buru.Exceptions;
using buru.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace buru.Controllers
{
    
    public class DonarController :ApiController
    {
        DBBlueEntities context =new DBBlueEntities();
        [HttpGet]
        [Route("GetDr")]
          public List<TBLData> DonarList()
        {
            return context.TBLDatas.ToList();
        }
        public object PostDonar(TBLData data)
        {
            try
            {
                if(context.TBLDatas.Any(c =>c.adharnumber.ToLower() == data.adharnumber.ToLower()))
                {
                    throw new AdharNumberException();
                }
                if(data.donationamount <= 0)
                {
                    throw new DonationLessThenZero();
                }
                context.TBLDatas.Add(data);
                context.SaveChanges();
                return new { output=true ,message=""};
            }
            catch(AdharNumberException ex)
            {
                return new { output =false, message=ex.Message};
            }
            catch(DonationLessThenZero ex)
            {
                return new { output = false, message = ex.Message };
            }
        }
    }
}