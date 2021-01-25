using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        // ürün ismi
        public int Id { get; set; }
        // hangi kategoriye dahil olduğu
        public int CategoryId { get; set; }
        //ürün ismi
        public string ProductName { get; set; }
        //ürünün birim fiyatı
        public double UnitPrice { get; set; }
        //ürünün stok adedi
        public int UnitInStock { get; set; }
    }
}
