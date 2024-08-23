# cour 02 : **Encapsulation en C#**

## 1. **Définition de l'Encapsulation:**

-   L'**encapsulation** est l'un des principes fondamentaux de la programmation orientée objet (POO). Elle consiste à regrouper les données (attributs) et le code qui manipule ces données (méthodes) au sein d'une même entité appelée **classe**.

-   L'encapsulation contrôle également la visibilité de ces données et méthodes depuis l'extérieur de la classe, c'est-à-dire comment elles peuvent être accessibles ou modifiées.

-   L'objectif principal de l'encapsulation est de protéger l'intégrité des données de l'objet en restreignant l'accès direct aux attributs internes. En pratique, cela signifie que les attributs d'une classe sont souvent rendus privés (`private`), et l'accès à ces attributs est contrôlé via des méthodes publiques ou des propriétés avec des accesseurs (`get` et `set`).

## 2. **Niveaux d'Accessibilité en C#:**

En C#, l'accessibilité des membres d'une classe (attributs et méthodes) est contrôlée à l'aide de **modificateurs d'accès**. Voici les principaux niveaux d'accessibilité :

1. **`private`** :

    - Le niveau d'accès le plus restrictif.
    - Les membres `private` ne sont accessibles qu'à l'intérieur de la classe qui les déclare.
    - C'est le modificateur par défaut pour les attributs si aucun modificateur d'accès n'est spécifié.

    ```csharp
    public class Personne
    {
        private string nom;  // Accessible uniquement à l'intérieur de la classe Personne
    }
    ```

2. **`protected`** :

    - Les membres `protected` sont accessibles au sein de la classe qui les déclare, ainsi que dans les classes dérivées (héritées).
    - Cela permet de partager des données entre une classe de base et ses sous-classes tout en les cachant du reste du programme.

    ```csharp
    public class Personne
    {
        protected string nom;  // Accessible dans Personne et ses classes dérivées
    }
    ```

3. **`internal`** :

    - Les membres `internal` sont accessibles dans l'ensemble de l'assembly (le projet) où ils sont déclarés.
    - Cela signifie que tout code dans le même projet peut accéder à ces membres, mais ils sont cachés pour les autres projets.

    ```csharp
    internal class Personne
    {
        internal string nom;  // Accessible partout dans le même assembly
    }
    ```

4. **`protected internal`** :

    - Ce modificateur combine `protected` et `internal`.
    - Les membres `protected internal` sont accessibles dans l'assembly actuel ainsi que dans les classes dérivées, même si ces classes dérivées sont dans un autre assembly.

    ```csharp
    public class Personne
    {
        protected internal string nom;  // Accessible dans le même assembly et dans les classes dérivées
    }
    ```

5. **`public`** :

    - Le niveau d'accès le moins restrictif.
    - Les membres `public` sont accessibles de n'importe où dans le programme, y compris à partir d'autres classes ou projets.

    ```csharp
    public class Personne
    {
        public string nom;  // Accessible de partout
    }
    ```
