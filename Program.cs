int dayNumber = 6;

switch (dayNumber) {
    case 5 or 6 or 7: Console.WriteLine("Выходной"); break;
    default: Console.WriteLine("Будний"); break;
}

//---

int score = 78;

switch (score)
{
    case >= 0 and < 40:
        Console.WriteLine("Неудовлетворительно");
        break;
    case >= 40 and < 60:
        Console.WriteLine("Удовлетворительно");
        break;
    case >= 60 and < 80:
        Console.WriteLine("Хорошо");
        break;
    case >= 80 and <= 100:
        Console.WriteLine("Отлично");
        break;
    default:
        Console.WriteLine("Некорректный балл");
        break;
}

//---

int score = 78;

string result = score switch {
    >= 85 => "Отлично",
    >= 70 => "Хорошо",
    >= 50 => "Удовлетворительно",
    >= 0 => "Неудовлетворительно",
    _ => "Некорректный балл"
};

Console.WriteLine(result);

//---

int temperature = 18;

string result = temperature switch
{
    < 0 => "Мороз",
    < 15 => "Прохладно",
    < 25 => "Комфортно",
    < 35 => "Жарко",
    _ => "Очень жарко"
};

Console.WriteLine(result);

//---

string role = "user";

string result = role switch
{
    "admin" => "Полный доступ",
    "teacher" => "Доступ преподавателя",
    _ => "Ограниченный доступ"
};

Console.WriteLine(result);

//---

int age = 20;
bool hasTicket = true;

switch (age)
{
    case >= 18 when hasTicket:
        Console.WriteLine("Вход разрешён");
        break;

    case >= 18 when !hasTicket:
        Console.WriteLine("Нет билета");
        break;

    default:
        Console.WriteLine("Возраст не подходит");
        break;
}

//---

int level = 2;

switch (level) {
    case 1:
        Console.WriteLine("Начальный уровень");
        break;
    case 2:
        Console.WriteLine("Средний уровень");
        goto case 1;
    case 3:
        Console.WriteLine("Продвинутый уровень");
        break;
}

//---

// Задача А. Время года

Console.WriteLine();

Console.WriteLine("Задача А. Время года");

Console.Write("Введите номер месяца: ");
int month = int.Parse(Console.ReadLine());

string season = month switch
{
    12 or 1 or 2 => "Зима",
    3 or 4 or 5 => "Весна",
    6 or 7 or 8 => "Лето",
    9 or 10 or 11 => "Осень",
    _ => "Неверный месяц"
};

Console.WriteLine(season);


// Задача Б. Категория возраста

Console.WriteLine();

Console.WriteLine("Задача Б. Категория возраста");

Console.Write("Введите возраст: ");
int age = int.Parse(Console.ReadLine());

string ageCategory = age switch
{
    < 0 => "Ошибка",
    <= 6 => "Ребёнок",
    <= 17 => "Подросток",
    <= 64 => "Взрослый",
    _ => "Пенсионер"
};

Console.WriteLine(ageCategory);


// Вариант 2. Категория результата

Console.WriteLine();

Console.WriteLine("Вариант 2. Категория результата");

Console.Write("Введите количество баллов: ");
int score = int.Parse(Console.ReadLine());

string result = score switch
{
    >= 0 and < 40 => "Неудовлетворительно",
    >= 40 and < 60 => "Удовлетворительно",
    >= 60 and < 80 => "Хорошо",
    >= 80 and <= 100 => "Отлично",
    _ => "Ошибка"
};

Console.WriteLine(result);


// Вариант 7. Уровень игрока

Console.WriteLine();

Console.WriteLine("Вариант 7. Уровень игрока");

Console.Write("Введите количество очков: ");
int points = int.Parse(Console.ReadLine());

string playerLevel = points switch
{
    < 0 => "Ошибка",
    < 1000 => "Новичок",
    < 5000 => "Опытный",
    < 10000 => "Продвинутый",
    _ => "Мастер"
};

Console.WriteLine(playerLevel);