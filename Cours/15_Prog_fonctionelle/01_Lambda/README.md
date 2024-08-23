# cour : **expression lambda**

-   **Description:**

    > En C#, une **expression lambda** est une syntaxe concise pour définir des fonctions anonymes (c'est-à-dire des fonctions sans nom). Les expressions lambda sont couramment utilisées en combinaison avec des délégués, des méthodes LINQ, et d'autres situations où une fonction rapide et simple est nécessaire.

-   **Syntaxe de base:**

    La syntaxe générale d'une expression lambda est :

    ```csharp
    (paramètres) => expression;
    ```

    -   **Paramètres** : Les paramètres de la fonction. Si la fonction n'a pas de paramètres, vous pouvez utiliser `()`.
    -   **Expression** : Le corps de la fonction. Si le corps de la fonction est composé d'une seule expression, vous n'avez pas besoin de `return` ni de parenthèses, Si le corps de la fonction est composé de plusieurs instructions, utilisez des accolades `{}`.

-   **Exemple 1 :**

    ```csharp
    Func<int, int> carre = x => x * x;

    int resultat = carre(5);  // Résultat: 25
    ```

    ```csharp
    Func<int, int, int> addition = (a, b) => a + b;

    int somme = addition(3, 4);  // Résultat: 7
    ```

-   **Exemple 2:**

    ```csharp
    Func<int, int, int> multiplierEtAfficher = (a, b) =>
    {
        int produit = a * b;
        Console.WriteLine($"Le produit de {a} et {b} est {produit}");
        return produit;
    };

    int resultat = multiplierEtAfficher(3, 4);  // Résultat: 12, et affiche "Le produit de 3 et 4 est 12"
    ```
