using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RESTfullAPI.Models;

namespace RESTfullAPI.Controllers
{
    public class ClientController : ApiController
    {
        public IClientBase cl = ClientBase.GetStaticClient();
        
        [HttpGet]
        public IEnumerable<Client> ShowAllClients()
        {
            return cl.ShowAllClients();
        }

        [HttpGet]
        public Client GetClient(int id)
        {
            return cl.GetClient(id);
        }

        [HttpPost]
        public void AddClient([FromBody]Client inst)
        {
            cl.AddClient(inst);
        }
        [HttpPut]
        public bool UpdateClient(int id, Client inst)
        {
            return cl.UpdateClient(id, inst);
        }

        [HttpDelete]
        public void DeleteCient(int id)
        {
            cl.DeleteCient(id);
        }
    }
}
