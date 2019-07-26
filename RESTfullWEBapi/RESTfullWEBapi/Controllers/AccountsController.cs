using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RESTfullAPI.Models;

namespace RESTfullAPI.Controllers
{
    public class BillController : ApiController
    {
        public IBillBase bl;

        public BillController()
        {
            bl = BillBase.GetStaticClient();
        }
        
        [HttpGet]
        public IEnumerable<Bill> ShowAllBills()
        {
            return bl.ShowAllBills();
        }

        [HttpGet]
        public Bill GetBill(int id)
        {
            return bl.GetBill(id);
        }

        [HttpPost]
        public void OpenBill([FromBody]Bill inst)
        {
            bl.OpenBill(inst);
        }

        [HttpPut]
        public void DebitCreditBill(int id, int sum)
        {
            bl.DebitCreditBill(id, sum);
        }

        [HttpDelete]
        public void CloseBill(int id)
        {
            bl.CloseBill(id);
        }
    }
}
