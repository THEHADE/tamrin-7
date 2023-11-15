//amir hemmati
// tamrin 7
// p.s: zamin marg 
using System;
using System.ComponentModel;

List<students> student = new List<students>();
 
StreamReader slist = new StreamReader(@"C:\Users\uvhvy\source\repos\tamrin 7\tamrin 7");
while (!slist.EndOfStream)
{
    string line = slist.ReadLine();
    students students = new students();
    students.Name = line.Split(',')[0];
    students.Fname = line.Split(',')[1];
    students.pishrafte1 = Convert.ToDouble(line.Split(',')[2]);
    students.pishrafte2 = Convert.ToDouble(line.Split(',')[3]);
    students.tafsir = Convert.ToDouble(line.Split(',')[4]);
    students.riazi = Convert.ToDouble(line.Split(",")[5]);
    students.kargah = Convert.ToDouble(line.Split(',')[6]);
    students.zaban = Convert.ToDouble(line.Split(',')[7]);
    students.shgarayi = Convert.ToDouble(line.Split(',')[8]);
    students.tarbiatbadani = Convert.ToDouble(line.Split(',')[9]);
    students.sys = Convert.ToDouble(line.Split(',')[10]);
    students.algorythm = Convert.ToDouble(line.Split(',')[11]);
    student.Add(students);

}


Console.WriteLine("salam , be system khosh amadid");
Console.WriteLine("amaliat morede nazar ra entekhab konid:");
Console.WriteLine("1.namayesh asami/nomarat");
Console.WriteLine("2.moadel kol");
Console.WriteLine("3.moadel doros normal");
Console.WriteLine("4.moadel doros * dar");
Console.WriteLine("5.moadel doros ** dar");
Console.WriteLine("6.nomarate noe aval");
Console.WriteLine("7.namayesh 4 moadel");
Console.WriteLine("8.grid");
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("shomare:");
int x = Convert.ToInt32(Console.ReadLine());
switch (x)
{
    case 1: 
        Console.WriteLine(slist.ReadLine());
        break;
        case 2:
        Console.WriteLine("moadel kol:");
        foreach (var students in student)
        {
           Console.WriteLine(students.TotalAverage());
        }break;
    case 3:
        Console.WriteLine("moadel doros normal:");

        foreach (var students in student)
        {
            Console.WriteLine(students.TotalAverage());
        }
        break;
    case 4:
        Console.WriteLine("moadel doros * dar:");

        foreach (var students in student)
        {

            Console.WriteLine(students.takaverage());
        }break;
    case 5:
        Console.WriteLine("moadel doros ** dar:");
        foreach (var students in student)
        {
            Console.WriteLine(students.Doaverage());
        }break;
    case 6:
        foreach (var students in student)
        {
            Console.WriteLine(students.Name + ":");
            Console.WriteLine();

            if (students.PrimeNum(students.pishrafte1) == true)
            { Console.WriteLine("pishrafte1:" + " " + students.pishrafte1); }

            if (students.PrimeNum(students.tafsir) == true)
            { Console.WriteLine("tafsir:" + " " + students.tafsir); }

            if (students.PrimeNum(students.riazi) == true)
            { Console.WriteLine("riazi:" + " " + students.riazi); }

            if (students.PrimeNum(students.kargah) == true)
            { Console.WriteLine("kargah:" + " " + students.kargah); }

            if (students.PrimeNum(students.zaban) == true)
            { Console.WriteLine("zaban:" + " " + students.zaban); }
            
            if (students.PrimeNum(students.pishrafte2) == true)
            { Console.WriteLine("pishrafte2:" + " " + students.pishrafte2); }

            if (students.PrimeNum(students.shgarayi) == true)
            { Console.WriteLine("sheygarayi:" + " " + students.shgarayi); }

            if (students.PrimeNum(students.tarbiatbadani) == true)
            { Console.WriteLine("tarbiat badani:" + " " + students.tarbiatbadani); }

            if (students.PrimeNum(students.sys) == true)
            { Console.WriteLine("system amel:" + " " + students.sys); }

            if (students.PrimeNum(students.algorythm) == true)
            { Console.WriteLine("algoritm:" + " " + students.algorythm); }
           
        }break;
    case 7:
        Console.WriteLine("moadel kol:");
        foreach (var students in student)
        {
            Console.WriteLine(students.TotalAverage());
        }
        
        Console.WriteLine("moadel doros normal:");
        
        foreach (var students in student)
        {
            Console.WriteLine(students.TotalAverage());
        }

        Console.WriteLine("moadel doros * dar:");

        foreach (var students in student)
        {

            Console.WriteLine(students.takaverage());
        }

        Console.WriteLine("moadel doros ** dar:");

        foreach (var students in student)
        {
            Console.WriteLine(students.Doaverage());
        }
        break;


}





















// کلاس دانشجوها و نمرات
class students
{
    public string Name { get; set; }
    public string Fname { get; set; }
    public double pishrafte1 { get; set; }
    public double pishrafte2 { get; set; }
    public double tafsir { get; set; }
    public double riazi { get; set; }
    public double kargah { get; set; }
    public double zaban { get; set; }
    public double shgarayi { get; set; }
    public double tarbiatbadani { get; set; }
    public double sys { get; set; }
    public double algorythm { get; set; }

    public double TotalAverage()
    {
        return ((pishrafte1 * 3) + (pishrafte2 * 3) + (shgarayi * 3) + (sys * 3) + (algorythm * 3) + (riazi * 2) + (zaban * 2) + (tafsir) + kargah + tarbiatbadani) / 22;
    }

    public double Doaverage()
    {
        return ((pishrafte1 * 3) + (pishrafte2 * 3) + (shgarayi * 3)) / 9;
    }

    public double takaverage()
    {
        return ((sys * 3) + (algorythm * 3)) / 6;
    }
    public double average()
    {
        return ((riazi * 2) + (zaban * 2) + (tafsir) + kargah + tarbiatbadani) / 7;
    }
    public bool PrimeNum(double num)
    {
        int sum = 0;
        if (num == 0) return false;
        else
        {
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + 1;
                }
            }
            if (sum == 2) return true;
            else return false;
        }

    }
}


