# cour 07 :

-   **Méthodes:**

| **Méthode**      | **Description**                                                                                     | **Syntaxe**                                          |
| ---------------- | --------------------------------------------------------------------------------------------------- | ---------------------------------------------------- |
| **Select**       | Projette chaque élément d'une collection dans une nouvelle forme.                                   | `var result = collection.Select(selector);`          |
| **SelectMany**   | Projette chaque élément d'une collection et les aplatie en une séquence unique.                     | `var result = collection.SelectMany(selector);`      |
| **ToList**       | Convertit une collection en une liste (`List<T>`).                                                  | `var result = collection.ToList();`                  |
| **ToArray**      | Convertit une collection en un tableau (`T[]`).                                                     | `var result = collection.ToArray();`                 |
| **ToDictionary** | Convertit une collection en un dictionnaire (`Dictionary<TKey, TValue>`), basé sur une clé définie. | `var result = collection.ToDictionary(keySelector);` |

-   **Exemple complet :**

    ```csharp
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Hobbies { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            // Création d'une liste de personnes
            List<Person> people = new List<Person>
            {
                new Person { Name = "Alice", Age = 25, Hobbies = new List<string> { "Reading", "Swimming" } },
                new Person { Name = "Bob", Age = 30, Hobbies = new List<string> { "Cycling", "Running" } },
                new Person { Name = "Charlie", Age = 35, Hobbies = new List<string> { "Swimming", "Hiking" } }
            };

            // Select: Sélectionner les noms des personnes
            var names = people.Select(p => p.Name);
            Console.WriteLine("Names (Select): " + string.Join(", ", names));

            // SelectMany: Sélectionner et aplatir la liste des hobbies
            var allHobbies = people.SelectMany(p => p.Hobbies).Distinct();
            Console.WriteLine("All Hobbies (SelectMany): " + string.Join(", ", allHobbies));

            // ToList: Convertir la liste des noms en List<string>
            var namesList = names.ToList();
            Console.WriteLine("Names List (ToList): " + string.Join(", ", namesList));

            // ToArray: Convertir la liste des noms en tableau string[]
            var namesArray = names.ToArray();
            Console.WriteLine("Names Array (ToArray): " + string.Join(", ", namesArray));

            // ToDictionary: Convertir la liste des personnes en Dictionary avec Name comme clé et Age comme valeur
            var peopleDictionary = people.ToDictionary(p => p.Name, p => p.Age);
            Console.WriteLine("People Dictionary (ToDictionary):");
            foreach (var kvp in peopleDictionary)
            {
                Console.WriteLine($"Name: {kvp.Key}, Age: {kvp.Value}");
            }
        }
    }
    ```
