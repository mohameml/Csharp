# cour 04 :

-   **Exemple:**

    | **Méthode** | **Description**                                   | **Syntaxe**                                  |
    | ----------- | ------------------------------------------------- | -------------------------------------------- |
    | **Average** | Calcule la moyenne des éléments de la collection. | `var result = collection.Average(selector);` |
    | **Count**   | Retourne le nombre d'éléments dans la collection. | `var result = collection.Count(condition);`  |
    | **Max**     | Retourne la valeur maximale dans la collection.   | `var result = collection.Max(selector);`     |
    | **Min**     | Retourne la valeur minimale dans la collection.   | `var result = collection.Min(selector);`     |
    | **Sum**     | Calcule la somme des éléments de la collection.   | `var result = collection.Sum(selector);`     |

-   **Exemple:**

    ```csharp
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            // Création d'une collection de nombres entiers
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Average: Calculer la moyenne des nombres
            var average = numbers.Average();
            Console.WriteLine("Average: " + average);

            // Count: Compter le nombre total d'éléments
            var count = numbers.Count();
            Console.WriteLine("Count: " + count);

            // Count avec condition: Compter le nombre d'éléments supérieurs à 5
            var countGreaterThanFive = numbers.Count(n => n > 5);
            Console.WriteLine("Count > 5: " + countGreaterThanFive);

            // Max: Trouver la valeur maximale
            var max = numbers.Max();
            Console.WriteLine("Max: " + max);

            // Min: Trouver la valeur minimale
            var min = numbers.Min();
            Console.WriteLine("Min: " + min);

            // Sum: Calculer la somme des nombres
            var sum = numbers.Sum();
            Console.WriteLine("Sum: " + sum);
        }
    }
    ```
