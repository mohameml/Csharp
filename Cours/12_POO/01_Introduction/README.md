# Cour 01 :

## 1. **Introduction de la Programmation Orientée Objet (POO):**

-   La Programmation Orientée Objet (POO) est un paradigme de programmation qui organise le code autour des objets plutôt que des fonctions ou des logiques procédurales.

-   En C#, la POO permet de créer des applications plus modulaires, réutilisables et maintenables.

-   Les objets sont des instances de classes, qui sont des modèles définissant les caractéristiques et comportements de ces objets.

-   La POO repose sur quatre principes fondamentaux : l'encapsulation, l'héritage, le polymorphisme, et l'abstraction.

## 2. **Classe en C#:**

-   **Description:**

    > Une classe en C# est un plan ou un modèle à partir duquel des objets sont créés. Elle définit les propriétés (attributs) et les comportements (méthodes) que les objets de cette classe posséderont. Une classe peut être considérée comme un type de données personnalisé, regroupant des variables (champs) et des fonctions (méthodes) liées entre elles.

-   **Syntaxe:**

    ```csharp
    public class NomDeClasse {
        // les attrs :
        private string nomAttr1;
        // constructeur :
        public NomDeClasse() {

        }
        // methodes :
        public void NomDeMethode() {

        }
    }

    //
    NomeDeClasse myClasse = new NomDeClasse();
    // or
    NomeDeClasse myClasse = new NomDeClasse {attr1 = valeur1 , attr2 = val2};
    ```

-   **Exemple:**

    ```csharp
    public class Personne
    {
        // Attributs (ou champs)
        public string nom;
        public int age;

        // Méthode
        public void AfficherInfo()
        {
            Console.WriteLine($"Nom: {nom}, Âge: {age}");
        }
    }
    ```

## 3. **Les Attributs:**

-   **Définition:**

    -   Les **attributs** d'une classe, également appelés **champs** ou **propriétés**, représentent les données ou l'état associé à un objet créé à partir de cette classe. En C#, les attributs peuvent être définis de différentes manières, offrant des niveaux de contrôle et d'encapsulation variés.

    -   Les attributs sont généralement déclarés au sein d'une classe avec un niveau d'accès (comme `public`, `private`, `protected`, etc.), et ils peuvent être manipulés via des **accesseurs** (`get`, `set`, `init`) qui permettent de lire ou de modifier les valeurs des attributs.

-   **Syntaxe:**

    ```csharp
    public class NomDeClasse
    {
        // Propriété avec get et set
        public string Attr1 { get; set; }

        // Propriété avec get et init
        public int Attr2 { get; init; }
    }
    ```

    -   **`get`** : L'accesseur `get` est utilisé pour lire la valeur d'une propriété.
    -   **`set`** : L'accesseur `set` est utilisé pour définir ou modifier la valeur d'une propriété.
    -   **`init`** : Introduit dans C# 9.0, l'accesseur `init` est similaire à `set`, mais il ne permet de définir la valeur d'une propriété qu'au moment de l'initialisation de l'objet, c'est-à-dire lors de la création de l'objet ou dans un constructeur.

-   **Exemple 1:**

    ```csharp
    public class Personne
    {
        public string Nom { get; set; }  // Propriété automatique

        private int age;

        // Propriété avec logique de validation dans set
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
            }
        }
    }

    // Utilisation
    Personne personne1 = new Personne();
    personne1.Nom = "Alice";  // set
    Console.WriteLine(personne1.Nom);  // get
    personne1.Age = 30;  // set avec validation
    Console.WriteLine(personne1.Age);  // get
    ```

    -   La propriété `Nom` est une propriété automatique où `get` et `set` sont utilisés sans logique supplémentaire.
    -   La propriété `Age` contient une logique de validation dans l'accesseur `set` qui vérifie que l'âge est supérieur à 0 avant de le définir.

-   **Exemple 2 : Propriété avec `init`**

    ```csharp
    public class Personne
    {
        public string Nom { get; init; }
        public int Age { get; init; }
    }

    // Utilisation
    Personne personne1 = new Personne
    {
        Nom = "Bob",
        Age = 25
    };

    // Les propriétés Nom et Age sont définies à l'initialisation et ne peuvent pas être modifiées après
    Console.WriteLine(personne1.Nom);  // Affiche : Bob
    Console.WriteLine(personne1.Age);  // Affiche : 25

    // Cela provoquera une erreur de compilation :
    // personne1.Nom = "Charlie";
    ```

    -   Les propriétés `Nom` et `Age` sont marquées avec `init`, ce qui signifie qu'elles peuvent être définies lors de l'initialisation de l'objet, mais ne peuvent pas être modifiées par la suite.

## 4. **Constructeur:**

-   **Définition:**

    > Un **constructeur** en C# est une méthode spéciale utilisée pour initialiser un nouvel objet d'une classe. Il porte le même nom que la classe et n'a pas de type de retour, pas même `void`. Le constructeur est appelé automatiquement lors de la création d'une instance d'une classe et il permet de définir les valeurs initiales des attributs ou de préparer l'objet pour son utilisation.

