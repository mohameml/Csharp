# cour :les **espaces de noms** (namespaces)

> En C#, les **espaces de noms** (namespaces) sont utilisés pour organiser et structurer le code en regroupant les classes, interfaces, structures, énumérations, et autres types en unités logiques. Les **directives `using`** facilitent l'utilisation de ces espaces de noms en réduisant la nécessité de spécifier des chemins de noms longs dans le code.

## 1. **Espaces de Noms (Namespaces):**

### 1.1. **Déclaration d'un Espace de Noms:**

-   Les espaces de noms sont déclarés à l'aide du mot-clé `namespace`. Ils permettent de regrouper des types et d'éviter les conflits de noms.

-   **Exemple de Déclaration**

    ```csharp
    namespace MonApplication.GestionUtilisateurs
    {
        public class Utilisateur
        {
            public string Nom { get; set; }
            public int Age { get; set; }

            public void AfficherInfos()
            {
                Console.WriteLine($"Nom: {Nom}, Age: {Age}");
            }
        }
    }

    namespace MonApplication.GestionProduits
    {
        public class Produit
        {
            public string Nom { get; set; }
            public decimal Prix { get; set; }

            public void AfficherInfos()
            {
                Console.WriteLine($"Nom: {Nom}, Prix: {Prix}");
            }
        }
    }
    ```

### 1.2. **Utilisation des Types dans un Espace de Noms:**

-   Lorsque vous souhaitez utiliser une classe ou un autre type défini dans un espace de noms, vous devez soit spécifier le chemin complet, soit utiliser une directive `using`.

-   **Exemple:**

    ```csharp
    public class Program
    {
        public static void Main()
        {
            MonApplication.GestionUtilisateurs.Utilisateur utilisateur = new MonApplication.GestionUtilisateurs.Utilisateur();
            utilisateur.Nom = "Alice";
            utilisateur.AfficherInfos();

            MonApplication.GestionProduits.Produit produit = new MonApplication.GestionProduits.Produit();
            produit.Nom = "Ordinateur";
            produit.Prix = 999.99M;
            produit.AfficherInfos();
        }
    }
    ```

## 2. **Directives `using`:**

-   Les **directives `using`** simplifient le code en permettant l'utilisation de types d'espaces de noms sans avoir à spécifier leur chemin complet.

-   **Exemple avec `using`:**

    ```csharp
    using MonApplication.GestionUtilisateurs;
    using MonApplication.GestionProduits;

    public class Program
    {
        public static void Main()
        {
            Utilisateur utilisateur = new Utilisateur();
            utilisateur.Nom = "Alice";
            utilisateur.AfficherInfos();

            Produit produit = new Produit();
            produit.Nom = "Ordinateur";
            produit.Prix = 999.99M;
            produit.AfficherInfos();
        }
    }
    ```

## 3. **Alias d'Espace de Noms:**

-   Les alias permettent de créer des raccourcis pour les espaces de noms longs ou de résoudre des conflits de noms.

-   **Exemple de Déclaration d'un Alias**

    ```csharp
    using GestionUtilisateurs = MonApplication.GestionUtilisateurs;
    using GestionProduits = MonApplication.GestionProduits;

    public class Program
    {
        public static void Main()
        {
            GestionUtilisateurs.Utilisateur utilisateur = new GestionUtilisateurs.Utilisateur();
            utilisateur.Nom = "Alice";
            utilisateur.AfficherInfos();

            GestionProduits.Produit produit = new GestionProduits.Produit();
            produit.Nom = "Ordinateur";
            produit.Prix = 999.99M;
            produit.AfficherInfos();
        }
    }
    ```
