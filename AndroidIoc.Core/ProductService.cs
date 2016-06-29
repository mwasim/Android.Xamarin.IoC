using System.Collections.Generic;

namespace AndroidIoc.Core
{
    public class ProductService : IProductService
    {
        public IEnumerable<Product> GetAll()
        {
            return new List<Product>
            {
                new Product {
                    Id =1,
                    Name = "Google Android 2.2",
                    Description = "Products's description.",
                    },
                new Product {
                    Id =2,
                    Name = "Apple iPad",
                    Description = "Products's description.",
                    },
                new Product {
                    Id =3,
                    Name = "Amazon Kindle (third-generation)",
                    Description = "Products's description.",
                    },
                new Product {
                    Id =4,
                    Name = "Netflix",
                    Description = "Products's description.",
                    },
                new Product {
                    Id =5,
                    Name = "Samsung Galaxy Tab",
                    Description = "Products's description.",
                    },
                new Product {
                    Id =6,
                    Name = "Sony Alpha NEX-5",
                    Description = "Products's description.",
                    },
                 new Product {
                    Id =7,
                    Name = "HP Envy 14 Beats Edition",
                    Description = "Products's description.",
                    },
                  new Product {
                    Id =8,
                    Name = "Samsung Epic 4G",
                    Description = "Products's description.",
                    },
                   new Product {
                    Id =9,
                    Name = "Instapaper",
                    Description = "Products's description.",
                    },
                    new Product {
                    Id =10,
                    Name = "HP TouchSmart 600 Quad",
                    Description = "Products's description.",
                    },
                     new Product {
                    Id =11,
                    Name = "Panasonic Lumix DMC-LX5",
                    Description = "Products's description.",
                    },
                      new Product {
                    Id =12,
                    Name = "Samsung LN46C650",
                    Description = "Products's description.",
                    },
                       new Product {
                    Id =13,
                    Name = "Apple TV",
                    Description = "Products's description.",
                    },
                        new Product {
                    Id =14,
                    Name = "Canon Pixma MG8120",
                    Description = "Products's description.",
                    },
                        new Product {
                    Id =15,
                    Name = "Motorola Droid X",
                    Description = "Products's description.",
                    },
                        new Product {
                    Id =16,
                    Name = "Adobe Creative Suite 5",
                    Description = "Products's description.",
                    },
                        new Product {
                    Id =17,
                    Name = "Sony Handycam NEX-VG10",
                    Description = "Products's description.",
                    },
                        new Product {
                    Id =18,
                    Name = "Sonos ZonePlayer S5",
                    Description = "Products's description.",
                    },
                        new Product {
                    Id =19,
                    Name = "Origin Genesis Midtower",
                    Description = "Products's description.",
                    },
                        new Product {
                    Id =20,
                    Name = "Logitech C910",
                    Description = "Products's description.",
                    },
                        new Product {
                    Id =21,
                    Name = "Flipboard",
                    Description = "Products's description.",
                    },
                        new Product {
                    Id =22,
                    Name = "HTC Droid Incredible",
                    Description = "Products's description.",
                    },
                        new Product {
                    Id =23,
                    Name = "XMind",
                    Description = "Products's description.",
                    },
                        new Product {
                    Id =24,
                    Name = "Smartfish ErgoMotion Mouse",
                    Description = "Products's description.",
                    },
                        new Product {
                    Id =25,
                    Name = "Fuze Box Fuze Meeting",
                    Description = "Products's description.",
                    },                        
            };
        }
    }
}
