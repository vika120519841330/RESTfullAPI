using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace RESTfullAPI.Models
{
    public class BillBase : IBillBase
    {
        public List<Bill> BillsData = new List<Bill>
        {
            new Bill
            {
                BillId = 11,
                BillBalance = 120,
                BillNumber = "123456781",
                Owner = 1
            },
            new Bill
            {
                BillId = 12,
                BillBalance = 0,
                BillNumber = "123456782",
                Owner = 1
            },
            new Bill
            {
                BillId = 13,
                BillBalance = 1100,
                BillNumber = "123456783",
                Owner = 2
            },
            new Bill
            {
                BillId = 14,
                BillBalance = 1230,
                BillNumber = "123456784",
                Owner = 2
            },
            new Bill
            {
                BillId = 15,
                BillBalance = 57457,
                BillNumber = "123456785",
                Owner = 3
            }
        };
        // Статический обьект класса
        public static BillBase bb = new BillBase();
        public static IBillBase GetStaticClient()
        {
            return bb;
        }
        public IEnumerable<Bill> ShowAllBills()
        {
            return BillsData;
        }
        public Bill GetBill(int id)
        {
            var tmp = from bd in BillsData
                      where bd.BillId == id
                      select bd;
            return tmp.Count() > 0 ? tmp.First() : null;
        }
        public void OpenBill(Bill inst)
        {
            inst.BillId = BillsData.Count + 1;
            BillsData.Add(inst);
        }
        public void DebitCreditBill(int id, int sum)
        {
            Bill tmp = GetBill(id);
            if (tmp != null)
            {
                var temp = tmp.BillBalance + sum;
                if (temp >= 0)
                {
                    tmp.BillBalance = tmp.BillBalance + sum;
                }
                else
                {
                    Console.WriteLine("Сумма снятия превышает остаток денежных средств на расчетном счете клиента!!" +
                        "Попробуйте снять другую сумму!!");
                }
            }
            else
            {
                Console.WriteLine("Запрошенный идентификационный номер клиента не существует!!" +
                    "Попробуйте ввести другой идентификационный номер клиента!!");
            }
        }
        public void CloseBill(int id)
        {
            Bill tmp = GetBill(id);
            if (tmp != null)
                BillsData.Remove(tmp);
        }
    }
}