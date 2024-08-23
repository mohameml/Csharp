Créer un projet complet en C# pour un débutant peut être une excellente manière de consolider plusieurs concepts essentiels tels que la Programmation Orientée Objet (POO), l'interaction avec une base de données, l'utilisation de bibliothèques dynamiques (DLL), et l'écriture de tests unitaires. Voici une proposition de projet simple mais complet, appelé **"Gestionnaire de Bibliothèque"**.

### 1. **Description du Projet**

Le projet "Gestionnaire de Bibliothèque" est une application console qui permet de gérer une collection de livres. Les fonctionnalités incluent :

-   Ajout, suppression et mise à jour des livres.
-   Recherche de livres par titre ou auteur.
-   Sauvegarde des données dans une base de données.
-   Utilisation de classes pour modéliser les livres et la gestion de la bibliothèque.
-   Exposition de certaines fonctionnalités dans une DLL.
-   Tests unitaires pour vérifier le bon fonctionnement de l'application.

### 2. **Structure du Projet**

Le projet sera divisé en plusieurs parties :

1. **CoreLibrary (DLL)** : Contiendra les classes et la logique métier.
2. **LibraryDatabase (Database)** : Utilisation d'Entity Framework pour interagir avec la base de données.
3. **LibraryApp (Application Console)** : Interface utilisateur qui permet de gérer la bibliothèque via la ligne de commande.
4. **LibraryTests (Tests Unitaires)** : Projet de tests pour valider les fonctionnalités.

### 3. **Étapes de Développement**

#### **Étape 1: Créer la DLL (CoreLibrary)**

1. **Créer un projet de bibliothèque de classes** nommé `CoreLibrary`.
2. **Modéliser les classes** :
    - `Book` : Représente un livre.
    - `LibraryManager` : Contient la logique pour gérer les livres.

```csharp
// CoreLibrary/Book.cs
namespace CoreLibrary
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
    }
}
```

```csharp
// CoreLibrary/LibraryManager.cs
using System.Collections.Generic;
using System.Linq;

namespace CoreLibrary
{
    public class LibraryManager
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                books.Remove(book);
            }
        }

        public Book FindBookByTitle(string title)
        {
            return books.FirstOrDefault(b => b.Title == title);
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }
    }
}
```

#### **Étape 2: Créer le Projet de Base de Données (LibraryDatabase)**

1. **Ajouter un projet de classe** nommé `LibraryDatabase`.
2. **Ajouter une référence** à `CoreLibrary`.
3. **Installer Entity Framework** via NuGet : `Install-Package EntityFramework`.
4. **Configurer la base de données** et le contexte.

```csharp
// LibraryDatabase/LibraryContext.cs
using System.Data.Entity;
using CoreLibrary;

namespace LibraryDatabase
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public LibraryContext() : base("LibraryDB")
        {
        }
    }
}
```

#### **Étape 3: Créer l'Application Console (LibraryApp)**

1. **Créer un projet d'application console** nommé `LibraryApp`.
2. **Ajouter des références** à `CoreLibrary` et `LibraryDatabase`.
3. **Construire l'interface utilisateur** qui permet de gérer la bibliothèque.

```csharp
using System;
using CoreLibrary;
using LibraryDatabase;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new LibraryContext())
        {
            var libraryManager = new LibraryManager();

            // Exemple : Ajouter un livre
            var book = new Book { Title = "C# Programming", Author = "John Doe", Year = 2023 };
            libraryManager.AddBook(book);
            context.Books.Add(book);
            context.SaveChanges();

            // Exemple : Afficher tous les livres
            var books = context.Books.ToList();
            foreach (var b in books)
            {
                Console.WriteLine($"Title: {b.Title}, Author: {b.Author}, Year: {b.Year}");
            }
        }
    }
}
```

#### **Étape 4: Créer le Projet de Tests Unitaires (LibraryTests)**

1. **Créer un projet de tests** nommé `LibraryTests`.
2. **Ajouter une référence** à `CoreLibrary`.
3. **Utiliser MSTest** pour écrire des tests unitaires simples.

```csharp
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoreLibrary;

namespace LibraryTests
{
    [TestClass]
    public class LibraryManagerTests
    {
        [TestMethod]
        public void AddBook_ShouldAddBookToList()
        {
            // Arrange
            var libraryManager = new LibraryManager();
            var book = new Book { Title = "Test Book", Author = "Test Author", Year = 2023 };

            // Act
            libraryManager.AddBook(book);
            var allBooks = libraryManager.GetAllBooks();

            // Assert
            Assert.AreEqual(1, allBooks.Count);
            Assert.AreEqual("Test Book", allBooks[0].Title);
        }
    }
}
```

### 4. **Conclusion et Extensions**

Ce projet simple couvre plusieurs concepts importants en C# :

-   **POO** : Avec les classes `Book` et `LibraryManager`.
-   **Base de données** : Utilisation d'Entity Framework pour la gestion des données.
-   **DLL** : En séparant la logique métier dans `CoreLibrary`.
-   **Tests Unitaires** : Avec `MSTest`.

#### **Extensions possibles** :

-   Ajouter une interface utilisateur graphique (WPF ou WinForms).
-   Ajouter une fonctionnalité de recherche avancée.
-   Implémenter un système de prêt de livres.
-   Intégrer des services externes pour obtenir des informations supplémentaires sur les livres.

Ce projet peut évoluer en complexité à mesure que vous maîtrisez les concepts de base.
