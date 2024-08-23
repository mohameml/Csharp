# cour : **string**

## 1. **Introduction:**

-   **Def:**

    > En C#, la classe **`string`** est une classe fondamentale du Framework .NET qui représente une séquence de caractères Unicode. Les chaînes en C# sont immuables, ce qui signifie que chaque modification d'une chaîne crée une nouvelle chaîne plutôt que de modifier la chaîne existante.

-   **Syntaxe:**

    ```csharp
    string name = "val";
    ```

-   **Propriétés de la Classe `string`**

    -   **`Length`** : Retourne le nombre de caractères dans la chaîne.

        ```csharp
        string texte = "Bonjour";
        int longueur = texte.Length;  // 7
        ```

## 2. **Méthodes de la Classe `string`:**

### 2.1. **Méthodes de Manipulation de Chaînes**

-   **`ToUpper()`** : Convertit tous les caractères de la chaîne en majuscules.

    ```csharp
    string texte = "bonjour";
    string upperTexte = texte.ToUpper();  // "BONJOUR"
    ```

-   **`ToLower()`** : Convertit tous les caractères de la chaîne en minuscules.

    ```csharp
    string texte = "BONJOUR";
    string lowerTexte = texte.ToLower();  // "bonjour"
    ```

-   **`Trim()`** : Supprime les espaces blancs au début et à la fin de la chaîne.

    ```csharp
    string texte = "  Bonjour  ";
    string trimTexte = texte.Trim();  // "Bonjour"
    ```

-   **`PadLeft(int totalWidth, char paddingChar)`** : Complète la chaîne jusqu'à une longueur spécifiée avec le caractère de remplissage sur la gauche.

    ```csharp
    string texte = "123";
    string padLeftTexte = texte.PadLeft(5, '0');  // "00123"
    ```

-   **`PadRight(int totalWidth, char paddingChar)`** : Complète la chaîne jusqu'à une longueur spécifiée avec le caractère de remplissage sur la droite.

    ```csharp
    string texte = "123";
    string padRightTexte = texte.PadRight(5, '0');  // "12300"
    ```

-   **`Substring(int startIndex, int length)`** : Retourne une sous-chaîne commençant à un index spécifié avec une longueur spécifiée.

    ```csharp
    string texte = "Bonjour le monde";
    string sousChaine = texte.Substring(8, 3);  // "le "
    ```

-   **`Replace(string oldValue, string newValue)`** : Remplace toutes les occurrences de `oldValue` par `newValue`.

    ```csharp
    string texte = "Bonjour le monde";
    string remplaceTexte = texte.Replace("monde", "tous");  // "Bonjour le tous"
    ```

-   **`Split(char separator)`** : Divise la chaîne en un tableau de sous-chaînes en utilisant le séparateur spécifié.

    ```csharp
    string texte = "Bonjour,le,monde";
    string[] mots = texte.Split(',');  // { "Bonjour", "le", "monde" }
    ```

-   **`Join(string separator, string[] values)`** : Combine un tableau de chaînes en une seule chaîne avec le séparateur spécifié.

    ```csharp
    string[] mots = { "Bonjour", "le", "monde" };
    string texte = string.Join(",", mots);  // "Bonjour,le,monde"
    ```

### 2.2. **Méthodes de Comparaison:**

-   **`Equals(string value)`** : Compare la chaîne actuelle avec une autre chaîne.

    ```csharp
    string texte1 = "Bonjour";
    string texte2 = "Bonjour";
    bool sontEgal = texte1.Equals(texte2);  // true
    ```

-   **`CompareTo(string value)`** : Compare la chaîne actuelle avec une autre chaîne et retourne un entier indiquant leur ordre relatif.

    ```csharp
    string texte1 = "Bonjour";
    string texte2 = "Bonsoir";
    int comparaison = texte1.CompareTo(texte2);  // < 0 (car "Bonjour" est avant "Bonsoir")
    ```

-   **`StartsWith(string value)`** : Vérifie si la chaîne commence par la chaîne spécifiée.

    ```csharp
    string texte = "Bonjour le monde";
    bool commencePar = texte.StartsWith("Bonjour");  // true
    ```

-   **`EndsWith(string value)`** : Vérifie si la chaîne se termine par la chaîne spécifiée.

    ```csharp
    string texte = "Bonjour le monde";
    bool terminePar = texte.EndsWith("monde");  // true
    ```

### 2.3. **Recherche et Indexation**

-   **`IndexOf(string value)`** : Retourne l'index de la première occurrence de la chaîne spécifiée.

    ```csharp
    string texte = "Bonjour le monde";
    int index = texte.IndexOf("le");  // 8
    ```

-   **`LastIndexOf(string value)`** : Retourne l'index de la dernière occurrence de la chaîne spécifiée.

    ```csharp
    string texte = "Bonjour le monde le";
    int lastIndex = texte.LastIndexOf("le");  // 17
    ```

-   **`Contains(string value)`** : Vérifie si la chaîne contient la chaîne spécifiée.

    ```csharp
    string texte = "Bonjour le monde";
    bool contient = texte.Contains("le");  // true
    ```

-   **`StartsWith(string value, StringComparison comparisonType)`** : Vérifie si la chaîne commence par la chaîne spécifiée en utilisant un type de comparaison (sensible à la casse ou non).

    ```csharp
    string texte = "Bonjour";
    bool commencePar = texte.StartsWith("bon", StringComparison.OrdinalIgnoreCase);  // true
    ```

### 2.4. **Formatage**

-   **`Format(string format, object arg0, object arg1, ...)`** : Formate une chaîne en utilisant les valeurs spécifiées.

    ```csharp
    string texte = string.Format("Bonjour {0}, vous avez {1} nouveaux messages.", "Alice", 5);
    // "Bonjour Alice, vous avez 5 nouveaux messages."
    ```

-   **`ToString()`** : Convertit l'objet en sa représentation en chaîne. Pour les chaînes, cela retourne la chaîne elle-même.

    ```csharp
    string texte = 123.ToString();  // "123"
    ```
