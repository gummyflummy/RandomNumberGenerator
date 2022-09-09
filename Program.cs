using System;

namespace zufallszahl_erraten_David
{
    class Program
    {
        static void Main()
        {
            string weiterspielen = "ja";
            while (weiterspielen == "ja")
            {





                int Versuche = 0;
                int Zahl = new Random().Next(1, 100);
                Console.WriteLine("Eine Zahl wurde generiert");
                int Eingabe = 0;
                while (Eingabe != Zahl)
                {



                    try
                    {
                        Console.WriteLine("Gib nun eine Zahl zwischen 1 und 100 ein.");
                        Eingabe = Convert.ToInt32(Console.ReadLine());
                        if (Eingabe < 0 || Eingabe > 100)
                        {
                            throw new Exception();
                        }


                        if (Zahl == Eingabe)
                        {
                            Versuche = Versuche + 1;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Du hast die richtige Zahl erraten");
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Du hast " + Versuche + " Versuche gebraucht.");
                            Console.ResetColor();
                            
                            
                            Console.WriteLine("wollen sie nochmal spielen? ja oder nein");
                            weiterspielen = Convert.ToString(Console.ReadLine());
                            Console.ResetColor();



                        }
                        else
                        {
                            if (Zahl > Eingabe)
                            {
                                
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Versuche = Versuche + 1;
                                Console.WriteLine("Zu klein");
                                Console.ResetColor();
                            }
                            else
                            {
                                
                                Console.ForegroundColor = ConsoleColor.Red;
                                Versuche = Versuche + 1;
                                Console.WriteLine("Zu gross");
                                Console.ResetColor();
                            }
                        }
                    }
                    catch
                    {
                        
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("sehr lustig");
                        Console.ResetColor();
                    }

                }
            }
            
        } 
    }
}
