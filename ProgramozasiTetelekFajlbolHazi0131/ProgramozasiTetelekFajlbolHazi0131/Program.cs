//using System;

//public class Program{
//    public static void Main(string[] args)
//    {
//        int[] legyartottBiciklikSzama = new int[100];
//        int esz = 0;

//        try
//        {
//            //0. feladat
//            StreamReader olvaso = new StreamReader("gyartasi_adatok.txt");

//            string sor = olvaso.ReadLine();
//            while (sor != null){
//                if(int.TryParse(sor, out int szam)){
//                    legyartottBiciklikSzama[esz] = szam;
//                    sor = olvaso.ReadLine();
//                }
//                esz++;
//            }
//            olvaso.Close();


//            //1. feladat: Határozza meg a program, hogy összesen hány bicikli került legyártásra!
//            int osszeg = 0;
//            for (int i = 0; i < esz; i++) {
//                osszeg += legyartottBiciklikSzama[i];
//            }
//            Console.WriteLine($"1. feladat: {osszeg} db bicikli kerult legyartasra");


//            //2. feladat: Határozza meg a program, hogy átlagosan hány bicikli került legyártásra havonta,
//            //ha csak a 100-as darabszám feletti hónapokat vesszük figyelembe!
//            int szazFelettiGyartasokSzama = 0; //osszesiti a 100 feletti erteket
//            int szazFelettiAlkalmak= 0;//tarolja a 100 feletti alkalmak szamat
//            for (int i = 0; i < esz; i++) {
//                if (legyartottBiciklikSzama[i] > 100){
//                    szazFelettiGyartasokSzama += legyartottBiciklikSzama[i];
//                    szazFelettiAlkalmak++;
//                }
//            }
//            double atlag = szazFelettiGyartasokSzama / (double) szazFelettiAlkalmak;
//            Console.WriteLine($"2. feladat: {szazFelettiAlkalmak} alkalommal volt 100-tol nagyobb, osszeguk {szazFelettiGyartasokSzama}, atlaguk {atlag:F2}");


//            //3. feladat: Határozza meg a program, hogy hány olyan hónap volt, amikor 250-nél több bicikli került legyártásra!
//            int kettootvenFelettiAlkalmak = 0;
//            for (int i = 0; i < esz; i++){
//                if (legyartottBiciklikSzama[i] > 250){
//                    kettootvenFelettiAlkalmak++;
//                }
//            }
//            Console.WriteLine($"3. feladat: {kettootvenFelettiAlkalmak} honap volt, ahol tobb biciklit gyartottak 250-nel");


//            //4. feladat: Határozza meg a program, hogy hanyadik hónapban került legyártásra a legtöbb bicikli a fájl tartalma alapján!
//            int max = 0;
//            int max_honap = 0;

//            for (int i = 0; i < esz; i++){
//                if(max < legyartottBiciklikSzama[i]){
//                    max = legyartottBiciklikSzama [i];
//                    max_honap = i + 1;
//                }
//            }

//            Console.WriteLine($"4. feladat: {max_honap}. honapban gyartottak a legtobb biciklit ({max} db)");


//            //5. feladat: Határozza meg a program, hogy mennyi a legkisebb legyártott darabszám!
//            int min = int.MaxValue;
//            int min_honap = 0;

//            for (int i = 0; i < esz; i++)
//            {
//                if (min > legyartottBiciklikSzama[i])
//                {
//                    min = legyartottBiciklikSzama[i];
//                    min_honap = i + 1;
//                }
//            }
//            Console.WriteLine($"5. feladat: {min} db bicikli volt a legkevesebb, amit legyartottak ({min_honap}. honap)");

//            //6. feladat: Határozza meg a program, hogy volt-e olyan hónap amikor leállás volt, azaz
//            //a legyártott biciklik száma 120 vagy az alatt volt!
//            bool volt = false;
//            for (int i = 0; i < esz; i++) { 
//                if (legyartottBiciklikSzama[i] <= 120) {  
//                    volt = true; 
//                }
//            }

//            if (volt){
//                Console.WriteLine("6. feladat: Volt olyan hónap, amikor volt leallas");
//            }

//            //7. feladat: Határozza meg a program, hogy havi lebontásban mennyi bevétel keletkezett, ha egy bicikli ára 56342 Ft!
//            const int bicikliAra = 56342;
//            Console.WriteLine("7. feladat");
//            for (int i = 0; i < esz; i++) {
//                Console.WriteLine($"\t{i + 1}. honapban a bevetel: {legyartottBiciklikSzama[i] * bicikliAra}");
//                //Itt mar nem csinaltam uj tombot, mint javaban
//            }

//        }
//        catch (IOException e)
//        {
//            Console.WriteLine("Hiba történt a gyartasi_adatok.txt fajl beolvasasa soran: " + e.Message);
//        }
//    }
//}



using System;

public class Program
{
    public static double CalculateAverageGrade(int[] grades)
    {
        double sum = 0;
        foreach (var grade in grades) {
            sum += grade;
        }
        return sum / grades.Length;
        // Write your code here
    }

    public static void Main(string[] args)
    {
        string text = Console.ReadLine();
        string[] stringArr = text.Split(",");
        int[] studentGrades = new int[stringArr.Length];
        for (int i = 0; i < stringArr.Length; i++)
        {
            studentGrades[i] = int.Parse(stringArr[i]);
        }
        double averageGrade = CalculateAverageGrade(studentGrades);
        Console.WriteLine($"Average grade: {averageGrade:F2}");
    }
}