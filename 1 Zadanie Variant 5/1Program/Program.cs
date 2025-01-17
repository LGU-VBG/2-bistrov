using System;

namespace ElevatorSimulation
{
    // Класс описывающий пассажира
    public class Passenger
    {
        public string Name { get; set; }

        public Passenger(string name)
        {
            Name = name;
        }

        // Метод для нажатия кнопки Едем
        public void PressButton()
        {
            Console.WriteLine($"{Name}, нажмите любую клавишу, чтобы продолжить движение...");
            Console.ReadKey(); // Ждем нажатия клавиши
            Console.WriteLine($"{Name} нажимает кнопку «Едем».");
        }
    }

    // Класс, описывающий лифт
    public class Elevator
    {
        private int currentFloor = 1;
        private Random random = new Random();

        public void Start()
        {
            Console.WriteLine("Лифт начинает движение.");

            while (currentFloor >= 1 && currentFloor <= 8)
            {
                // Определяем следующий этаж
                int nextFloor = random.Next(1, 9); // Генерируем случайный этаж от 1 до 8

                // Двигаемся на следующий этаж
                MoveToFloor(nextFloor);

                // Если лифт на третьем этаже останавливаемся и ждем нажатия кнопки
                if (currentFloor == 3)
                {
                    Console.WriteLine($"Лифт остановился на этаже {currentFloor} для технической остановки.");

                    // Создаем пассажира
                    Passenger passenger = new Passenger("Пассажир");

                    // Пассажир нажимает кнопку «Едем»
                    passenger.PressButton();

                    Console.WriteLine("Лифт продолжает движение.");
                }
            }

            Console.WriteLine("Лифт завершил работу.");
        }

        // Метод для движения на указанный этаж
        private void MoveToFloor(int floor)
        {
            Console.WriteLine($"Лифт движется с этажа {currentFloor} на этаж {floor}.");
            currentFloor = floor; // Обновляет текущий этаж
            Console.WriteLine($"Лифт достиг этажа {currentFloor}.");
        }
    }

    // Класс с точкой входа в программу
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем объект лифта
            Elevator elevator = new Elevator();

            // Запускаем лифт
            elevator.Start();

            // Программа завершится только после завершения работы лифта
            Console.WriteLine("Программа завершена.");
        }
    }
}