# cour 08 :

-   **Description:**

    > Une jointure en LINQ est utilisée pour combiner des éléments de deux collections basées sur une clé commune. Cela permet de combiner des informations de différentes sources de données en une seule séquence.

-   **Syntaxe**

    La méthode `Join` de LINQ permet de joindre deux séquences en spécifiant la clé de jointure.

    ```csharp
    var result = collection1.Join(
        collection2,        // La seconde séquence à joindre
        item1 => item1.Key, // Clé de jointure pour la première séquence
        item2 => item2.Key, // Clé de jointure pour la seconde séquence
        (item1, item2) => new // Projection des éléments joints
        {
            Item1 = item1,
            Item2 = item2
        }
    );
    ```

-   **Syntaxe de la requête LINQ (requête syntaxique):**

    Vous pouvez également utiliser la syntaxe de requête LINQ pour effectuer des jointures :

    ```csharp
    var result = from item1 in collection1
                join item2 in collection2
                on item1.Key equals item2.Key
                select new
                {
                    Item1 = item1,
                    Item2 = item2
                };
    ```

-   **Exemple:**

    Imaginons que vous avez deux collections : `students` et `courses`. Vous souhaitez joindre ces collections sur un identifiant de cours pour obtenir les étudiants inscrits dans chaque cours.

    ```csharp
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CourseId { get; set; }
    }

    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            // Données d'exemple
            var students = new List<Student>
            {
                new Student { Id = 1, Name = "Alice", CourseId = 1 },
                new Student { Id = 2, Name = "Bob", CourseId = 2 },
                new Student { Id = 3, Name = "Charlie", CourseId = 1 }
            };

            var courses = new List<Course>
            {
                new Course { Id = 1, CourseName = "Math" },
                new Course { Id = 2, CourseName = "English" }
            };

            // Jointure en utilisant la méthode Join
            var studentCourses = students.Join(
                courses,
                student => student.CourseId,
                course => course.Id,
                (student, course) => new
                {
                    StudentName = student.Name,
                    CourseName = course.CourseName
                }
            );

            // Affichage des résultats
            foreach (var sc in studentCourses)
            {
                Console.WriteLine($"{sc.StudentName} is enrolled in {sc.CourseName}");
            }


        }
    }
    ```
