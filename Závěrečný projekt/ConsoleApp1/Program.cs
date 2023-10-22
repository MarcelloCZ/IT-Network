namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--------------------");
            Console.WriteLine("Evidence pojištěných");
            Console.WriteLine("--------------------");

           
            char volba = '0';
            Evidence evidence = new Evidence();

            
            while (volba != '4')
            {
               
                Console.WriteLine("Vyberte si akci:");
                Console.WriteLine("1 - Přidat nového pojištěného");
                Console.WriteLine("2 - Vypsat všechny pojištěné");
                Console.WriteLine("3 - Vyhledat pojištěného");
                Console.WriteLine("4 - Konec");
                volba = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (volba)
                {
                    case '1':

                        Console.WriteLine("Zadejte jméno pojištěného:");
                        string jmeno;
                        while (string.IsNullOrWhiteSpace(jmeno = Console.ReadLine()) || !IsAlphaOnly(jmeno))
                        {
                            Console.WriteLine("Zadejte platné jméno (pouze písmena)");
                        }

                        Console.WriteLine("Zadejte příjmení pojištěného:");
                        string prijmeni;
                        while (string.IsNullOrWhiteSpace(prijmeni = Console.ReadLine()) || !IsAlphaOnly(prijmeni))
                        {
                            Console.WriteLine("Zadejte platné příjmení (pouze písmena)");
                        }
                        static bool IsAlphaOnly(string text)
                        {
                            return !string.IsNullOrEmpty(text) && text.All(char.IsLetter);
                        }

                        Console.WriteLine("Zadej věk pojištěného:");
                        int vek;
                        while (!int.TryParse(Console.ReadLine(), out vek))
                        {
                            Console.WriteLine("Zadej prosím číslo.");
                        }
                       
                        Console.WriteLine("Zadej telefonní číslo pojištěného:");
                        int telefon;
                        while (!int.TryParse(Console.ReadLine(), out telefon))
                        {
                            Console.WriteLine("Zadej prosím číslo.");
                        }
                        
                        
                        Pojistenec pojistenec = new Pojistenec(jmeno,prijmeni,telefon,vek);
                        evidence.PridejPojistence(pojistenec);
                        Console.WriteLine("Data byla uložena. Pokračujte libovolnou klávesou ...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '2':
                        
                        Console.WriteLine("Výpis pojištěných");
                        Console.WriteLine("--------------------");
                        evidence.Vypis();
                        Console.WriteLine();
                        Console.WriteLine("Pokračujte libovolnou klávesou ...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '3':
                      
                        Console.WriteLine("Zadejte jméno pojištěného:");
                        string jmenoSearch = Console.ReadLine();
                        Console.WriteLine("Zadejte příjmení pojištěného:");
                        string prijmeniSearch = Console.ReadLine();
                        Console.WriteLine("Evidence nalezených pojištěných:");
                        Console.WriteLine("--------------------");
                        
                        evidence.Vyhledat(jmenoSearch, prijmeniSearch);
                        Console.WriteLine();
                        Console.WriteLine("Pokračujte libovolnou klávesou ...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case '4':
                        Console.WriteLine("Děkuji za použití programu.");
                        Console.ReadKey();
                        break;   
                    default:
                        Console.WriteLine("Neplatná volba, zadejte prosím znovu.");
                        break;
                }
            }
        






        }
    }
}