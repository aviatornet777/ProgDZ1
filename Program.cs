          // Домашнее задание
  // Задача 1


  Console.WriteLine("Введите первое число  ");
  int a=Convert.ToInt32(Console.ReadLine());

  Console.WriteLine("Введите второе число  ");
  int b=Convert.ToInt32(Console.ReadLine());
   
 if(a>b)
 {
    Console.Write("Максимальное значение = ");
    Console.WriteLine(a);
    Console.Write("Минимальное значение = ");
    Console.Write(b);
 }
 else if(a<b)
 {
    Console.Write("Максимальное значение = ");
    Console.WriteLine(b);
    Console.Write("Минимальное значение = ");
    Console.Write(a);
 }
 else if(a==b)
 {
    Console.WriteLine("Значения равны");
 }