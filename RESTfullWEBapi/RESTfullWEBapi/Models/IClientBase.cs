using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RESTfullAPI.Models
{
    public interface IClientBase
    {
        // метод для получения сведений обо всех клиентах банка
        IEnumerable<Client> ShowAllClients();
        // метод для получения сведений по одному выбранному клиенту банка
        Client GetClient(int id);
        // метод для добавления нового клиента банка
        void AddClient(Client inst);
        // метод для редактирования сведений о клиенте банка
        bool UpdateClient(int id, Client inst);
        // метод для удаления клиента банка
        void DeleteCient(int id);
    }
}
