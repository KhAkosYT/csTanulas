using System;

class Program{

    public static int osszeg(int[] x){
        int osszeg = 0;

        for (int i = 0; i < x.Length; i++) {
            osszeg += x[i];
        }

        return osszeg;
    }


    public static int kilencvenEsSzazKozott(int[] x){
        int kilencvenEsSzazKozottDB = 0;

        for(int i = 0; i < x.Length; i++){
            if(  (90 <= x[i]) && (x[i] <= 100)){
                kilencvenEsSzazKozottDB++;

            }
        }

        return kilencvenEsSzazKozottDB;
    }

    public static bool van100as(int[] x){

        for(int i = 0; i < x.Length; i++){
            if (x[i] == 100){
                return true;
            }
        }

        return false;
    }

    public static int minimum(int[] x){
        int min = x[0];

        for (int i = 1; i < x.Length; i++) { 
            if(min > x[i]){
                min = x[i];
            }
        }

        return min;
    }

    public static int maximum(int[] x)
    {
        int max= x[0];

        for (int i = 1; i < x.Length; i++){
            
            if (max < x[i]){
                max = x[i];
            }
        
        }

        return max;
    }

    public static int legnagyobb75es125kozott(int[] x){
        int legnagyobb = x[74];

        for (int i = 75; i < 125; i++) {
            if (legnagyobb < x[i]) {
                legnagyobb = x[i];
            }
        }
        return legnagyobb;

    }

    public static void oszthato5teles7tel(int[] x){
        Console.Write("6. f.: 5-tel es 7-tel oszthato szamok a tombben: ");
        for (int i = 0; i < x.Length; i++){
            if(  (x[i] % 5 == 0) && (x[i] % 7 == 0)){
                Console.Write(x[i] + " ");
            }
        }
        Console.WriteLine();
    }

    public static void parosSzamok(int[] x){
        for (int i = 0; i < x.Length; i++) { 
            if(x[i] % 2 == 0){
                Console.Write(x[i] + " ");
            }
        }
        Console.WriteLine();
    }

    public static void paratlanSzamok(int[] x)
    {
        for (int i = 0; i < x.Length; i++){
            if (x[i] % 2 == 1){
                Console.Write(x[i] + " ");
            }
        }
        Console.WriteLine();
    }

    public static void tombKiiratasa(int[] x)
    {
        for (int i = 0; i < x.Length; i++)
        {
            Console.Write(x[i] + " ");
        }
        Console.WriteLine();
    }

    /*


    Írj programot, amelyben létrehozol egy 150 elemű, egész számokból álló tömböt!
    A tömböt a program véletlenszerűen töltse fel [50; 150] közötti egész számokkal!
        1- Határozza meg a program a számok összegét és átlagát! Az átlagot 3 tizedesjegy pontossággal írja ki a program!
        2- Határozza meg a program, hogy hány [90; 100] közötti szám van a tömbben!    
        3- Döntse el a program, hogy a tömbben megtalálható-e a 100-as szám!
        4- Határozza meg a program hogy mi a legnagyobb és a legkisebb szám a tömbben!
        5- Határozza meg a program, hogy 75. és a 125. elem között mi a legnagyobb szám!

        6- Válogassa ki és írja ki egy sorba a program azokat a számokat, amelyek oszthatóak 5-tel és 7-tel is!
        7- Válogassa ki a program a páros és páratlan számokat! Írja ki a program külön-külön
                sorokba ezeket, a számokat szóközzel elválasztva!
        8- Rendezd a számokat növekvő sorrendbe buborékos rendezés algoritmusával!


     */

    public static void Main(String[] args){
        int[] tomb = new int[150];
        Random rnd = new Random();

        for (int i = 0; i < tomb.Length; i++){
            tomb[i] = rnd.Next(101) + 50;
        }

        //1.
        Console.WriteLine($"1. f.: A tombelemek osszege: {osszeg(tomb)}, atlaguk: {(osszeg(tomb) / (double) tomb.Length):F3}");

        //2.
        Console.WriteLine($"2. f.: {kilencvenEsSzazKozott(tomb)} db szam van ami legalabb 90 es legfeljebb 100");


        //3.
        if (van100as(tomb)){
            Console.WriteLine("3. f.: Megtalalhato a tombben a 100-as szam!");
        }
        else{
            Console.WriteLine("3. f.: Nem talalhato meg a tombben a 100-as szam!");
        }

        //4.
        Console.WriteLine($"4. f.: A tombelemek kozott a legkisebb {minimum(tomb)}, a legnagyobb {maximum(tomb)}");

        //5.
        Console.WriteLine($"5. f.: A legnagyobb szam 75 es 125 kozott: {legnagyobb75es125kozott(tomb)}");

        //6.
        oszthato5teles7tel(tomb);

        //7.
        Console.WriteLine("7. f.: ");
        Console.Write("\tParos szamok: ");
        parosSzamok(tomb);
        
        Console.Write("\tParatlan szamok: ");
        paratlanSzamok(tomb);

        //8.
        /*
        Console.WriteLine("sort elott");
        tombKiiratasa(tomb);
        */

        for (int i = tomb.Length - 1; i >= 0; i--) {
            for (int j = 0; j < i; j++) {
                if (tomb[j] > tomb[j + 1]){
                    int seged = tomb[j];
                    tomb[j] = tomb[j + 1];
                    tomb[j +1] = seged;
                }
            }
        }

        /*
        Console.WriteLine("sort utan");
        tombKiiratasa(tomb);
        */
    }
}