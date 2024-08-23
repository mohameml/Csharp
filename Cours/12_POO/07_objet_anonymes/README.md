# cour :

### Les Objets Anonymes en C#

**Définition et Présentation**

En C#, les objets anonymes permettent de créer des instances de types sans avoir à définir explicitement une classe. Ils sont utiles lorsque vous avez besoin de regrouper temporairement des propriétés et des valeurs dans un objet, souvent pour simplifier le code ou manipuler des données à la volée, sans nécessiter de structure plus complexe.

Les objets anonymes sont typiquement utilisés dans le cadre de LINQ, où ils permettent de créer des résultats de requêtes contenant seulement certaines propriétés des objets d'origine, ou même de combiner des propriétés provenant de différentes sources.

**Syntaxe et Création**

Pour créer un objet anonyme en C#, on utilise la syntaxe suivante :

```csharp
var monObjet = new { Propriete1 = valeur1, Propriete2 = valeur2 };
```

Les propriétés de l'objet anonyme sont définies au moment de la création de l'objet, et les types de ces propriétés sont inférés par le compilateur en fonction des valeurs fournies.

**Exemple d'Utilisation**

Supposons que vous avez une liste de personnes et que vous voulez sélectionner uniquement leur nom et leur âge pour créer un nouvel objet :

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

        var result = people
            .Where(person => person.Age > 30)
            .Select(person => new { person.Name, person.Age });

        foreach (var item in result)
        {
            Console.WriteLine($"Name: {item.Name}, Age: {item.Age}");
        }
    }
}
```

**Explication du Code :**

1. **Création d'objets anonymes** : La requête LINQ utilise la méthode `Select` pour créer de nouveaux objets anonymes avec seulement les propriétés `Name` et `Age` de chaque personne.
2. **Utilisation** : L'objet anonyme créé est de type implicite (`var`), et ses propriétés peuvent être accédées directement comme on le ferait avec un objet normal.

**Limitations et Caractéristiques**

-   **Immutabilité** : Les objets anonymes sont immuables. Une fois créés, vous ne pouvez pas modifier leurs propriétés.
-   **Type implicite** : Les objets anonymes doivent être déclarés avec le mot-clé `var` car leur type est défini par le compilateur à la volée.
-   **Portée limitée** : Les objets anonymes sont généralement utilisés dans un contexte local, comme dans des méthodes ou des requêtes LINQ. Ils ne sont pas adaptés pour être retournés par des méthodes ou utilisés à travers les frontières d'assemblées.

Les objets anonymes sont donc un outil puissant en C# pour créer des structures de données temporaires, simplifier le code, et faciliter l'utilisation de LINQ.
