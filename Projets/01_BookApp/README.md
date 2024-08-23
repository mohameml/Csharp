# **Cahier des Charges : Application Console C# de Gestion de Bibliothèque avec Connexion à une Base de Données MySQL**

## 1. **Introduction**

-   Ce document décrit les spécifications fonctionnelles et techniques pour le développement d'une application console en C# permettant la gestion d'une bibliothèque. L'application se connectera à une base de données MySQL pour gérer les livres, les bibliothèques, les étudiants, et les emprunts.

## 2. **Objectifs du Projet**

L'objectif principal de l'application est de fournir une solution simple pour gérer les opérations courantes d'une bibliothèque, notamment :

-   La gestion des bibliothèques.
-   La gestion des livres.
-   La gestion des étudiants.
-   La gestion des emprunts et retours de livres.

## 3. **Spécifications Fonctionnelles**

#### 3.1 **Gestion des Bibliothèques**

-   **Créer une bibliothèque** : Permet d'ajouter une nouvelle bibliothèque dans la base de données.
-   **Modifier une bibliothèque** : Permet de mettre à jour les informations d'une bibliothèque existante.
-   **Supprimer une bibliothèque** : Permet de supprimer une bibliothèque de la base de données.
-   **Lister les bibliothèques** : Affiche la liste de toutes les bibliothèques.

#### 3.2 **Gestion des Livres**

-   **Ajouter un livre** : Permet d'ajouter un nouveau livre dans une bibliothèque spécifique.
-   **Modifier un livre** : Permet de mettre à jour les informations d'un livre existant.
-   **Supprimer un livre** : Permet de supprimer un livre d'une bibliothèque.
-   **Lister les livres** : Affiche la liste de tous les livres d'une bibliothèque.

#### 3.3 **Gestion des Étudiants**

-   **Ajouter un étudiant** : Permet d'ajouter un nouvel étudiant dans le système.
-   **Modifier un étudiant** : Permet de mettre à jour les informations d'un étudiant existant.
-   **Supprimer un étudiant** : Permet de supprimer un étudiant de la base de données.
-   **Lister les étudiants** : Affiche la liste de tous les étudiants inscrits.

### 3.4 **Gestion des Emprunts**

-   **Emprunter un livre** : Permet à un étudiant d'emprunter un livre d'une bibliothèque.
-   **Retourner un livre** : Permet à un étudiant de retourner un livre emprunté.
-   **Lister les emprunts** : Affiche la liste de tous les emprunts en cours ou retournés.
-   **Notifier des retards** : Affiche une liste des emprunts ayant dépassé la durée autorisée de 20 jours.

## 4. **Spécifications Techniques**

##### 4.1 **Technologies Utilisées**

-   **Langage de programmation** : C#
-   **Base de données** : MySQL
-   **Framework** : .NET Core ou .NET 6 (selon les besoins)
-   **IDE** : Visual Studio ou tout autre environnement compatible

### 4.2 **Structure de la Base de Données**

La base de données MySQL devra contenir les tables suivantes :

-   **Bibliotheques**

    -   `id` (INT, Primary Key, Auto Increment)
    -   `nom` (VARCHAR)
    -   `adresse` (VARCHAR)

-   **Livres**

    -   `id` (INT, Primary Key, Auto Increment)
    -   `titre` (VARCHAR)
    -   `auteur` (VARCHAR)
    -   `isbn` (VARCHAR)
    -   `bibliotheque_id` (INT, Foreign Key référant à `Bibliotheques`)

-   **Etudiants**

    -   `id` (INT, Primary Key, Auto Increment)
    -   `nom` (VARCHAR)
    -   `prenom` (VARCHAR)
    -   `matricule` (VARCHAR)

-   **Emprunts**
    -   `id` (INT, Primary Key, Auto Increment)
    -   `livre_id` (INT, Foreign Key référant à `Livres`)
    -   `etudiant_id` (INT, Foreign Key référant à `Etudiants`)
    -   `date_emprunt` (DATE)
    -   `date_retour` (DATE, nullable)

#### 4.3 **Connexion à la Base de Données**

-   Utilisation de `MySql.Data` ou `MySqlConnector` pour se connecter à la base de données MySQL.
-   La chaîne de connexion doit être sécurisée et stockée de manière appropriée dans le code ou dans un fichier de configuration.

## 5. **Interface Utilisateur**

L'application étant une console, l'interface utilisateur sera textuelle. Des menus clairs et intuitifs doivent être présentés pour permettre une navigation facile entre les différentes fonctionnalités.

### 5.1 **Menu Principal**

-   1. Gestion des Bibliothèques
-   2. Gestion des Livres
-   3. Gestion des Étudiants
-   4. Gestion des Emprunts
-   5. Quitter

### 5.2 **Sous-menus**

Chacun des menus principaux mènera à des sous-menus où l'utilisateur pourra choisir des actions spécifiques (ajouter, modifier, supprimer, lister).

## 6. **Livrables**

-   Le code source complet de l'application.
-   Le script SQL pour la création de la base de données.
-   La documentation technique décrivant l'installation, la configuration et l'utilisation de l'application.

## 7. **Planification et Délais**

Le projet sera réalisé en plusieurs phases, avec des livraisons intermédiaires pour validation :

-   **Phase 1** : Conception de la base de données.
-   **Phase 2** : Développement des fonctionnalités de gestion de la bibliothèque.
-   **Phase 3** : Développement des fonctionnalités d'emprunt et de retour.
-   **Phase 4** : Tests et validation.
-   **Phase 5** : Documentation et livraison finale.
