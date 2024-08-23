# cour 02 :

-   **Méthodes:**

| **Méthode**         | **Description**                                                                                                                          | **Syntaxe**                                           |
| ------------------- | ---------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------- |
| **First**           | Retourne le premier élément qui satisfait la condition. Lève une exception si aucun élément n'est trouvé.                                | `var result = collection.First(condition);`           |
| **FirstOrDefault**  | Comme `First`, mais retourne la valeur par défaut (`null` pour les types de référence) si aucun élément n'est trouvé.                    | `var result = collection.FirstOrDefault(condition);`  |
| **Last**            | Retourne le dernier élément qui satisfait la condition. Lève une exception si aucun élément n'est trouvé.                                | `var result = collection.Last(condition);`            |
| **LastOrDefault**   | Comme `Last`, mais retourne la valeur par défaut si aucun élément n'est trouvé.                                                          | `var result = collection.LastOrDefault(condition);`   |
| **Single**          | Retourne l'unique élément qui satisfait la condition. Lève une exception si aucun ou plusieurs éléments sont trouvés.                    | `var result = collection.Single(condition);`          |
| **SingleOrDefault** | Comme `Single`, mais retourne la valeur par défaut si aucun élément n'est trouvé. Lève une exception si plusieurs éléments sont trouvés. | `var result = collection.SingleOrDefault(condition);` |

-   **Exemples détaillés**

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
            List<Person> people = new List<Person>
            {
                new Person { Name = "Alice", Age = 28 },
                new Person { Name = "Bob", Age = 35 },
                new Person { Name = "Charlie", Age = 40 },
                new Person { Name = "David", Age = 22 }
            };

            // First example
            var firstAdult = people.First(p => p.Age >= 18);
            Console.WriteLine($"First Adult: {firstAdult.Name}");

            // FirstOrDefault example
            var firstTeenager = people.FirstOrDefault(p => p.Age < 18);
            Console.WriteLine($"First Teenager: {(firstTeenager != null ? firstTeenager.Name : "None")}");

            // Last example
            var lastAdult = people.Last(p => p.Age >= 18);
            Console.WriteLine($"Last Adult: {lastAdult.Name}");

            // LastOrDefault example
            var lastTeenager = people.LastOrDefault(p => p.Age < 18);
            Console.WriteLine($"Last Teenager: {(lastTeenager != null ? lastTeenager.Name : "None")}");

            // Single example (This will throw an exception if there is more than one "Alice")
            var uniquePerson = people.Single(p => p.Name == "Alice");
            Console.WriteLine($"Unique Person: {uniquePerson.Name}");

            // SingleOrDefault example
            var singleTeenager = people.SingleOrDefault(p => p.Age < 18);
            Console.WriteLine($"Single Teenager: {(singleTeenager != null ? singleTeenager.Name : "None")}");
        }
    }
    ```
