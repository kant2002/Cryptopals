global using рядок = System.String;
global using байт = System.Byte;
global using ціл = System.Int32;
global using симв = System.Char;
global using Виключення = System.Exception;

using System.Diagnostics;
using System.Text;

static class Консоль
{
    public static void НадрукуватиЛінію(рядок формат)
    {
        System.Console.WriteLine(формат);
    }
}

class Список<Т>
{
    List<Т> список = new();

    public void Додати(Т елемент)
    {
        список.Add(елемент);
    }

    public Т[] ДоМасиву() => список.ToArray();
}

class БудіникРядків
{
    StringBuilder будівник = new();

    public void Додати(симв значення)
    {
        будівник.Append(значення);
    }

    public void Додати(рядок? значення)
    {
        будівник.Append(значення);
    }

    public void Додати(симв[]? значення)
    {
        будівник.Append(значення);
    }

    public рядок ДоРядка() => будівник.ToString();
}

static class Відладка
{
    public static void Вдостовіритися(bool умова)
    {
        Debug.Assert(умова);
    }
}

static class Масив
{
    public static Т[] Пустий<Т>()
    {
        return Array.Empty<Т>();
    }
}

