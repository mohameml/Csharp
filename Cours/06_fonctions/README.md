# cour 06 : **Les Fonctions en C#**

> Les fonctions (ou méthodes) en C# sont des blocs de code réutilisables qui effectuent une tâche spécifique. Elles permettent de structurer et d'organiser le code de manière plus modulaire, facilitant ainsi sa lecture, sa maintenance et sa réutilisation. En C#, les fonctions peuvent être définies dans des classes ou des structures et peuvent être appelées depuis n'importe quel endroit de votre code, tant qu'elles sont accessibles.

## 1. **Déclaration d'une Fonction:**

-   **Syntaxe:**

    Pour déclarer une fonction en C#, vous utilisez une signature qui inclut un type de retour, un nom, et une liste de paramètres. Voici la syntaxe générale :

    ```csharp
    [modificateurs d'accès] [type de retour] NomDeLaFonction([paramètres])
    {
        // Corps de la fonction
    }
    ```

    -   **[modificateurs d'accès]** : Définissent la visibilité de la fonction (par exemple, `public`, `private`, `protected`).
    -   **[type de retour]** : Le type de valeur que la fonction renvoie (par exemple, `int`, `string`). Si la fonction ne renvoie rien, utilisez `void`.
    -   **NomDeLaFonction** : Le nom de la fonction. Les noms de fonctions doivent être descriptifs et suivre les conventions de nommage en C# (CamelCase).
    -   **[paramètres]** : Liste des paramètres que la fonction accepte, spécifiée sous forme de `type nom`.

-   **Exemple de Fonction Simple:**

    ```csharp
    public int Additionner(int a, int b)
    {
        return a + b;
    }
    ```

    ```csharp
    int resultat = Additionner(5, 3);
    Console.WriteLine(resultat); // Affiche 8
    ```

    Cette fonction `Additionner` prend deux paramètres entiers `a` et `b`, calcule leur somme, et renvoie le résultat.

## 2. **Paramètres Optionnels:**

-   **Def:**

    > C# permet de définir des paramètres optionnels dans les fonctions en utilisant des valeurs par défaut. Les paramètres optionnels doivent apparaître après tous les paramètres requis dans la liste des paramètres.

-   **Exemple de Paramètres Optionnels:**

    ```csharp
    public void Saluer(string nom, string salutation = "Bonjour")
    {
        Console.WriteLine($"{salutation}, {nom}!");
    }
    ```

    Vous pouvez appeler cette fonction de différentes manières :

    ```csharp
    Saluer("Alice");               // Affiche "Bonjour, Alice!"
    Saluer("Bob", "Bonsoir");     // Affiche "Bonsoir, Bob!"
    ```

## 3. **Paramètres Nommons**

-   **Def:**

    En C#, vous pouvez également spécifier les arguments par nom lors de l'appel d'une fonction, ce qui améliore la lisibilité et permet d'ignorer les paramètres non désirés dans certains cas.

-   **Exemple de Paramètres Nommons:**

    ```csharp
    public void Configurer(string nom, int age, bool estActif)
    {
        // Configuration du système
    }
    ```

    Appel avec paramètres nommés :

    ```csharp
    Configurer(nom: "Alice", age: 30, estActif: true);
    ```

## 4. **Fonctions Overloadées:**

-   **Def:**

    > C# permet la surcharge de méthodes, ce qui signifie que vous pouvez définir plusieurs fonctions avec le même nom mais des signatures différentes (paramètres différents).

-   **Exemple de Surcharge de Fonction:**

    ```csharp
    public int Additionner(int a, int b)
    {
        return a + b;
    }

    public double Additionner(double a, double b)
    {
        return a + b;
    }
    ```

    Dans cet exemple, deux versions de la fonction `Additionner` existent : l'une pour les entiers et l'autre pour les doubles.
