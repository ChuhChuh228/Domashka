//var students = new List<Student>()
//{
//    new Student{Name = "Vasya", Group = "SBU228", AvgMark = 10.5},
//    new Student{Name = "Srehii", Group = "SBU228", AvgMark = 8.7},
//    new Student{Name = "Gleb", Group = "RZHD538", AvgMark = 9.1},
//    new Student{Name = "Petrii", Group = "RZHD538", AvgMark = 10.9},
//};
var Dzshki = new List<Dz>()
{
    new DZ{IdStudent = 5, IdLesoner = 228, NameLesson = "List", DescDZ = "super", MARK = 10},
    new DZ{IdStudent = 5, IdLesoner = 228, NameLesson = "Shota", DescDZ = "Ы сруь-ео", MARK = 5},
    new DZ{IdStudent = 1, IdLesoner = 6, NameLesson = "С++", DescDZ = "peremeni", MARK = 4}
};

//0
foreach (var dzo in Dzshki)
{
    Console.WriteLine("Ид студента: {dzo.IdStudent}, Ид учителя: {dzo.IdLesoner}, Имя предета:{dzo.NameLesson}, Описание: {dzo.DescDZ}, Оценка{dzo.MARK}");
}
