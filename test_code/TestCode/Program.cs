using System;

namespace ElevatorSimulation
{
    // Класс, описывающий пассажира
    public class Passenger
    {
        public string Name { get; set; }

        public Passenger(string name)
        {
            Name = name;
        }

        public void PressButton(Action continueMoving)
        {
            Console.WriteLine($" нажимает кнопку «Едем».");
            continueMoving();
        }
    }

    // Класс, лифт
    public class Elevator
    {
        public event Action TechnicalStop;
        private int currentFloor = 1;
        private Random random = new Random();

        public void Start()
        {
            Console.WriteLine("Лифт начинает движение.");

            while (currentFloor >= 1 && currentFloor <= 8)
            {
                // Определяем следующий этаж
                int nextFloor = random.Next(1, 8); // Генерируем случайный этаж от 1 до 8

                if (nextFloor == 3)
                {
                    // Остановка на третьем этаже
                    TechnicalStop.Invoke();
                    Console.WriteLine($"Лифт остановился на этаже для технической остановки.");
                    break;
                }

                MoveToFloor(nextFloor);
            }
        }

        private void MoveToFloor(int floor)
        {
            Console.WriteLine($"Лифт движется с  этажа на этаж.");
            currentFloor = floor;
            Console.WriteLine($"Лифт достиг этажа.");
        }
    }
}

