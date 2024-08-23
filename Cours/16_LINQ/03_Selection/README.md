# cour 03 :

-   **Méthodes:**

| **Méthode**   | **Description**                                                                    | **Syntaxe**                                     |
| ------------- | ---------------------------------------------------------------------------------- | ----------------------------------------------- |
| **Where**     | Filtre les éléments de la collection en fonction d'une condition.                  | `var result = collection.Where(condition);`     |
| **Distinct**  | Retourne les éléments distincts de la collection, en supprimant les doublons.      | `var result = collection.Distinct();`           |
| **Take**      | Retourne les premiers `n` éléments de la collection.                               | `var result = collection.Take(n);`              |
| **TakeLast**  | Retourne les derniers `n` éléments de la collection.                               | `var result = collection.TakeLast(n);`          |
| **TakeWhile** | Retourne les éléments tant qu'une condition est vraie, en commençant par le début. | `var result = collection.TakeWhile(condition);` |
| **Skip**      | Ignore les premiers `n` éléments de la collection et retourne le reste.            | `var result = collection.Skip(n);`              |
| **SkipLast**  | Ignore les derniers `n` éléments de la collection et retourne le reste.            | `var result = collection.SkipLast(n);`          |
| **SkipWhile** | Ignore les éléments tant qu'une condition est vraie, puis retourne le reste.       | `var result = collection.SkipWhile(condition);` |

-   **Exemple**

    ```csharp
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            // Création d'une collection de nombres entiers
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 2, 3, 4, 7, 8, 9, 10 };

            // Where: Sélectionner les nombres pairs
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("Even Numbers (Where): " + string.Join(", ", evenNumbers));

            // Distinct: Sélectionner les nombres distincts (supprimer les doublons)
            var distinctNumbers = numbers.Distinct();
            Console.WriteLine("Distinct Numbers: " + string.Join(", ", distinctNumbers));

            // Take: Prendre les 3 premiers éléments
            var firstThreeNumbers = numbers.Take(3);
            Console.WriteLine("First 3 Numbers (Take): " + string.Join(", ", firstThreeNumbers));

            // TakeLast: Prendre les 3 derniers éléments
            var lastThreeNumbers = numbers.TakeLast(3);
            Console.WriteLine("Last 3 Numbers (TakeLast): " + string.Join(", ", lastThreeNumbers));

            // TakeWhile: Prendre les éléments tant qu'ils sont inférieurs à 5
            var numbersLessThanFive = numbers.TakeWhile(n => n < 5);
            Console.WriteLine("Numbers < 5 (TakeWhile): " + string.Join(", ", numbersLessThanFive));

            // Skip: Ignorer les 4 premiers éléments
            var skipFirstFourNumbers = numbers.Skip(4);
            Console.WriteLine("Skip First 4 Numbers (Skip): " + string.Join(", ", skipFirstFourNumbers));

            // SkipLast: Ignorer les 4 derniers éléments
            var skipLastFourNumbers = numbers.SkipLast(4);
            Console.WriteLine("Skip Last 4 Numbers (SkipLast): " + string.Join(", ", skipLastFourNumbers));

            // SkipWhile: Ignorer les éléments tant qu'ils sont inférieurs à 5
            var skipWhileLessThanFive = numbers.SkipWhile(n => n < 5);
            Console.WriteLine("Skip While Numbers < 5 (SkipWhile): " + string.Join(", ", skipWhileLessThanFive));
        }
    }
    ```
