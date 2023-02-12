var students = new List<Student>()
{
    new Student{Name = "Vasya", Group = "SBU228", AvgMark = 10.5},
    new Student{Name = "Srehii", Group = "SBU228", AvgMark = 8.7},
    new Student{Name = "Gleb", Group = "RZHD538", AvgMark = 9.1},
    new Student{Name = "Petrii", Group = "RZHD538", AvgMark = 10.9},
};

string ReagLine;

//1
/*foreach(var student in students)
{
    if (student.AvgMark >= 10)
        Console.WriteLine($"{student.Name}, {student.Group}, {student.AvgMark}");
}*/

//2 
ReagLine = Console.ReadLine();
foreach(var student in students)
{
    if (ReagLine.ToUpper() == student.Group.ToUpper())
    {
        Console.WriteLine($"{student.Name}, {student.Group}, {student.AvgMark}");
    }
        dsfsdf
}
