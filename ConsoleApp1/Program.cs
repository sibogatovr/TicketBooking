// See https://aka.ms/new-console-template for more information

int[] sectors = { 6, 28, 15, 15, 17 };
bool isOpen = true;

while (isOpen)
{
    Console.SetCursorPosition(0, 20);
    for (int i = 0; i < sectors.Length; i++)
    {
        Console.WriteLine($"В секторе {i + 1} свободно {sectors[i]} мест.");
    }
    Console.SetCursorPosition(0, 0);
    Console.WriteLine("Регистрация рейса.");
    Console.WriteLine("\n\n1 - Забронировать места\n\n2 - Выход из программы\n\n");
    Console.Write("Введите номер команды: ");


    switch (Convert.ToInt32(Console.ReadLine()))
    {
        case 1:
            int userSector, userPlaceAmount;
            Console.Write("В каком секторе вы хотите забронирова место? ");
            userSector = Convert.ToInt32(Console.ReadLine()) - 1;
            if (sectors.Length <= userSector || userSector < 0)
            {
                Console.WriteLine("Такого сектора не существует");
                break;
            }
            Console.Write("Сколько место вы хотите забронировать? ");
            userPlaceAmount = Convert.ToInt32(Console.ReadLine());
            if (userPlaceAmount < 0)
            {
                Console.WriteLine("Неверное количество мест.");
                break;
            }
            if (sectors[userSector] < userPlaceAmount || userPlaceAmount < 0)
            {
                Console.WriteLine($"В секторе {userSector} недостаточно мест. Остаток {sectors[userSector]}");
                break;
            }
            sectors[userSector] -= userPlaceAmount;
            Console.WriteLine($"Бронирование успешно! Вы забронировали {userPlaceAmount} мест, в секторе - {userSector}");
            break;
        case 2:
            isOpen = false;
            break;

    }

    Console.ReadKey();
    Console.Clear();
}
