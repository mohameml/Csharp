# cour : les **types génériques**

> En C#, les **types génériques** permettent de définir des classes, des interfaces, des méthodes, et des délégués avec des types qui sont spécifiés ultérieurement lors de l'utilisation. Les génériques offrent une manière de créer des structures de données et des algorithmes qui sont à la fois réutilisables et sûrs, tout en conservant une forte performance et une flexibilité.

## 1. **Concepts de Base des Génériques:**

### 1.1. **Classes Génériques**

-   **Description:**

    > Une **classe générique** est une classe définie avec un ou plusieurs paramètres de type.

-   **Syntaxe:**

    ```csharp
    public class ClasseGenerique<T>
    {
        private T Attr;

        public void Methode1(T item)
        {
            Attr = item;
        }

        public T Retirer()
        {
            return Attr;
        }
    }
    ```

-   **Exemple:**

    ```csharp
    public class Boite<T>
    {
        private T contenu;

        public void Ajouter(T item)
        {
            contenu = item;
        }

        public T Retirer()
        {
            return contenu;
        }
    }
    ```

    -   `T` est un paramètre de type. Il peut être remplacé par n'importe quel type lors de l'instanciation de la classe.
    -   La méthode `Ajouter` et la méthode `Retirer` utilisent le type générique `T`.

    ```csharp
    Boite<int> boiteEntiers = new Boite<int>();
    boiteEntiers.Ajouter(123);
    int contenuEntier = boiteEntiers.Retirer();  // Retourne 123

    Boite<string> boiteChaines = new Boite<string>();
    boiteChaines.Ajouter("Bonjour");
    string contenuChaine = boiteChaines.Retirer();  // Retourne "Bonjour"
    ```

### 1.2. **Méthodes Génériques:**

-   Les **méthodes génériques** permettent de définir des méthodes qui acceptent des paramètres de type spécifiés au moment de l'appel de la méthode.

-   **Exemple:**

    ```csharp
    public class Utilitaires
    {
        public void Afficher<T>(T valeur)
        {
            Console.WriteLine(valeur);
        }
    }
    ```

    -   `Afficher` est une méthode générique qui peut accepter un paramètre de n'importe quel type.

    ```csharp
    Utilitaires utilitaires = new Utilitaires();
    utilitaires.Afficher(42);          // Affiche 42
    utilitaires.Afficher("Hello");     // Affiche Hello
    utilitaires.Afficher(3.14);        // Affiche 3.14
    ```

### 1.3. **Interfaces Génériques:**

-   Les **interfaces génériques** définissent des contrats que les classes peuvent implémenter avec des types spécifiques.

-   **Exemple:**

    ```csharp
    public interface IComparer<T>
    {
        int Comparer(T x, T y);
    }
    ```

    ```csharp
    public class ComparateurEntier : IComparer<int>
    {
        public int Comparer(int x, int y)
        {
            return x.CompareTo(y);
        }
    }
    ```

## 2. **Contraintes de Types:**

-   **Def:**

    > Les contraintes de types permettent de restreindre les types qui peuvent être utilisés comme paramètres de type pour les classes, les méthodes et les interfaces génériques.

-   **Contraintes de Base:**

    -   **`where T : class`** : Le type `T` doit être une référence.
    -   **`where T : struct`** : Le type `T` doit être une valeur (c'est-à-dire une struct).
    -   **`where T : new()`** : Le type `T` doit avoir un constructeur public sans paramètre.
    -   **`where T : BaseClass`** : Le type `T` doit dériver de `BaseClass`.
    -   **`where T : IInterface`** : Le type `T` doit implémenter `IInterface`.

-   **Exemple de Contraintes:**

    ```csharp
    public class Factory<T> where T : new()
    {
        public T CreateInstance()
        {
            return new T();  // Crée une instance de T, mais T doit avoir un constructeur sans paramètres
        }
    }
    ```

    ```csharp
    Factory<MyClass> factory = new Factory<MyClass>();
    MyClass instance = factory.CreateInstance();  // MyClass doit avoir un constructeur sans paramètres
    ```
