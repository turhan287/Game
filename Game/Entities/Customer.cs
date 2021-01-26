using Game.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.entities
{
    public class Customer : IEntity

    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationaltyNo { get; set; }
        public int CustomerType { get; set; }
        public string PhoneNumber { get; set; }
        public string SaleGame { get; set; }
    }
}
