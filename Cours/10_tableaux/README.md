# cour 10 : Les **tableaux**

## 1. **Introduction:**

-   **Description:**

    > Les **tableaux** en C# sont des structures de données qui permettent de stocker des éléments du même type dans une séquence indexée. Ils sont utilisés pour gérer des collections de données et sont une partie fondamentale du langage C#.

-   **Déclaration d'un Tableau:**

    Pour déclarer un tableau, vous spécifiez le type des éléments suivis de crochets `[]`.

    ```csharp
    int[] tableauEntiers;  // Déclaration d'un tableau d'entiers
    string[] tableauChaines;  // Déclaration d'un tableau de chaînes
    ```

-   **Initialisation d'un Tableau:**

    Vous pouvez initialiser un tableau de différentes manières, soit en spécifiant la taille, soit en utilisant une initialisation directe.

    ```csharp
    // Création d'un tableau de 5 entiers
    int[] tableauEntiers = new int[5];
    ```

    ```csharp
    // Création et initialisation d'un tableau avec des valeurs
    int[] tableauEntiers = new int[] { 1, 2, 3, 4, 5 };
    ```

    Vous pouvez également omettre le mot-clé `new int[]` lors de l'initialisation directe :

    ```csharp
    int[] tableauEntiers = { 1, 2, 3, 4, 5 };
    ```

-   **Accès aux Éléments du Tableau**

    Les éléments d'un tableau sont indexés à partir de zéro. Vous accédez aux éléments en utilisant des indices.

    ```csharp
    int[] tableauEntiers = { 10, 20, 30, 40, 50 };
    int premierElement = tableauEntiers[0];  // Accède au premier élément (10)
    tableauEntiers[1] = 25;  // Modifie le deuxième élément à 25
    ```

## 2. **Propriétés des Tableaux**

-   Les tableaux en C# ont quelques propriétés importantes :

    -   **`Length`** : Retourne le nombre d'éléments dans le tableau.
    -   **`Rank`** : Retourne le nombre de dimensions du tableau (1 pour les tableaux à une dimension).

-   **Exemple:**

    ```csharp
    int[] tableauEntiers = { 1, 2, 3, 4, 5 };
    int longueur = tableauEntiers.Length;  // 5
    ```

## 3. **Tableaux Multidimensionnels**

-   **Def:**

    Les tableaux multidimensionnels permettent de créer des tableaux avec plus d'une dimension, comme les matrices.

-   **Déclaration et Initialisation**

    ```csharp
    // Déclaration et initialisation d'un tableau 2D
    int[,] tableau2D = new int[3, 4];
    ```

    Vous pouvez également initialiser un tableau 2D avec des valeurs directement :

    ```csharp
    int[,] tableau2D = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
    ```

-   **Accès aux Éléments**

    Pour accéder aux éléments d'un tableau multidimensionnel, vous utilisez plusieurs indices.

    ```csharp
    int[,] tableau2D = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
    int valeur = tableau2D[1, 2];  // Accède à l'élément à la position (1,2), donc 7
    ```

## 4. **Boucles avec des Tableaux:**

-   Les boucles `for` et `foreach` sont couramment utilisées pour itérer sur les éléments des tableaux.

-   **Exemple avec `for`:**

    ```csharp
    int[] tableauEntiers = { 1, 2, 3, 4, 5 };
    for (int i = 0; i < tableauEntiers.Length; i++)
    {
        Console.WriteLine(tableauEntiers[i]);
    }
    ```

-   **Exemple avec `foreach`**

    ```csharp
    foreach (int nombre in tableauEntiers)
    {
        Console.WriteLine(nombre);
    }
    ```
