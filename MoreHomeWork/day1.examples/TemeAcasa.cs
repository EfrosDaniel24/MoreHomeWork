using System;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main()
    {
        // a) Citirea unei liste de numere de la tastatură și salvarea într-un array
        Console.WriteLine("Introduceți o listă de numere (separate prin spațiu):");
        string input = Console.ReadLine();

        // Împărțim string-ul la spații și convertim fiecare parte în număr real
        string[] parts = input.Split(' ');
        double[] numbers = new double[parts.Length];

        for (int i = 0; i < parts.Length; i++)
        {
            if (double.TryParse(parts[i], NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
            {
                numbers[i] = number;
            }
            else
            {
                Console.WriteLine($"Nu am putut converti '{parts[i]}' în număr.");
            }
        }

        // b) Parcurgerea array-ului și afișarea numerelor care nu sunt întregi
        Console.WriteLine("Numere care nu sunt întregi:");
        foreach (double number in numbers)
        {
            if (number % 1 != 0)
            {
                Console.WriteLine(number);
            }
        }

        // c) Căutarea și afișarea celui mai mic număr fără să folosim Math.Min
        if (numbers.Length > 0)
        {
            double minNumber = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
            }

            Console.WriteLine($"Cel mai mic număr este: {minNumber}");
        }
        else
        {
            Console.WriteLine("Nu au fost introduse numere.");
        }
    }
}
