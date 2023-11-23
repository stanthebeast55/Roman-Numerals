Console.WriteLine("Geef 1e numeral:");
string numeral1 = Console.ReadLine();

Console.WriteLine("Geef 2e numeral:");
string numeral2 = Console.ReadLine();

Console.WriteLine("Geef uitvoering:");
string symbol = Console.ReadLine();

Console.WriteLine("1e numeral: " + RomanToInt(numeral1));
Console.WriteLine("2e numeral: " + RomanToInt(numeral2));

switch (symbol)
{
    case ("+"):
        Console.WriteLine("Uitvoering: toevoeging");
        Console.WriteLine(numeral1 + " " + symbol + " " + numeral2 + " = " + (RomanToInt(numeral1) + (RomanToInt(numeral2))));
        break;
    case ("-"):
        Console.WriteLine("Uitvoering: aftrekking");
        Console.WriteLine(numeral1 + " " + symbol + " " + numeral2 + " = " + (RomanToInt(numeral1) - (RomanToInt(numeral2))));
        break;
    case ("/"):
        Console.WriteLine("Uitvoering: deling");
        Console.WriteLine(numeral1 + " " + symbol + " " + numeral2 + " = " + (RomanToInt(numeral1) / (RomanToInt(numeral2))));
        break;
    case ("*"):
        Console.WriteLine("Uitvoering: vermenigvuldiging");
        Console.WriteLine(numeral1 + " " + symbol + " " + numeral2 + " = " + (RomanToInt(numeral1) * (RomanToInt(numeral2))));
        break;
}

int RomanToInt(string numeral)
{
    string[] thousands = { "MMM", "MM", "M" };
    string[] hundreds = { "CM", "DCCC", "DCC", "DC", "D", "CD", "CCC", "CC", "C" };
    string[] tens = { "XC", "LXXX", "LXX", "LX", "L", "XL", "XXX", "XX", "X" };
    string[] units = { "IX", "VIII", "VII", "VI", "V", "IV", "III", "II", "I" };

    int value = 0;
    int length = 0;

    for(int i = 0; i < 3; i++)
    {
        if (numeral.StartsWith(thousands[i]))
        {
            value += 1000 * (3 - i);
            length = thousands[i].Length;
            break;
        }
    }

    if(length > 0)
    {
        numeral = numeral.Substring(length);
        length = 0;
    }

    for (int i = 0; i < 9; i++)
    {
        if (numeral.StartsWith(hundreds[i]))
        {
            value += 100 * (9 - i);
            length = hundreds[i].Length;
            break;
        }
    }

    if (length > 0)
    {
        numeral = numeral.Substring(length);
        length = 0;
    }

    for (int i = 0; i < 9; i++)
    {
        if (numeral.StartsWith(tens[i]))
        {
            value += 10 * (9 - i);
            length = tens[i].Length;
            break;
        }
    }

    if (length > 0)
    {
        numeral = numeral.Substring(length);
        length = 0;
    }

    for (int i = 0; i < 9; i++)
    {
        if (numeral.StartsWith(units[i]))
        {
            value += 9 - i;
            length = units[i].Length;
            break;
        }
    }

    if (numeral.Length > length)
    {
        value = 0;
    }

    return value;
}