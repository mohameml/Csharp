# cour 05 : **Les Boucles en C#**

> Les boucles sont des structures de contrôle qui permettent de répéter l'exécution d'un bloc de code plusieurs fois, en fonction d'une condition donnée. En C#, les boucles les plus couramment utilisées sont `for`, `foreach`, `while`, et `do while`.

## 1. **Boucle `for`:**

-   **Def:**

    > La boucle `for` est utilisée lorsque vous connaissez à l'avance le nombre de répétitions que vous souhaitez effectuer. Elle est souvent utilisée pour parcourir les tableaux ou les collections.

-   **Syntaxe de la boucle `for` :**

    ```csharp
    for (initialisation; condition; incrémentation)
    {
        // Code à exécuter à chaque itération
    }
    ```

    -   **initialisation** : Initialise une variable de boucle. Cette étape n'est exécutée qu'une seule fois.
    -   **condition** : Condition évaluée avant chaque itération. Si elle est vraie, le bloc de code est exécuté.
    -   **incrémentation** : Modifie la variable de boucle après chaque itération.

-   **Exemple :**

    ```csharp
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("i vaut : " + i);
    }
    ```

## 2. **Boucle `foreach`:**

-   **Def:**

    > La boucle `foreach` est utilisée pour itérer sur les éléments d'une collection (comme un tableau, une liste, etc.). Elle est particulièrement utile lorsque vous ne vous souciez pas de l'indice de l'élément actuel.

-   **Syntaxe de la boucle `foreach` :**

    ```csharp
    foreach (type variable in collection)
    {
        // Code à exécuter pour chaque élément de la collection
    }
    ```

    -   **type** : Le type de la variable qui va contenir l'élément actuel de la collection.
    -   **variable** : Le nom de la variable qui représente l'élément actuel.
    -   **collection** : La collection que vous souhaitez parcourir.

-   **Exemple :**

    ```csharp
    string[] fruits = { "Pomme", "Banane", "Orange" };

    foreach (string fruit in fruits)
    {
        Console.WriteLine(fruit);
    }
    ```

## 3. **Boucle `while`:**

-   **Def:**

    > La boucle `while` exécute un bloc de code tant qu'une condition spécifiée est vraie. Elle est utile lorsque le nombre d'itérations n'est pas connu à l'avance.

-   **Syntaxe de la boucle `while` :**

    ```csharp
    while (condition)
    {
        // Code à exécuter tant que la condition est vraie
    }
    ```

    -   **condition** : La condition est évaluée avant chaque itération. Si elle est vraie, le bloc de code est exécuté.

-   **Exemple :**

    ```csharp
    int compteur = 0;

    while (compteur < 5)
    {
        Console.WriteLine("Compteur : " + compteur);
        compteur++;
    }
    ```

## 4. **Boucle `do while`:**

-   **Def:**

    > La boucle `do while` est similaire à la boucle `while`, mais avec une différence clé : le bloc de code est exécuté au moins une fois, car la condition est vérifiée après l'exécution du bloc.

-   **Syntaxe de la boucle `do while` :**

    ```csharp
    do
    {
        // Code à exécuter
    }
    while (condition);
    ```

    -   **condition** : La condition est évaluée après chaque itération. Si elle est vraie, la boucle continue.

-   **Exemple :**

    ```csharp
    int compteur = 0;

    do
    {
        Console.WriteLine("Compteur : " + compteur);
        compteur++;
    }
    while (compteur < 5);
    ```

## 5. **Mots-clés : `break` et `continue`**

### 5.1 **`break`:**

-   **Def:**

    > Le mot-clé `break` est utilisé pour sortir immédiatement d'une boucle, quel que soit l'état de la condition.

-   **Exemple :**

    ```csharp
    for (int i = 0; i < 10; i++)
    {
        if (i == 5)
        {
            break; // Sort de la boucle lorsque i vaut 5
        }
        Console.WriteLine(i);
    }
    ```

### 5.2 **`continue`:**

-   **Def:**

    > Le mot-clé `continue` est utilisé pour sauter l'itération en cours et passer à l'itération suivante de la boucle.

-   **Exemple :**

    ```csharp
    for (int i = 0; i < 10; i++)
    {
        if (i % 2 == 0)
        {
            continue; // Saute l'affichage des nombres pairs
        }
        Console.WriteLine(i);
    }
    ```
