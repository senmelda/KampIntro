using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet
    class Product //Entity(varlık)
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        //ürünün birim fiyatı
        public double UnitPrice { get; set; }
        //stok adedi
        public int UnitInStock { get; set; }
        
        //CRUD OPERASYONLARI

    }
}
