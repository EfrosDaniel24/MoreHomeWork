using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // a) Citirea a 3 nume de persoane de la tastatură
        Console.WriteLine("Introduceți 3 nume de persoane (separate prin enter):");

        string[] names = new string[3];
        for (int i = 0; i < names.Length; i++)
        {
            Console.Write($"Numele {i + 1}: ");
            names[i] = Console.ReadLine();
        }

        // b) Afișarea caracterelor care apar în fiecare nume și de câte ori apar
        foreach (var name in names)
        {
            Console.WriteLine($"\nCaracteristicile numelui '{name}':");
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in name.ToLower()) // Convertim la litere mici pentru a ignora diferențele de caz
            {
                if (char.IsLetter(c)) // Numărăm doar caracterele literale
                {
                    if (charCount.ContainsKey(c))
                    {
                        charCount[c]++;
                    }
                    else
                    {
                        charCount[c] = 1;
                    }
                }
            }

            foreach (var kvp in charCount)
            {
                Console.WriteLine($"Caracterul '{kvp.Key}' apare de {kvp.Value} ori");
            }
        }
    }
}

