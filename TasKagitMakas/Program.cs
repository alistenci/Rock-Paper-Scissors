using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Taş\nKağıt\nMakas\nSeçiminizi Yapınız: ");
            Console.WriteLine("Çıkmak için 'exit' yazınız");
            string secim = Console.ReadLine()!.ToLower();
            if (secim == "exit")
            {
                Console.WriteLine("Oyunu sonlandırdınız.");
                break; // Döngüden çık
            }
            Oyun(secim);
        }
    }
    static string Oyun(string gonderilenDeger)
    {
        string sonuc;
        string[] secenekler = { "taş", "kağıt", "makas" };
        Random rnd = new Random();
        int dizi_no = rnd.Next(0, secenekler.Length);
            if ((secenekler[dizi_no] == "kağıt" && gonderilenDeger == "makas") || (secenekler[dizi_no] == "makas" && gonderilenDeger == "taş") || (secenekler[dizi_no] == "taş" && gonderilenDeger == "kağıt"))
            {
                sonuc = "Kazandınız";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Kazandınız, Sizin Seçiminiz {0} , Bilgisayarın Seçimi {1}", gonderilenDeger, secenekler[dizi_no]);
            Console.ResetColor(); // Renk ayarını sıfırla
        }
            else if ((secenekler[dizi_no] == "taş" && gonderilenDeger == "makas") || (secenekler[dizi_no] == "kağıt" && gonderilenDeger == "taş") || (secenekler[dizi_no] == "makas" && gonderilenDeger == "kağıt"))
            {
                sonuc = "Kaybettiniz";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Kaybettiniz Sizin Seçiminiz {0} , Bilgisayarın Seçimi {1}", gonderilenDeger, secenekler[dizi_no]);
            Console.ResetColor();
        }
        else if ((secenekler[dizi_no] == "taş" && gonderilenDeger == "taş") || (secenekler[dizi_no] == "kağıt" && gonderilenDeger == "kağıt") || (secenekler[dizi_no] == "makas" && gonderilenDeger == "makas"))
            {
                sonuc = "berabere";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Berabere Sizin Seçiminiz {0} , Bilgisayarın Seçimi {1}", gonderilenDeger, secenekler[dizi_no]);
            Console.ResetColor();
        }
        else
            {
                sonuc = "Hatalı";
                Console.WriteLine("Hatalı Seçim");

            }
            return sonuc;
    }
}