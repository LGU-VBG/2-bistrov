using System;

class Program
{
    static void Main()
    {
        // Определяем банкноты и их количество
        int[] notes = { 5000, 1000, 500, 100, 50, 10 };
        int[] count = { 2, 5, 10, 20, 30, 50 }; // Пример количества банкнот каждого достоинства

        // Ввод суммы покупки и суммы, которую дает покупатель
        Console.Write("Введите сумму покупки: ");
        int total = int.Parse(Console.ReadLine());
        
        Console.Write("Введите сумму денег, которую дает покупатель: ");
        int cash = int.Parse(Console.ReadLine());

        // Вычисляем сумму сдачи
        int change = cash - total;

        if (change < 0)
        {
            Console.WriteLine("Недостаточно средств для выдачи сдачи.");
            return;
        }
        
        if (change < 10)
        {
            Console.WriteLine("Сдача: " + change + " руб. ");
            return;
        }

        // Подсчет сдачи
        Console.WriteLine("Сдача: " + change + " руб.");
        for (int i = 0; i < notes.Length; i++)
        {
            if (change >= notes[i])
            {
                int numNotes = Math.Min(change / notes[i], count[i]);
                if (numNotes > 0)
                {
                    Console.WriteLine($"{numNotes} банкнот(ы) по {notes[i]} руб.");
                    change -= numNotes * notes[i];
                }
            }
        }

        // Проверка, осталась ли сдача
        if (change > 0)
        {
            Console.WriteLine("Недостаточно банкнот для выдачи полной сдачи.");
        }
    }
}
