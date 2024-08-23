# cour : **Console**

## 1. **Introduction:**

-   **Description:**

    > En C#, la classe `Console` est utilisée pour interagir avec la console, c'est-à-dire la fenêtre où le programme s'exécute en mode texte. Elle permet d'afficher des informations à l'utilisateur, de lire des entrées, et de manipuler la sortie de texte, entre autres.

Voici un aperçu des fonctionnalités principales de la classe `Console` en C#.

## 2. **Affichage de texte**

-   `Console.WriteLine()`

    Cette méthode affiche un message suivi d'un saut de ligne.

    ```csharp
    Console.WriteLine("Bonjour, monde!");
    ```

-   **`Console.Write()`**

    Cette méthode affiche un message sans ajouter de saut de ligne à la fin.

    ```csharp
    Console.Write("Bonjour");
    Console.Write(" tout le monde!");
    // Sortie: Bonjour tout le monde!
    ```

## 3. Lecture de l'entrée utilisateur

-   `Console.ReadLine()`

    Cette méthode lit une ligne complète de texte entrée par l'utilisateur jusqu'à ce qu'il appuie sur la touche "Entrée".

    ```csharp
    Console.WriteLine("Quel est votre nom ?");
    string nom = Console.ReadLine();
    Console.WriteLine("Bonjour, " + nom + "!");
    ```

-   `Console.Read()`

    Cette méthode lit un seul caractère de l'entrée utilisateur.

    ```csharp
    Console.WriteLine("Appuyez sur une touche pour continuer...");
    int touche = Console.Read();
    Console.WriteLine("Vous avez appuyé sur : " + (char)touche);
    ```

## 4. **Changer les couleurs de la console**

Vous pouvez personnaliser les couleurs de la sortie de la console en utilisant les propriétés `Console.ForegroundColor` et `Console.BackgroundColor`.

```csharp
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Ce texte est vert.");

Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Texte rouge sur fond jaune.");

Console.ResetColor();  // Réinitialiser les couleurs par défaut
```

## 5. **Effacer la console:**

-   `Console.Clear()`

    Cette méthode efface tout le texte affiché dans la console.

    ```csharp
    Console.Clear();
    ```
