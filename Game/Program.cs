using Game.entities;
using Game.Interfaces;
using Game.Concrete;
using System;

namespace Game
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // Müşteri -  Üye işlemleri
            
            Customer customer1 = new Customer() { Id = 1, FirstName = "Ziya", LastName = "SELÇUK", DateOfBirth = new DateTime(1950, 12, 1), NationaltyNo = "12345678682", PhoneNumber = "555 555 55 55", CustomerType = 1 , SaleGame=""};
            CustomerManager customerManager = new CustomerManager();
            
            if (customerManager.RealPersonControl(customer1))
            {
                customerManager.Save(customer1);
            }
            else
            {
                throw new Exception("Geçersiz T.C. Kimlik No");
            }

            // Oyun İşlemleri youn satışı.
            Games game1 = new Games() { Id = 1, GameName = "GTA5", GamePrize = 30, GameRating = 5 };
            GameManager gameManager = new GameManager();
            customerManager.Buy(customer1,game1);
            




        }
        
    }
}
