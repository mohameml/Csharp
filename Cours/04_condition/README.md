# cour 04 : **Les Conditions en C#**

> Les conditions en C# permettent de contrôler le flux d'exécution d'un programme en fonction de certaines conditions ou expressions. Les structures conditionnelles les plus couramment utilisées en C# sont `if`, `else if`, `else`, ainsi que `switch`. Ces structures permettent de faire des choix parmi différents blocs de code en fonction des valeurs de variables ou des résultats d'expressions logiques.

## 1. **Structure de Base : `if`, `else if`, `else`**

-   **`if`:**

    La structure de base `if` permet d'exécuter un bloc de code si une condition spécifiée est vraie.

    ```csharp
    int nombre = 10;

    if (nombre > 5)
    {
        Console.WriteLine("Le nombre est supérieur à 5");
    }
    ```

    Dans cet exemple, la condition `nombre > 5` est vraie, donc le message "Le nombre est supérieur à 5" sera affiché.

-   **`else if`:**

    L'instruction `else if` permet de tester plusieurs conditions successives. Si la condition `if` est fausse, une autre condition peut être vérifiée avec `else if`.

    ```csharp
    int nombre = 10;

    if (nombre > 10)
    {
        Console.WriteLine("Le nombre est supérieur à 10");
    }
    else if (nombre == 10)
    {
        Console.WriteLine("Le nombre est égal à 10");
    }
    ```

    Ici, la condition `nombre > 10` est fausse, mais `nombre == 10` est vraie, donc "Le nombre est égal à 10" sera affiché.

-   **`else`:**

    L'instruction `else` permet de définir un bloc de code qui sera exécuté si aucune des conditions précédentes n'est vraie.

    ```csharp
    int nombre = 3;

    if (nombre > 10)
    {
        Console.WriteLine("Le nombre est supérieur à 10");
    }
    else if (nombre == 10)
    {
        Console.WriteLine("Le nombre est égal à 10");
    }
    else
    {
        Console.WriteLine("Le nombre est inférieur à 10");
    }
    ```

    Dans cet exemple, les deux premières conditions sont fausses, donc le bloc `else` est exécuté, affichant "Le nombre est inférieur à 10".

## 2. **Les Opérateurs Logiques**

-   Les conditions en C# peuvent être combinées à l'aide d'opérateurs logiques pour créer des conditions plus complexes.

    -   **&& (ET logique)** : Vrai si les deux conditions sont vraies.
    -   **|| (OU logique)** : Vrai si au moins une des conditions est vraie.
    -   **! (NON logique)** : Inverse la valeur de la condition (vrai devient faux, et vice versa).

-   **Exemple avec opérateurs logiques :**

    ```csharp
    int age = 25;
    bool estMembre = true;

    if (age >= 18 && estMembre)
    {
        Console.WriteLine("Accès autorisé");
    }
    else
    {
        Console.WriteLine("Accès refusé");
    }
    ```

    Dans cet exemple, les deux conditions `age >= 18` et `estMembre` sont vraies, donc "Accès autorisé" sera affiché.

## 3. **Structure `switch`**

-   **Def:**

    > La structure `switch` est une alternative aux multiples `if-else if` lorsque vous devez comparer une variable avec différentes valeurs possibles. Elle rend le code plus lisible et est souvent plus efficace.

-   **Exemple de `switch` :**

    ```csharp
    int jour = 3;

    switch (jour)
    {
        case 1:
            Console.WriteLine("Lundi");
            break;
        case 2:
            Console.WriteLine("Mardi");
            break;
        case 3:
            Console.WriteLine("Mercredi");
            break;
        case 4:
            Console.WriteLine("Jeudi");
            break;
        case 5:
            Console.WriteLine("Vendredi");
            break;
        default:
            Console.WriteLine("Week-end");
            break;
    }
    ```

## 4. **Structure `switch` avec expressions (C# 8.0 et versions ultérieures):**

-   **Def:**

    > Depuis C# 8.0, il est possible d'utiliser une expression `switch` qui permet de simplifier la syntaxe, notamment pour les affectations.

-   **Exemple avec expression `switch` :**

    ```csharp
    int jour = 3;
    string nomJour = jour switch
    {
        1 => "Lundi",
        2 => "Mardi",
        3 => "Mercredi",
        4 => "Jeudi",
        5 => "Vendredi",
        _ => "Week-end"
    };

    Console.WriteLine(nomJour);
    ```

    Ce code affiche "Mercredi", et l'expression `switch` est utilisée pour affecter directement une valeur à la variable `nomJour`.

## 5. **L'Opération Ternaire en C#:**

-   **Def:**

    > L'opération ternaire, également connue sous le nom d'expression conditionnelle ou opérateur ternaire, est une syntaxe concise pour écrire des conditions simples. En C#, l'opérateur ternaire utilise le symbole `? :` et permet de choisir entre deux valeurs en fonction d'une condition.

-   **La syntaxe générale de l'opérateur ternaire est la suivante :**

    ```csharp
    condition ? valeur_si_vrai : valeur_si_faux;
    ```

    -   **condition** : Une expression booléenne (qui renvoie `true` ou `false`).
    -   **valeur_si_vrai** : La valeur retournée si la condition est vraie.
    -   **valeur_si_faux** : La valeur retournée si la condition est fausse.

-   **Exemple:**

    ```csharp
    int nombre = 10;
    string resultat = (nombre % 2 == 0) ? "Pair" : "Impair";
    Console.WriteLine(resultat); // Affiche "Pair"
    ```
