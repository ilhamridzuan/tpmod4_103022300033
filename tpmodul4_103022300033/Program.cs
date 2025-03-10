using System;

public class KodePos
{
    private static string[,] kodePos = {
        { "Batununggal", "40266" },
        { "Kujangsari", "40287" },
        { "Mengger", "40267" },
        { "Wates", "40256" },
        { "Cijaura", "40287" },
        { "Jatisari", "40286" },
        { "Margasari", "40286" },
        { "Sekejati", "40286" },
        { "Kebonwaru", "40272" },
        { "Maleer", "40274" },
        { "Samoja", "40273" }
    };

    public static string GetKodePos(string kelurahan)
    {
        for (int i = 0; i < kodePos.GetLength(0); i++)
        {
            if (kodePos[i, 0].Equals(kelurahan, StringComparison.OrdinalIgnoreCase))
            {
                return kodePos[i, 1];
            }
        }
        return "Kode pos tidak ditemukan";
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("--- TABLE DRIVEN ---");
        Console.Write("Masukkan nama kelurahan: ");
        string kelurahan = Console.ReadLine();

        string kodePos = KodePos.GetKodePos(kelurahan);
        Console.WriteLine($"Kode pos untuk {kelurahan} adalah: {kodePos}");

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}
