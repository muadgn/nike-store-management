using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikeStore
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname}";

        }
    }

    public class Product
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public double StockAmount { get; set; }
        public string UnitPrice { get; set; }
        public string Detail { get; set; }
        public override string ToString()
        {
            return $"{Name} {Detail}";

        }
    }

    public class Sale
    {
        public Guid Id { get; set; }
        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public DateTime SaleDate { get; set; }
        public double SalePrice { get; set; }

    }

    public class Payment
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime TransactionDate { get; set; }
        public double Amount { get; set; }
        public string PaymentType { get; set; }
        public string Description { get; set; }

    }

    public class User 
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string PasswordClear { get; set; }
        public string PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}

