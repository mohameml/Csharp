# cour :

-   **Description:**

    > `GroupBy` permet de créer un groupe d'éléments qui partagent une même clé. Chaque groupe est représenté par une clé unique et contient une collection des éléments associés à cette clé. Cela vous permet de manipuler et de traiter des données groupées facilement.

-   **Syntaxe:**

    La méthode `GroupBy` se compose de la clé de regroupement et d'une projection (optionnelle) pour transformer les éléments regroupés.

    ```csharp
    var groupedResult = collection.GroupBy(
        item => item.Key, // Clé de regroupement
        item => item , // Val associeé au clé
        (key, group) => new // Projection des groupes
        {
            Key = key,
            Items = group.ToList()
        }
    );
    ```

-   **Syntaxe de la requête LINQ (requête syntaxique):**

    La syntaxe de requête LINQ utilise `group by` pour effectuer le regroupement.

    ```csharp
    var groupedResult = from item in collection
                        group item by item.Key into grouped
                        select new
                        {
                            Key = grouped.Key,
                            Items = grouped.ToList()
                        };
    ```

-   **Exemple:**

    Imaginons que vous ayez une liste de produits avec leur catégorie, et vous souhaitez regrouper ces produits par catégorie.

    ```csharp
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            // Données d'exemple
            var products = new List<Product>
            {
                new Product { Name = "Laptop", Category = "Electronics" },
                new Product { Name = "Smartphone", Category = "Electronics" },
                new Product { Name = "T-shirt", Category = "Apparel" },
                new Product { Name = "Jeans", Category = "Apparel" },
                new Product { Name = "Blender", Category = "Home Appliances" }
            };

            // Regroupement avec la méthode GroupBy
            var groupedProducts = products.GroupBy(
                p => p.Category, // Clé de regroupement
                p => p ,
                (category, group) => new
                {
                    Category = category,
                    Products = group.ToList()
                }
            );

            // Affichage des résultats
            foreach (var categoryGroup in groupedProducts)
            {
                Console.WriteLine($"Category: {categoryGroup.Category}");
                foreach (var product in categoryGroup.Products)
                {
                    Console.WriteLine($" - {product.Name}");
                }
            }


        }
    }
    ```
