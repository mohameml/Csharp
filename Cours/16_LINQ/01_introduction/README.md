# cour 01 : **Introduction à LINQ:**

-   **Def:**

    > LINQ, ou **Language Integrated Query**, est une fonctionnalité puissante introduite dans le langage C# avec la version 3.0 du .NET Framework. LINQ permet aux développeurs d'effectuer des requêtes sur des collections de données de manière simple et cohérente, que ces données proviennent de bases de données, de fichiers XML, de collections en mémoire, ou d'autres sources. En d'autres termes, LINQ intègre la capacité de requêter des données directement dans le langage C#, rendant les opérations de filtrage, de tri, de regroupement, et de transformation de données beaucoup plus intuitives.

-   **À quoi sert LINQ ?**

    LINQ est conçu pour simplifier et unifier l'accès aux données. Voici quelques-unes de ses principales utilités :

    -   **Simplification du code** : LINQ permet d'écrire du code plus lisible et concis. Par exemple, une requête SQL complexe peut être traduite en une requête LINQ intuitive.
    -   **Intégration dans le langage** : Étant intégré dans le langage C#, LINQ permet de tirer parti de la vérification de type à la compilation, réduisant ainsi les erreurs d'exécution.
    -   **Polyvalence** : LINQ peut être utilisé avec divers types de sources de données, comme les collections en mémoire (Listes, Tableaux), les bases de données (via LINQ to SQL ou Entity Framework), les fichiers XML (via LINQ to XML), et bien d'autres.

-   **Exemple de LINQ**

    Supposons que nous ayons une liste d'objets `Person` avec des propriétés `Name` et `Age`, et que nous voulions trouver toutes les personnes ayant plus de 30 ans et les trier par âge décroissant. Voici comment on pourrait utiliser LINQ pour cela :

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

            // syntaxe 1 :
            var result1 = from person in people
                        where person.Age > 30
                        orderby person.Age descending
                        select person;
            // Syntaxe 2 :
            var result2 = people
                        .Where(person => person.Age > 30)
                        .OrderByDescending(person => person.Age)
                        .Select(person => person);


            foreach (var person in result1)
            {
                Console.WriteLine($"{person.Name}, {person.Age}");
            }
        }
    }
    ```
