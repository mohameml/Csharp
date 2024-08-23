# cour 05 : **polymorphisme**

> Le **polymorphisme** est un concept clé de la programmation orientée objet (POO) en C#. Il permet aux objets de différentes classes de répondre à une même interface de manière spécifique. En d'autres termes, il permet d'utiliser une méthode de manière interchangeable avec différents types d'objets. Il existe principalement deux types de polymorphisme en C# : **polymorphisme par substitution** et **polymorphisme par surcharge**.

## 1. **Polymorphisme par Substitution (ou Polymorphisme d'Inclusion)**

> Le polymorphisme par substitution se base sur l'héritage et permet à une méthode de fonctionner avec des objets d'une classe dérivée tout en étant appelée via une référence de la classe de base. Cela repose sur les concepts de **méthodes virtuelles** et **méthodes d'extension**.

### 1.1. **Méthodes Virtuelles et Override:**

-   Les méthodes virtuelles dans une classe de base peuvent être redéfinies dans une classe dérivée à l'aide du mot-clé `override`.

-   **Exemple**

    ```csharp
    public class Animal
    {
        // Méthode virtuelle
        public virtual void FaireDuBruit()
        {
            Console.WriteLine("L'animal fait du bruit.");
        }
    }

    public class Chien : Animal
    {
        // Redéfinition de la méthode
        public override void FaireDuBruit()
        {
            Console.WriteLine("Le chien aboie.");
        }
    }

    public class Chat : Animal
    {
        // Redéfinition de la méthode
        public override void FaireDuBruit()
        {
            Console.WriteLine("Le chat miaule.");
        }
    }
    ```

    ```csharp
    Animal monAnimal = new Chien();
    monAnimal.FaireDuBruit();  // Affiche : Le chien aboie.

    monAnimal = new Chat();
    monAnimal.FaireDuBruit();  // Affiche : Le chat miaule.
    ```

    -   La méthode `FaireDuBruit` est marquée comme `virtual` dans la classe `Animal`, ce qui permet aux classes dérivées (`Chien` et `Chat`) de la redéfinir avec le mot-clé `override`.
    -   Le type de l'objet (`Chien` ou `Chat`) détermine la méthode `FaireDuBruit` qui sera appelée, même si la référence est de type `Animal`.

### 1.2. **Polymorphisme d'Interface**

-   Le polymorphisme peut également être réalisé par les interfaces. Les classes qui implémentent une interface doivent fournir une implémentation pour les membres de l'interface.

-   **Exemple**

    ```csharp
    public interface IVehicle
    {
        void Start();
    }

    public class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("La voiture démarre.");
        }
    }

    public class Bike : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Le vélo démarre.");
        }
    }
    ```

    ```csharp
    IVehicle vehicle = new Car();
    vehicle.Start();  // Affiche : La voiture démarre.

    vehicle = new Bike();
    vehicle.Start();  // Affiche : Le vélo démarre.
    ```

    -   `IVehicle` est une interface avec une méthode `Start`.
    -   `Car` et `Bike` implémentent cette interface, fournissant leur propre version de `Start`.

## 2. **Polymorphisme par Surcharge (ou Polymorphisme de Compilation)**

-   Le polymorphisme par surcharge se produit lorsqu'il y a plusieurs méthodes avec le même nom dans une même classe mais avec des signatures différentes (différents paramètres).

-   **Exemple**

    ```csharp
    public class Calculatrice
    {
        public int Additionner(int a, int b)
        {
            return a + b;
        }

        public double Additionner(double a, double b)
        {
            return a + b;
        }

        public int Additionner(int a, int b, int c)
        {
            return a + b + c;
        }
    }
    ```

    ```csharp
    Calculatrice calc = new Calculatrice();
    Console.WriteLine(calc.Additionner(5, 10));       // Affiche : 15
    Console.WriteLine(calc.Additionner(5.5, 10.2));   // Affiche : 15.7
    Console.WriteLine(calc.Additionner(1, 2, 3));     // Affiche : 6
    ```

    -   La méthode `Additionner` est surchargée avec différentes signatures : différentes combinaisons de types et de nombres de paramètres.
    -   Le compilateur détermine quelle méthode appeler en fonction des arguments passés.

### RQ :

-   **Polymorphisme par Substitution** : Permet aux méthodes d'une classe de base d'être redéfinies dans les classes dérivées (utilisation de `virtual` et `override`), ou via des interfaces.
-   **Polymorphisme par Surcharge** : Permet d'avoir plusieurs méthodes avec le même nom mais des signatures différentes dans la même classe.
