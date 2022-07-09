using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matuhaMagasin
{
    
    public class products
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public products(string Id, string Name, int Amount, double Price)
        {
            this.Id = Id;
            this.Name = Name;
            this.Amount = Amount;
            this.Price = Price;
        }
    }
    public class suppliers
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public suppliers(string Id, string Name) 
        {
            this.Id= Id;
            this.Name= Name;
        }
    }
    public class supplies
    {
        public string Id { get; set; }
        public string Id_suppliers { get; set; }
        public string Id_product { get; set; }
        public int Amount { get; set; }
        public double totalPrice{ get; set; }
        public DateTime date { get; set; }
        public supplies(string Id, string Id_suppliers, string Id_product, int Amount, double totalPrice, DateTime date)
        {
            this.Id = Id;
            this.Id_suppliers = Id_suppliers;
            this.Id_product = Id_product;
            this.Amount =Amount;
            this.totalPrice = totalPrice;
            this.date = date;
        }
    }
    public class payments
    {
        public string Id { get; set; }
        public string id_supplies { get; set; }
        public double paid { get; set; }
        public DateTime date { get; set; }
        public payments(string Id, string id_supplies, double paid, DateTime date)
        {
            this.Id = Id;
            this.id_supplies = id_supplies;
            this.paid = paid;
            this.date = date;
        }
    }

    public class report
    {
        // Итоговый отчёт
        public string supplierName { get; set; }
        public string productName { get; set; }
        public double orderPrice { get; set; }
        public double paidSum { get; set; }
        public double debt { get; set; }
        // подготовка к отчёту
        public string id_supplies { get; set; }
        public DateTime date { get; set; }

        public report(string supplierName, string productName, double orderPrice, string id_supplies, DateTime date)
        {
            this.supplierName = supplierName;
            this.productName = productName;
            this.orderPrice = orderPrice;
            this.id_supplies = id_supplies;
            this.date = date;
        }
        // Итоговый отчёт
        public report(string supplierName, string productName, double orderPrice, double paidSum, double debt)
        {
            this.supplierName = supplierName;
            this.productName = productName;
            this.orderPrice = orderPrice;
            this.paidSum = paidSum;
            this.debt = debt;
        }
    }
}
