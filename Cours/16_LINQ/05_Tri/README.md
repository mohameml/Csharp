# cour 05 :

-   **Méthodes:**

| **Méthode**           | **Description**                                                                                       | **Syntaxe**                                               |
| --------------------- | ----------------------------------------------------------------------------------------------------- | --------------------------------------------------------- |
| **OrderBy**           | Trie les éléments de la collection par ordre croissant en fonction d'une clé.                         | `var result = collection.OrderBy(keySelector);`           |
| **OrderByDescending** | Trie les éléments de la collection par ordre décroissant en fonction d'une clé.                       | `var result = collection.OrderByDescending(keySelector);` |
| **ThenBy**            | Trie les éléments de la collection par ordre croissant selon une clé secondaire après un `OrderBy`.   | `var result = collection.ThenBy(keySelector);`            |
| **ThenByDescending**  | Trie les éléments de la collection par ordre décroissant selon une clé secondaire après un `OrderBy`. | `var result = collection.ThenByDescending(keySelector);`  |

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
                new Person { Name = "Charlie", Age = 25 },
                new Person { Name = "David", Age = 35 },
                new Person { Name = "Eve", Age = 30 }
            };

            // OrderBy: Trier par âge croissant
            var sortedByAge = people.OrderBy(p => p.Age);
            Console.WriteLine("OrderBy Age:");
            foreach (var person in sortedByAge)
            {
                Console.WriteLine($"{person.Name}, {person.Age}");
            }

            // OrderByDescending: Trier par âge décroissant
            var sortedByAgeDesc = people.OrderByDescending(p => p.Age);
            Console.WriteLine("\nOrderByDescending Age:");
            foreach (var person in sortedByAgeDesc)
            {
                Console.WriteLine($"{person.Name}, {person.Age}");
            }

            // ThenBy: Trier par âge croissant puis par nom croissant
            var sortedByAgeThenName = people.OrderBy(p => p.Age).ThenBy(p => p.Name);
            Console.WriteLine("\nOrderBy Age, ThenBy Name:");
            foreach (var person in sortedByAgeThenName)
            {
                Console.WriteLine($"{person.Name}, {person.Age}");
            }

            // ThenByDescending: Trier par âge croissant puis par nom décroissant
            var sortedByAgeThenNameDesc = people.OrderBy(p => p.Age).ThenByDescending(p => p.Name);
            Console.WriteLine("\nOrderBy Age, ThenByDescending Name:");
            foreach (var person in sortedByAgeThenNameDesc)
            {
                Console.WriteLine($"{person.Name}, {person.Age}");
            }
        }
    }
    ```
