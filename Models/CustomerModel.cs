using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace RepairCustomerDatabase.Models
{
    public class CustomerModel
    {
        public class Customer
        {
            [Key]
            public int CustomerId { get; set;}
            public string Firstname {get; set;}
            public string Lastname { get; set;}
            public string Email {get; set;}
        }

        public class PhoneNumber
        {
            [Key]
            public int PhoneId { get; set; }
            public virtual int CustomerId { get; set; }
            public string Type { get; set; } //cell, home etc
            public string Number { get; set; }
        }

        public class Address
        {
            [Key]
            public int AddressId { get; set; }
            public virtual int CustomerId { get; set; } 
            public string Type { get; set; } //home, work etc
            public string Street { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }

        }

        public class Invoice
        {
            [Key]
            public int InvoiceId { get; set; }
            public virtual int CustomerId { get; set; }
            public virtual int WorkId { get; set; }
        }

        public class InvoiceWork
        {
            [Key]
            public int WorkId { get; set; }
            public virtual int Invoiceid { get; set; }
            public string WorkDone { get; set; }
            public int Hours { get; set; }
            public double Rate { get; set; }
        }

        public class Device
        {
            [Key]
            public int DeviceId { get; set; }
            public virtual int CustomerId { get; set; }
            public string Type { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public string Serial { get; set; }
            public string IP { get; set;  }
            public string Login { get; set; }
            public string Password { get; set; }
        }

        public class Ticket
        {
            [Key]
            public int TicketId { get; set; }
            public virtual int CustomerId { get; set; }
            public virtual int UserId { get; set; }
            public string Priority { get; set; }
            public string Desciption { get; set; }
        }

        
        public class CustomerDbContext : DbContext
        {
            public CustomerDbContext() :
                base("CustomerDbContext") { }

            public DbSet<Customer> Customers { get; set; }
            public DbSet<PhoneNumber> PhoneNumbers { get; set; }
            public DbSet<Address> Addresses { get; set; }
            public DbSet<Invoice> Invoices { get; set; }
            public DbSet<InvoiceWork> InvoiceWorks { get; set; }
            public DbSet<Device> Devices { get; set; }
        }
    }
}