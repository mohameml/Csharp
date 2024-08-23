# cour 03 : **Héritage en C#**

## 1. **Définition de l'Héritage:**

-   **Def:**

    -   L'**héritage** est un concept fondamental de la programmation orientée objet (POO) en C#. Il permet de créer une nouvelle classe basée sur une classe existante. La nouvelle classe, appelée **classe dérivée** ou **classe enfant**, hérite des champs, des propriétés, des méthodes et des événements de la classe existante, appelée **classe de base** ou **classe parent**. Cela permet de réutiliser le code et de créer des hiérarchies de classes.

    -   L'héritage permet de modéliser une relation "est-un" entre les classes. Par exemple, si une classe `Voiture` hérite d'une classe `Véhicule`, cela signifie qu'une voiture est un type de véhicule.

-   **Syntaxe de l'Héritage en C#:**

    -   En C#, une classe dérivée est définie en utilisant le symbole `:` suivi du nom de la classe de base.

    ```csharp
    public class ClassParent {

    }

    public class ClassEnfant : ClassParent {

    }
    ```

-   **Exemple:**

    ```csharp
    public class Vehicule
    {
        public int Vitesse { get; set; }

        public void Demarrer()
        {
            Console.WriteLine("Le véhicule démarre.");
        }
    }

    public class Voiture : Vehicule
    {
        public string Marque { get; set; }

        public void Klaxonner()
        {
            Console.WriteLine("La voiture klaxonne.");
        }
    }
    ```

    ```csharp
    Voiture maVoiture = new Voiture();
    maVoiture.Vitesse = 100;  // Hérité de la classe Vehicule
    maVoiture.Marque = "Toyota";
    maVoiture.Demarrer();     // Hérité de la classe Vehicule
    maVoiture.Klaxonner();    // Méthode spécifique à la classe Voiture
    ```

## 2. **Types d'Héritage:**

C# prend en charge plusieurs types d'héritage :

1. **Héritage Simple** :

    - Une classe dérivée hérite d'une seule classe de base.
    - C'est le seul type d'héritage direct supporté en C#.

    ```csharp
    public class Animal
    {
        public void Manger() => Console.WriteLine("L'animal mange.");
    }

    public class Chien : Animal
    {
        public void Aboyer() => Console.WriteLine("Le chien aboie.");
    }
    ```

2. **Héritage Multiniveau** :

    - Une classe dérivée peut servir de classe de base pour une autre classe, créant ainsi une chaîne d'héritage.

    ```csharp
    public class Animal
    {
        public void Manger() => Console.WriteLine("L'animal mange.");
    }

    public class Mammifere : Animal
    {
        public void Respirer() => Console.WriteLine("Le mammifère respire.");
    }

    public class Chien : Mammifere
    {
        public void Aboyer() => Console.WriteLine("Le chien aboie.");
    }
    ```

    **Utilisation** :

    ```csharp
    Chien monChien = new Chien();
    monChien.Manger();     // Hérité de Animal
    monChien.Respirer();   // Hérité de Mammifere
    monChien.Aboyer();     // Méthode de Chien
    ```

3. **Héritage Multiple (Indirect via Interfaces)** :

    - En C#, une classe ne peut pas hériter de plusieurs classes de base directement, mais elle peut implémenter plusieurs interfaces, ce qui permet une forme d'héritage multiple.

    ```csharp
    public interface IVolant
    {
        void Voler();
    }

    public interface INageant
    {
        void Nager();
    }

    public class Canard : IVolant, INageant
    {
        public void Voler() => Console.WriteLine("Le canard vole.");
        public void Nager() => Console.WriteLine("Le canard nage.");
    }
    ```

#### 3. **Surcharge et Redéfinition de Méthodes:**

Dans le cadre de l'héritage, il est possible de **redéfinir** ou **surcharger** les méthodes de la classe de base dans la classe dérivée :

-   **Méthodes `virtual` et `override`** :

    -   Une méthode marquée comme `virtual` dans la classe de base peut être redéfinie dans une classe dérivée en utilisant le mot-clé `override`.

    ```csharp
    public class Vehicule
    {
        public virtual void Demarrer()
        {
            Console.WriteLine("Le véhicule démarre.");
        }
    }

    public class Voiture : Vehicule
    {
        public override void Demarrer()
        {
            Console.WriteLine("La voiture démarre.");
        }
    }
    ```

-   **Méthodes `sealed`** :

    -   Une méthode `override` peut être marquée comme `sealed` dans une classe dérivée pour empêcher les classes dérivées supplémentaires de la redéfinir à nouveau.

    ```csharp
    public class VoitureSport : Voiture
    {
        public sealed override void Demarrer()
        {
            Console.WriteLine("La voiture de sport démarre avec puissance.");
        }
    }
    ```

## 4. **Mots-Clés Utilisés dans l'Héritage**

-   **`base`** : Permet d'accéder aux membres de la classe de base depuis une classe dérivée.

    ```csharp
    public class Voiture : Vehicule
    {
        public override void Demarrer()
        {
            base.Demarrer();  // Appelle Demarrer() de la classe Vehicule
            Console.WriteLine("La voiture démarre.");
        }
    }
    ```

-   **`new`** : Permet de masquer une méthode héritée plutôt que de la redéfinir.

    ```csharp
    public class Voiture : Vehicule
    {
        public new void Demarrer()
        {
            Console.WriteLine("La voiture démarre d'une manière différente.");
        }
    }
    ```
