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
string correctPassword = "qwerty123";
int count4 = 0;
while (true)
{
   Console.Write("Введите пароль от личного кабинета:");
   string password = Console.ReadLine();

   if (password == correctPassword)
   {
      Console.WriteLine("Доступ разрешён");
      Console.WriteLine($"Неудачных попыток: {count4}");
      break;
      
   }

   Console.WriteLine("Неверный пароль, попробуйте снова");
   count4++;
}