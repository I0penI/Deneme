namespace Deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Burçlar");
            int ay;
            int gun;
            Console.Write("Lütfen Doğduğunuz Ayı Giriniz: ");
            ay = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen Doğduğunuz Günü Giriniz: ");
            gun = Convert.ToInt32(Console.ReadLine());
            
            if ((ay == 1 && gun <= 21 && gun <= 31 && gun >= 1) || (ay == 12 && gun >= 22 && gun <= 31))
            {
                Console.WriteLine("Oğlak");
            }
            else if ((ay == 2 && gun <= 19 && gun >= 1) || (ay == 1 && gun >= 22 && gun <= 31))
            {
                Console.WriteLine("Kova");
            }
            else if ((ay == 3 && gun <= 20 && gun >= 1) || (ay == 2 && gun >= 20 && gun <= 29))
            {
                Console.WriteLine("Balık");
            }
            else if ((ay == 4 && gun <= 20 && gun >= 1) || (ay == 3 && gun >= 21 && gun <= 31))
            {
                Console.WriteLine("Koç");
            }
            else if ((ay == 5 && gun <= 21 && gun >= 1) || (ay == 4 && gun >= 21 && gun <= 30))
            {
                Console.WriteLine("Boğa");
            }
            else if ((ay == 6 && gun <= 22 && gun >= 1)|| (ay == 5 && gun >= 22 && gun <= 31))
            {
                Console.WriteLine("İkizler");
            }
            else if( (ay == 7 && gun <= 22 && gun >= 1) || (ay == 6 && gun >= 23 && gun <= 30))
            {
                Console.WriteLine("Yengeç");
            }
            else if ((ay == 8 && gun <= 23 && gun >= 1)|| (ay == 7 && gun >= 22 && gun <= 31))
            {
                Console.WriteLine("Aslan");
            }
            else if ((ay == 9 && gun <= 22 && gun >= 1) || (ay == 8 && gun >= 23 && gun <= 31))
            {
                Console.WriteLine("Başak");
            }
            else if ((ay == 10 && gun <= 22 && gun >= 1) || (ay == 9 && gun >= 23 && gun <= 30))
            {
                Console.WriteLine("Terazi");
            }
            else if ((ay == 11 && gun <= 21 && gun >= 1) || (ay == 10 && gun >= 23 && gun <= 31))
            {
                Console.WriteLine("Akrep");
            }
            else if ((ay == 12 && gun <= 21 && gun >= 1) || (ay == 11 && gun >= 22 && gun <= 30))
            {
                Console.WriteLine("Yay");
            }
            else
            {
                Console.WriteLine("Adam Akıllı Değer Gir");
            }
            Console.ReadLine();

        }
    }
}