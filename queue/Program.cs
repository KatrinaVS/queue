using System;
using System.Collections.Generic;
namespace queue
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите первый элемент очереди - ");
            var variadle = Console.ReadLine();
            Console.Write("Введите второй элемент очереди - ");
            var variadl = Console.ReadLine();
            Console.Write("Введите третий элемент очереди - ");
            var variad = Console.ReadLine();

            int a = Int32.Parse(variadle);
            int b = Int32.Parse(variadl);
            int c = Int32.Parse(variad);

            Queue<int> numbers = new Queue<int>();

            // добавление элементов в очередь
            numbers.Enqueue(a);
            numbers.Enqueue(b);
            numbers.Enqueue(c);
            
            // получение первого элемента в очереди
            int queueElement = numbers.Dequeue();
            Console.WriteLine("Первый элемент в очереди - "+ (queueElement));

            // получение первого элемента очереди без его извлечения           
            var item= numbers.Peek();
            Console.WriteLine($"Первый элемент в очереди без извлечения - {item}");

            Console.ReadLine();
        }
    }
}
