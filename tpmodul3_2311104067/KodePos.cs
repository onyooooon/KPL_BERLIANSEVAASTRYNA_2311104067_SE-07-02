using System;
using System.Collections.Generic;

class KodePos
{
    // Dictionary untuk menyimpan data kode pos berdasarkan kelurahan
    private static Dictionary<string, string> kodePosMap = new Dictionary<string, string>()
    {
        {"Batununggal", "40266"},
        {"Kujangsari", "40287"},
        {"Mengger", "40267"},
        {"Wates", "40256"},
        {"Cijaura", "40287"},
        {"Jatisari", "40286"},
        {"Margasari", "40286"},
        {"Sekejati", "40286"},
        {"Kebonwaru", "40272"},
        {"Maleer", "40274"},
        {"Samoja", "40273"}
    };

    // Method untuk mendapatkan kode pos berdasarkan kelurahan
    public static string GetKodePos(string kelurahan)
    {
        return kodePosMap.TryGetValue(kelurahan, out string kodePos) ? kodePos : "Kode pos tidak ditemukan";
    }

    // Method untuk menampilkan semua data dalam tabel
    public static void TampilkanSemuaKodePos()
    {
        Console.WriteLine("=================================");
        Console.WriteLine("|     Kelurahan    |  Kode Pos  |");
        Console.WriteLine("=================================");
        foreach (var entry in kodePosMap)
        {
            Console.WriteLine($"| {entry.Key,-15} | {entry.Value,-9} |");
        }
        Console.WriteLine("=================================");
    }
}