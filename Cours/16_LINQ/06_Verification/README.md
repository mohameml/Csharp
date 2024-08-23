# cour 06 :

-   **Méthodes:**

    | **Méthode** | **Description**                                                                         | **Syntaxe**                               |
    | ----------- | --------------------------------------------------------------------------------------- | ----------------------------------------- |
    | **All**     | Retourne `true` si tous les éléments de la collection satisfont une condition donnée.   | `var result = collection.All(condition);` |
    | **Any**     | Retourne `true` si au moins un élément de la collection satisfait une condition donnée. | `var result = collection.Any(condition);` |

-   **Exemple :**

    ```csharp
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            // Création d'une liste de personnes
            List<Person> people = new List<Person>
            {
                new Person { Name = "Alice", Age = 25 },
                new Person { Name = "Bob", Age = 30 },
                new Person { Name = "Charlie", Age = 35 },
                new Person { Name = "David", Age = 40 }
            };

            // All: Vérifier si toutes les personnes ont plus de 20 ans
            bool allAbove20 = people.All(p => p.Age > 20);
            Console.WriteLine("All above 20: " + allAbove20);  // Résultat: True

            // All: Vérifier si toutes les personnes ont plus de 30 ans
            bool allAbove30 = people.All(p => p.Age > 30);
            Console.WriteLine("All above 30: " + allAbove30);  // Résultat: False

            // Any: Vérifier s'il y a au moins une personne ayant plus de 30 ans
            bool anyAbove30 = people.Any(p => p.Age > 30);
            Console.WriteLine("Any above 30: " + anyAbove30);  // Résultat: True

            // Any: Vérifier s'il y a au moins une personne ayant plus de 50 ans
            bool anyAbove50 = people.Any(p => p.Age > 50);
            Console.WriteLine("Any above 50: " + anyAbove50);  // Résultat: False
        }
    }
    ```
