# cour 02 : **Les Variables en C#**

> En C#, une variable est un conteneur utilisé pour stocker des données qui peuvent être modifiées lors de l'exécution du programme. Les variables ont un nom, un type, et une valeur.

## 1. **Déclaration et Initialisation des Variables:**

-   La déclaration d'une variable en C# consiste à spécifier son type, suivi du nom de la variable.

-   L'initialisation consiste à attribuer une valeur à la variable lors de sa déclaration ou à un moment ultérieur.

-   Voici un exemple de déclaration et d'initialisation d'une variable :

    ```csharp
    int age;            // Déclaration d'une variable 'age' de type entier (int)
    age = 25;           // Initialisation de la variable avec la valeur 25

    // Ou bien, vous pouvez faire les deux en une seule ligne :
    int taille = 180;   // Déclaration et initialisation de la variable 'taille'
    ```

## 2. **Types de Données:**

-   En C#, chaque variable doit avoir un type de données spécifique.

-   Voici quelques types de données de base utilisés couramment :

    -   **int** : Entiers (ex : 1, -3, 42)
    -   **float** : Nombres à virgule flottante de précision simple (ex : 3.14f, -0.5f)
    -   **double** : Nombres à virgule flottante de précision double (ex : 2.71828, -100.0)
    -   **char** : Caractères (ex : 'A', 'z', '!')
    -   **string** : Chaînes de caractères (ex : "Hello, World!", "C#")
    -   **bool** : Booléens (ex : true, false)

-   **Exemple de Déclaration de Variables:**

    Voici un exemple montrant différentes variables avec des types de données différents :

    ```csharp
    int nombre = 10;               // Entier
    float temperature = 25.5f;     // Nombre à virgule flottante
    double pi = 3.14159;           // Nombre à virgule flottante double
    char initiale = 'C';           // Caractère
    string message = "Bonjour";    // Chaîne de caractères
    bool estVrai = true;           // Booléen
    ```

## 3. **Variables Implicites**

-   **Description:**

    > C# permet également l'utilisation de la déclaration implicite de variables avec le mot-clé `var`. Le compilateur détermine automatiquement le type de la variable en fonction de la valeur assignée .

-   **Exemple:**

    ```csharp
    var nombre = 10;           // Implicitement de type int
    var message = "Bonjour";   // Implicitement de type string
    var pi = 3.14159;          // Implicitement de type double
    ```

Cependant, il est important de noter que l'utilisation de `var` ne signifie pas que la variable est dynamiquement typée ; son type est déterminé au moment de la compilation et ne peut pas changer par la suite.

## 4. **Constantes:**

-   **Description:**

    > En C#, il est aussi possible de déclarer des constantes, c'est-à-dire des variables dont la valeur ne peut pas être modifiée après son initialisation. Les constantes sont déclarées avec le mot-clé `const` .

-   **Exemple:**

    ```csharp
    const double gravite = 9.81;   // Constante de type double
    const int joursSemaine = 7;    // Constante de type entier
    ```

    Les constantes doivent être initialisées lors de leur déclaration et ne peuvent pas être modifiées par la suite.

## 5. **Portée des Variables:**

La portée d'une variable désigne la partie du programme où elle est accessible. En général, une variable déclarée dans une méthode ne sera accessible que dans cette méthode, tandis qu'une variable déclarée dans une classe peut être accessible à travers toute la classe, selon son modificateur d'accès.
