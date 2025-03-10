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


public class DoorMachine
{
    public enum State { Terkunci, Terbuka }
    private State currentState;

    public DoorMachine()
    {
        currentState = State.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    public void BukaPintu()
    {
        if (currentState == State.Terkunci)
        {
            currentState = State.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }
        else
        {
            Console.WriteLine("Pintu sudah terbuka");
        }
    }

    public void KunciPintu()
    {
        if (currentState == State.Terbuka)
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }
        else
        {
            Console.WriteLine("Pintu sudah terkunci");
        }
    }

    public State GetState()
    {
        return currentState;
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

        Console.WriteLine("--- STATE-BASED ---");
        DoorMachine door = new DoorMachine();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n==== Menu DoorMachine ====");
            Console.WriteLine("1. Buka Pintu");
            Console.WriteLine("2. Kunci Pintu");
            Console.WriteLine("3. Cek Status Pintu");
            Console.WriteLine("4. Keluar");
            Console.Write("Pilih opsi (1-4): ");

            string input = Console.ReadLine();
            Console.Clear();

            switch (input)
            {
                case "1":
                    door.BukaPintu();
                    break;
                case "2":
                    door.KunciPintu();
                    break;
                case "3":
                    Console.WriteLine(door.GetState() == DoorMachine.State.Terkunci ?
                        "Pintu terkunci" : "Pintu tidak terkunci");
                    break;
                case "4":
                    running = false;
                    Console.WriteLine("Terima kasih!");
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid. Silakan pilih lagi.");
                    break;
            }
        }
    }
}
