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

