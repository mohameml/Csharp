# cour : **Abstraction en C#**

## 1. **Définition de l'Abstraction:**

-   L'**abstraction** est l'un des concepts clés de la programmation orientée objet (POO). Elle consiste à masquer les détails complexes de l'implémentation d'un objet et à exposer uniquement une interface simplifiée, c'est-à-dire les aspects nécessaires et pertinents pour l'utilisateur final. En d'autres termes, l'abstraction permet de se concentrer sur _ce que fait_ un objet plutôt que _comment il le fait_.

-   L'abstraction en C# est réalisée principalement par l'utilisation de **classes abstraites** et **interfaces**. Elles définissent des méthodes ou propriétés sans fournir leur implémentation, laissant aux classes dérivées ou implémentations concrètes le soin de fournir le détail.

## 2. **Classes Abstraites:**

-   Une **classe abstraite** est une classe qui ne peut pas être instanciée directement. Elle peut contenir des méthodes abstraites (sans implémentation) ainsi que des méthodes avec une implémentation par défaut. Les classes abstraites sont conçues pour être héritées par d'autres classes qui doivent implémenter les méthodes abstraites.

-   **Déclaration d'une classe abstraite** : Le mot-clé `abstract` est utilisé pour déclarer une classe abstraite ainsi que ses méthodes.

-   **Exemple de Classe Abstraite**

    ```csharp
    // Classe abstraite
    public abstract class Forme
    {
        // Propriété abstraite
        public abstract double Aire { get; }

        // Méthode abstraite
        public abstract double CalculerAire();

        // Méthode concrète (non abstraite)
        public void AfficherAire()
        {
            Console.WriteLine($"L'aire est : {CalculerAire()}");
        }
    }

    // Classe dérivée de Forme
    public class Cercle : Forme
    {
        public double Rayon { get; set; }

        // Implémentation de la propriété abstraite
        public override double Aire
        {
            get { return Math.PI * Rayon * Rayon; }
        }

        // Implémentation de la méthode abstraite
        public override double CalculerAire()
        {
            return Aire;
        }
    }
    ```

    ```csharp
    Cercle cercle = new Cercle { Rayon = 5 };
    cercle.AfficherAire();  // Affiche : L'aire est : 78.5398163397448
    ```

## 3. **Interfaces:**

-   Une **interface** est un contrat qui définit un ensemble de méthodes, propriétés, événements ou indexeurs qu'une classe ou une structure doit implémenter. Contrairement aux classes abstraites, les interfaces ne contiennent aucune implémentation ; elles ne définissent que les signatures des membres.

-   **Déclaration d'une interface** : Le mot-clé `interface` est utilisé pour déclarer une interface. Les classes ou structures qui implémentent cette interface doivent fournir une implémentation pour tous ses membres.

-   **Exemple d'Interface:**

    ```csharp
    // Interface
    public interface IForme
    {
        double CalculerAire();
        double CalculerPerimetre();
    }

    // Implémentation de l'interface
    public class Rectangle : IForme
    {
        public double Largeur { get; set; }
        public double Hauteur { get; set; }

        public double CalculerAire()
        {
            return Largeur * Hauteur;
        }

        public double CalculerPerimetre()
        {
            return 2 * (Largeur + Hauteur);
        }
    }
    ```

    ```csharp
    IForme rectangle = new Rectangle { Largeur = 4, Hauteur = 5 };
    Console.WriteLine($"Aire : {rectangle.CalculerAire()}");  // Affiche : Aire : 20
    Console.WriteLine($"Périmètre : {rectangle.CalculerPerimetre()}");  // Affiche : Périmètre : 18
    ```

## 4. **Propriétés Abstraites en C#:**

-   **Description:**

    > Les **propriétés abstraites** en C# sont un mécanisme pour définir des propriétés dans une classe abstraite sans fournir d'implémentation concrète. Elles servent à établir un contrat que les classes dérivées doivent suivre en fournissant une implémentation spécifique pour ces propriétés.

-   **Syntaxe de Déclaration:**

    ```csharp
    public abstract class MaClasseAbstraite
    {
        // Propriété abstraite
        public abstract string MaPropriete { get; set; }
    }
    ```

    -   La propriété `MaPropriete` est marquée comme `abstract` et n'a pas de corps. Cela signifie qu'elle n'a pas d'implémentation dans la classe abstraite `MaClasseAbstraite`.
    -   Toute classe qui hérite de `MaClasseAbstraite` devra fournir une implémentation concrète pour cette propriété (ie : get , set).

-   **Implémentation des Propriétés Abstraites**

    Les classes dérivées doivent fournir une implémentation pour les propriétés abstraites définies dans la classe de base.

    ```csharp
    public class ClasseConcrete : MaClasseAbstraite
    {
        private string _nom;

        // Implémentation concrète de la propriété abstraite
        public override string MaPropriete
        {
            get { return _nom; }
            set { _nom = value; }
        }
    }
    ```

    -   La classe `ClasseConcrete` fournit une implémentation pour la propriété `MaPropriete` avec des accesseurs `get` et `set`.
    -   La classe dérivée doit utiliser le mot-clé `override` pour redéfinir la propriété abstraite.

-   **Exemple Complet:**

    Voici un exemple complet qui montre comment utiliser des propriétés abstraites dans une classe abstraite et ses classes dérivées.

    ```csharp
    // Classe abstraite avec propriété abstraite
    public abstract class Animal
    {
        // Propriété abstraite
        public abstract string Nom { get; set; }

        // Méthode abstraite
        public abstract void FaireDuBruit();
    }

    // Classe dérivée de Animal
    public class Chien : Animal
    {
        private string _nom;

        // Implémentation de la propriété abstraite
        public override string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        // Implémentation de la méthode abstraite
        public override void FaireDuBruit()
        {
            Console.WriteLine("Le chien aboie.");
        }
    }

    // Classe dérivée de Animal
    public class Chat : Animal
    {
        private string _nom;

        // Implémentation de la propriété abstraite
        public override string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        // Implémentation de la méthode abstraite
        public override void FaireDuBruit()
        {
            Console.WriteLine("Le chat miaule.");
        }
    }
    ```

    ```csharp
    Chien monChien = new Chien { Nom = "Rex" };
    Console.WriteLine($"Nom du chien : {monChien.Nom}"); // Affiche : Nom du chien : Rex
    monChien.FaireDuBruit(); // Affiche : Le chien aboie.

    Chat monChat = new Chat { Nom = "Whiskers" };
    Console.WriteLine($"Nom du chat : {monChat.Nom}"); // Affiche : Nom du chat : Whiskers
    monChat.FaireDuBruit(); // Affiche : Le chat miaule.
    ```

### RQ Différences entre Classes Abstraites et Interfaces

| **Caractéristique**        | **Classe Abstraite**                                    | **Interface**                                                                      |
| -------------------------- | ------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| **Implémentation**         | Peut contenir des méthodes avec ou sans implémentation  | Ne peut contenir que des signatures, pas d'implémentation                          |
| **Héritage multiple**      | Une classe peut hériter d'une seule classe abstraite    | Une classe peut implémenter plusieurs interfaces                                   |
| **Membres statiques**      | Peut contenir des membres statiques                     | Ne peut pas contenir de membres statiques                                          |
| **Constructeurs**          | Peut avoir des constructeurs                            | Ne peut pas avoir de constructeurs                                                 |
| **Utilisation principale** | Utilisée pour partager du code entre classes similaires | Utilisée pour définir des comportements communs entre classes sans lien de parenté |
