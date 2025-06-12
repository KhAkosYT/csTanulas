using System;

public class Program
{

    public static bool EldontesTetel(int x)
    {
        if (x % 2 == 1)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public static void Main(string[] args)
    {
        /*
        Taroljuk egy tombben egy biciklis futar kulonbozo kezbesitesei soran megtett tavolsagait!
        Megtett tavolsagok: 2, 4, 7, 3, 9 km
        Hatarozza meg a program, hogy
            - osszesen hany km-t tett meg a futar,
            - atlagosan hany km-t tett meg a futar,
            - hanyszor ment 5 km-nél tobbet,
            - hany km volt tavolsagban a legrovidebb es a leghosszabb utja
            - volt-e olyan utja a futarnak, ahol 10km-nel tavolabbra kellett mennie,
            - hany forintot kap kiszallitasonkent a futar, ha km-ként 700 Ft a dijazas
         */

        /*
        int[] utak = { 2, 4, 7, 3, 9 };

        int osszeg = 0;
        for (int i = 0; i < utak.Length; i++) {
            osszeg += utak[i];
        }

        int osszeg2 = 0;
        int db = 0;
        double atlag = 0;
        for (int i = 0; i < utak.Length; i++) { 
            osszeg2 += utak[i];
            db++;
        }
        atlag = (double) osszeg2 / db;
        Console.WriteLine(atlag);
        */
        //majd befejezed


        int[] ints = new int[] { 2, 4, 6, 8, 16, 32, 64, 128, 256 };

        int i = 0;
        while ((i < ints.Length) && (!EldontesTetel(ints[i])))
        {
            i++;
        }
        bool volt = i < ints.Length;

        if (volt)
        {
            Console.WriteLine("Volt páratlan szám a tömbben");
        }
        else
        {
            Console.WriteLine("Nincs páratlan szám a tömbben");
        }

    }

}