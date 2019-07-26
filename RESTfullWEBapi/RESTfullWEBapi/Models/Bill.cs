using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RESTfullAPI.Models
{
    public class Bill
    {
        public int BillId { get; set; }
        public string BillNumber { get; set; }
        public double BillBalance { get; set; }

        // Идентификатор владельца р/с
        public int Owner { get; set; }
    }
}