namespace Numberguesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            int Versuche = 1;
            int spielen = Convert.ToInt32(1);

            do
            {
                
                
                
                    Console.Clear();
                try
                { 
                    int Zahl = new Random().Next(1, 100);
                    Console.Write("Erraten Sie die random Zahl zwischen 1-100:");
                    double eingabe = Convert.ToDouble(Console.ReadLine());
                    
                    
                    


                    while (eingabe != Zahl)
                    {



                        if (eingabe < Zahl)
                        {
                            Console.WriteLine("Die Zahl ist grösser!");

                        }
                        else
                        {
                            Console.WriteLine("Die Zahl ist kleiner!");
                            Versuche++;
                        }
                        Console.WriteLine("geben Sie nochmals eine Zahl ein");
                        eingabe = Convert.ToDouble(Console.ReadLine());
                    }
                    if (eingabe == Zahl)

                    {
                        Console.WriteLine("Sie haben gewonnen!");
                        Console.WriteLine("Versuche:"+Versuche);
                    }
                    Console.WriteLine("Willst du nochmals spielen? [true/false]");
               

                string erneut = Console.ReadLine();
                    if (erneut == "true")
                    {
                        spielen = Convert.ToInt32(1);
                    }
                    if (erneut == "false")
                    {
                        spielen = Convert.ToInt32(0);
                    }
                }
                catch
                {
                    Console.Write("Deine Eingabe ist ungültig!");
                    Console.WriteLine("Willst du nochmals spielen? [true/false]");


                    string erneut = Console.ReadLine();
                    if (erneut == "true")
                    {
                        spielen = Convert.ToInt32(1);
                    }
                    if (erneut == "false")
                    {
                        spielen = Convert.ToInt32(0);
                    }
                }

            } while (true);  
               
            

            

            

           


        }
    }
}