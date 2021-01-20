using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager //ProductService de denebilir.
    {
        //encapsulation : parametre olarak birçok şey yazmak yerine . vererek classı çağırabilmek.
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        //int döndürdüğünde oradan çıkan değeri bir yerde kullanacağım anlamında kullanırsın. void kullanımında mesela ekle dedik ve bitti.
    }
}
