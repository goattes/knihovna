Dictionary<string, bool> knihovna = new Dictionary<string, bool>();
knihovna.Add("123", true);
knihovna.Add("124", true);
knihovna.Add("125", true);
void Vypujcit(string kodKnihy)
{
    if (knihovna.ContainsKey(kodKnihy))
    {
        if (knihovna[kodKnihy] == false)
        {
            Console.WriteLine("Knihu si již někdo vypůjčil.");
        }
        else
        {
            Console.WriteLine("Vypůjčili jste si knihu ID: " + kodKnihy);
            knihovna[kodKnihy] = false;
        }
    }
}
void Vratit(string kodKnihy)
{
    if (knihovna.ContainsKey(kodKnihy))
    {
        if (knihovna[kodKnihy] == true)
        {
            Console.WriteLine("Kniha nebyla vypůjčena");
        }
        else
        {
            Console.WriteLine("Vrátili jste knihu ID: " + kodKnihy);
            knihovna[kodKnihy] = true;
        }
    }
}
void Zobrazit()
{
    Console.WriteLine("Stav našich knih:");
    foreach (var kniha in knihovna)
    {
        string stav = "neznámo";
        if (kniha.Value == false)
        {
            stav = "půjčeno";
        }
        else
        {
            stav = "k dispozici";
        }
        Console.WriteLine("Kód knihy: " + kniha.Key + "," + " Stav: " + stav);
    }
}
while (true)
{
    Console.WriteLine("Zadej příkaz.\n - VYPUJCIT [ID knihy]\n - VRATIT [ID knihy]\n - ZOBRAZIT");
    string[] pole;
    pole = Console.ReadLine().ToUpper().Split(" ");
    switch (pole[0])
    {
        case "VYPUJCIT":
            Vypujcit(pole[1]); 
            break;
        case "VRATIT":
            Vratit(pole[1]);
            break;
        case "ZOBRAZIT":
            Zobrazit();
            break;
        case "EXIT":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Neplatný příkaz.");
            break;
    }
}