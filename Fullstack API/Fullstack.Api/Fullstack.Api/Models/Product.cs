namespace Fullstack.Api.Models
{
    public class Product
    {
        public int Id { get; set; } 
        public string CatagoryId { get; set; }
        public string UnitName { get; set; }
        public string Name { get; set; }
        public int  Code { get; set; }
        public int ProductCode { get; set; }
        public string Description { get; set; }
        public string BrandName { get; set; }
        public string SizeName { get; set;}
        public String ColorName { get; set; }
        public string ModelName { get; set; }
        public string varientName { get; set; }
        public double OldPrice { get; set; }
        public double Price { get; set; }
        public double CostPrice { get; set; }
        public double Stock { get; set; }
        public double TotalParches { get; set;}
        public DateTime LastParchesDate { get; set;}
        public string  LastParchesSupplier { get; set; }
        public double TotalSales { get; set; }
        public DateTime LastSalesDate { get; set; }
        public string  LastSalesCustomer { get; set;}
        public string ImagePath { get;set; }
        public string Type { get; set; }
        public string Status { get; set; }

    }
}
