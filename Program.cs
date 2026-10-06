//Шаг 1
// int lessonNumber = 5;
// int totalLessons = 5;

// while (lessonNumber >= 1)
// {
//    Console.WriteLine($"Пара {lessonNumber}");
//    lessonNumber--;
// }
// Console.WriteLine("Пары закончились");

//Шаг 2
// Console.WriteLine("Введите оценки по одной, для завершения введите -1:");
// int grade = int.Parse(Console.ReadLine());

// int count = 0;

// while (grade != -1)
// {
//    Console.WriteLine($"Оценка принята: {grade}");
//    count++;
//    grade = int.Parse(Console.ReadLine());

// }
// Console.WriteLine("Ввод завершён");
// Console.WriteLine($"Количество введенных оценок {count}");


//Шаг 3
// int sum = 0;
// int count3 = 0;

// Console.WriteLine("Вводите оценки, для завершения введите -1:");
// int grade3 = int.Parse(Console.ReadLine());
// while (grade3 != -1)
// {
//    sum += grade3;
//    count3++;
//    grade3 = int.Parse(Console.ReadLine());
// }

// if (count3 > 0)
// {
//    Console.WriteLine($"Средний балл: {(double)sum / count3}");
// }
// else
// {
//    Console.WriteLine("Оценок не было введено");
// }


//Шаг 4
// using System.Data.Common;

// string correctPassword = "qwerty123";
// int count4 = 0;

// while (true)
// {
//    Console.Write("Введите пароль от личного кабинета: ");
//    string password = Console.ReadLine();

//    if (password == correctPassword)
//    {
//       Console.WriteLine("Доступ разрешён");
//       Console.WriteLine($"Количество неудачных попыток: {count4}");
//       break;
//    }

//    Console.WriteLine("Неверный пароль, попробуйте снова");
//    count4++;
// }
//Шаг 5
// string answer;
// do
// {
//    Console.Write("Введите дату посещения (например, 01.09): ");
//    string date = Console.ReadLine();
//    Console.WriteLine($"Запись добавлена: {date}");

//    Console.Write("Добавить еще одну запись? (да/нет): ");
//    answer = Console.ReadLine();
// } while (answer == "да");

// Console.WriteLine("Дневник сохранен");


//Сам. задания
//Б
Console.WriteLine("Введите имена учеников, для завершения введите 'конец'");
string grade6 = Console.ReadLine();

int count6 = 0;

while (grade6 != "конец")
{
   Console.WriteLine($"Имя: {grade6}");
   count6++;
   
}
Console.WriteLine($"Количество введенных имен {count6}");
