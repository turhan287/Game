using Game.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Interfaces
{
    public interface ICustomerServices
    {
        void Save(Customer customer);

        void Update(Customer customer);

        void Delete(Customer customer);

        bool RealPersonControl(Customer customer);

        abstract void Buy(Customer customer, Games game);
        
        
    }
}
