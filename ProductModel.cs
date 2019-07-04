using System;
using System.Collections.Generic;
using System.Text;

namespace CodeProblems
{
    class ProductModel
    {
        public enum ProductType
        {
            BOOK,
            FOOD,
            MEDICAL_PRODUCT,
            OTHER
        };

        public int Quantity { get; set; }
        public string ItemName { get; set; }
        public double Price { get; set; }
        public ProductType ItemType { get; set; }
    }
}
