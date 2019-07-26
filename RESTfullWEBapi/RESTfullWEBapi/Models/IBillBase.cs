using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTfullAPI.Models
{
    public interface IBillBase
    {
        // метод для получения сведений обо всех открытых расчетных счетах банка
        IEnumerable<Bill> ShowAllBills();
        // метод для получения сведений по одному выбранному расчетному счету банка
        Bill GetBill(int id);
        // метод для открытия нового р/с в банке
        void OpenBill(Bill inst);
        // метод для пополнения и снятия ДС с выбранного р/с в банке
        void DebitCreditBill(int id, int sum);
        // метод для выбранного р/с в банке
        void CloseBill(int id);
    }
}