-   **Syntaxe de Base:**

    ```csharp
    public class Personne
    {
        public string Nom;
        public int Age;

        // Constructeur par défaut
        public Personne()
        {
            Nom = "Inconnu";
            Age = 0;
        }

        // Constructeur avec paramètres
        public Personne(string nom, int age)
        {
            Nom = nom;
            Age = age;
        }
    }
    ```

-   **Types de Constructeurs:**

    1. **Constructeur par défaut** : Un constructeur qui ne prend aucun paramètre. Si aucune valeur n'est spécifiée, les attributs de la classe sont initialisés avec des valeurs par défaut.

        ```csharp
        public Personne()
        {
            Nom = "Inconnu";
            Age = 0;
        }
        ```

    2. **Constructeur avec paramètres** : Un constructeur qui prend des paramètres pour initialiser les attributs avec des valeurs spécifiques fournies lors de la création de l'objet.

        ```csharp
        public Personne(string nom, int age)
        {
            Nom = nom;
            Age = age;
        }
        ```

    3. **Constructeur statique** : Un constructeur spécial utilisé pour initialiser les membres statiques de la classe. Il est appelé automatiquement avant la création du premier objet de la classe ou avant l'accès à des membres statiques de la classe. Il n'a pas de modificateur d'accès et ne prend pas de paramètres.

        ```csharp
        public class Config
        {
            public static readonly string AppName;

            // Constructeur statique
            static Config()
            {
                AppName = "MonApplication";
            }
        }
        ```

    4. **Constructeur de copie** (non natif en C#) : Bien que C# ne fournisse pas un constructeur de copie par défaut, vous pouvez le définir manuellement pour créer une copie d'un objet existant.

        ```csharp
        public class Personne
        {
            public string Nom;
            public int Age;

            public Personne(Personne autre)
            {
                Nom = autre.Nom;
                Age = autre.Age;
            }
        }
        ```

## 5. **Méthodes:**

-   **Def:**

    > Les méthodes en C# sont des fonctions définies à l'intérieur d'une classe qui décrivent les comportements que les objets de cette classe peuvent effectuer. Elles peuvent manipuler les attributs de la classe ou effectuer d'autres actions.

-   **Exemple de méthode dans une classe :**

    ```csharp
    public class Personne
    {
        public string nom;
        public int age;

        // Méthode pour afficher les informations de la personne
        public void AfficherInfo()
        {
            Console.WriteLine($"Nom: {nom}, Âge: {age}");
        }

        // Méthode pour modifier l'âge
        public void ModifierAge(int nouvelAge)
        {
            age = nouvelAge;
        }
    }
    ```

    Dans cet exemple, `AfficherInfo` est une méthode qui affiche les informations d'une personne, tandis que `ModifierAge` est une méthode qui permet de changer l'âge d'une personne.

## 6. **Les Méthodes Communes:**

-   **Description:**

    > En C#, certaines méthodes sont communes à toutes les classes car elles sont héritées de la classe de base `System.Object`, la classe racine de toutes les classes en C#. Vous pouvez **surcharger** (override) ces méthodes pour fournir une implémentation spécifique à votre classe.

-   **Méthodes Communes en C#:**

    1. **`ToString()`**

        - Cette méthode retourne une représentation sous forme de chaîne de l'objet.
        - Par défaut, elle retourne le nom complet du type de l'objet.
        - Elle est souvent surchargée pour retourner une représentation plus significative de l'objet.

        ```csharp
        public override string ToString()
        {
            return $"Nom: {Nom}, Âge: {Age}";
        }
        ```

    2. **`Equals(object obj)`**

        - Cette méthode compare deux objets pour vérifier s'ils sont égaux.
        - Par défaut, elle effectue une comparaison de référence (c'est-à-dire, elle vérifie si les deux objets pointent vers la même adresse mémoire).
        - Elle peut être surchargée pour fournir une comparaison plus complexe basée sur les valeurs des propriétés.

        ```csharp
        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;

            Personne autre = (Personne)obj;
            return this.Nom == autre.Nom && this.Age == autre.Age;
        }
        ```

    3. **`GetHashCode()`**

        - Cette méthode retourne un code de hachage pour l'objet.
        - Elle est souvent surchargée en parallèle avec `Equals` pour garantir que deux objets égaux produisent le même code de hachage.

        ```csharp
        public override int GetHashCode()
        {
            return Nom.GetHashCode() ^ Age.GetHashCode();
        }
        ```

### RQ : la differance entre **propriété** et **attribut**

| **Aspect**        | **Attributs**                          | **Propriétés**                                                          |
| ----------------- | -------------------------------------- | ----------------------------------------------------------------------- |
| **Déclaration**   | Déclarés directement avec des types    | Déclarés avec des accesseurs `get` et `set`                             |
| **Visibilité**    | Peuvent être `public`, `private`, etc. | Généralement `public` avec `get` et `set`                               |
| **Accès**         | Accès direct aux données               | Encapsulent l'accès aux données, permettant de la logique additionnelle |
| **Utilisation**   | Stockent les données brutes            | Permettent de contrôler la façon dont les données sont lues et écrites  |
| **Encapsulation** | Pas d'encapsulation par défaut         | Encapsulation par défaut (logique dans `get` et `set`)                  |
| **Validation**    | Aucune validation par défaut           | Validation possible dans les accesseurs                                 |
