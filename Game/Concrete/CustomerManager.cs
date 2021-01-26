using Game.entities;
using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Concrete
{
    public class CustomerManager : ICustomerServices

    {
        public void Buy(Customer customer, Games game )
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName +", "+ game.GameName+" Oyunu "+game.GamePrize+ " TL ye Satış Yapıldı.");
        }

       
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName+" "+customer.LastName+" Silindi");
        }

        public bool RealPersonControl(Customer customer)
        {
            Console.WriteLine(customer.NationaltyNo + " T.C.Kimlik Nolu " + customer.FirstName + " " + customer.LastName + " Kontrol Ediliyor.");
            return true;
        
        }

        public void Save(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " Kaydedildi");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " Güncellendi");
        }


    }
}
