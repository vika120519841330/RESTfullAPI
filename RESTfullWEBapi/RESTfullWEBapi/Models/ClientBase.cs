using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace RESTfullAPI.Models
{
    public class ClientBase : IClientBase
    {
        // Коллекция всех клиентов банка
        public List<Client> ClientsData = new List<Client>
        {
            new Client
            {
                ClientId = 1,
                ClientFullName = "Иванов Иван Иванович",
                ClientAge = 55,
                BillsClient = new List<Bill>
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
                    }
                }
            },
            new Client
            {
                ClientId = 2,
                ClientFullName = "Петров Петр Петрович",
                ClientAge = 35,
                BillsClient = new List<Bill>
                {
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
                    }
                }
            },
            new Client
            {
                ClientId = 3,
                ClientFullName = "Сидоров Николай Петрович",
                ClientAge = 19,
                BillsClient = new List<Bill>
                {
                    new Bill
                    {
                        BillId = 15,
                        BillBalance = 57457,
                        BillNumber = "123456785",
                        Owner = 3
                    }
                }
            }
        };
        // Статический обьект класса
        private static ClientBase cb = new ClientBase();
        public static IClientBase GetStaticClient()
        {
            return cb;
        }
        public IEnumerable<Client> ShowAllClients()
        {
            return ClientsData;
        }
        public Client GetClient(int id)
        {
            var tmp = from dc in ClientsData
                      where dc.ClientId == id
                      select dc;
            return tmp.Count() > 0 ? tmp.First() : null;
        }
        public void AddClient(Client inst)
        {
            inst.ClientId = ClientsData.Count + 1;
            ClientsData.Add(inst);
        }
        public bool UpdateClient(int id, Client inst)
        {
            if (id == inst.ClientId)
            {
                Client tmp = GetClient(inst.ClientId);
                if (tmp != null)
                {
                    tmp.ClientAge = inst.ClientAge;
                    tmp.ClientFullName = inst.ClientFullName;
                    return true;
                }
                else
                    return false;
            }
            else
            {
                Console.WriteLine("Идентификационные номера клиентов не совпадают!!" +
                    "Попробуйте ввести другой идентификационный номер клиента!!");
                return false;
            }
        }
        public void DeleteCient(int id)
        {
            Client tmp = GetClient(id);
            if (tmp != null)
                ClientsData.Remove(tmp);
        }
    }
}