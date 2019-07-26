using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RESTfullAPI.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string ClientFullName { get; set; }
        public int ClientAge { get; set; }

        public List<Bill> BillsClient;
    }
}