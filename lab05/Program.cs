class Student
{
    public string Surname { get; set; }
    public string Group { get; set; }
    public int Grade { get; set; }
    public int Year { get; set; }

    public Student(string surname, string group, int grade, int year)
    {
        Surname = surname;
        Group = group;
        Grade = grade;
        Year = year;
    }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student("Ткаченко", "ІПЗ-3/1", 85, 2024),
            new Student("Бондар", "ІПЗ-3/2", 92, 2023),
            new Student("Іваненко", "ІПЗ-3/1", 85, 2024),
            new Student("Коваль", "ІПЗ-3/2", 78, 2024),
            new Student("Сидоренко", "ІПЗ-3/1", 85, 2023),
            new Student("Мельник", "ІПЗ-3/2", 92, 2024),
            new Student("Гриценко", "ІПЗ-3/1", 78, 2023),
            new Student("Дяченко", "ІПЗ-3/2", 85, 2023)
        };

        void PrintAll(string title, IEnumerable<Student> items)
        {
            Console.WriteLine("\n" + title);

            foreach (Student s in items)
            {
                Console.WriteLine(
                    $"{s.Surname} | {s.Group} | {s.Grade} | {s.Year}");
            }
        }

        var bySurname = students.OrderBy(s => s.Surname);
        PrintAll("1. Сортування за прізвищем:", bySurname);

        var byGrade = students
            .OrderByDescending(s => s.Grade)
            .ThenBy(s => s.Surname);

        PrintAll("2. Сортування за балом:", byGrade);

        var byGroupAndGrade = students
            .OrderBy(s => s.Group)
            .ThenByDescending(s => s.Grade);

        PrintAll("3. Сортування за групою та балом:", byGroupAndGrade);
    }
}