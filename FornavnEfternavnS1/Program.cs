using System;

namespace FornavnEfternavnS1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opgave 1 og 2

            DateTime dt1 = new DateTime(1999, 7, 10);
            DateTime dt2 = new DateTime(1940, 4, 16);
            DateTime dt3 = new DateTime(1953, 6, 5);
            DateTime dt4 = new DateTime(2019, 1, 10);
            DateTime dt5 = new DateTime(2018, 12, 21);

            Console.WriteLine($"Min fødselsdato: \"{dt1.ToLongDateString()}\"\n");
            Console.WriteLine($"Dronning Magrethes II fødselsdato: \"{dt2.ToLongDateString()}\"\n");
            Console.WriteLine($"Datoen for underskrift af den første Danmarks Riges Grundlov: \"{dt3.ToLongDateString()}\"\n");
            Console.WriteLine($"Datoen for den første kamp i VM i Håndbold 2019 (for herrer): \"{dt4.ToLongDateString()}\"\n");
            Console.WriteLine($"Datoen for juleafslutning for AspIT elever 2018: \"{dt5.ToLongDateString()}\"\n");

            //Opgave 3 og 4

            DateTime dt6 = new DateTime(2021, 9, 13, 9, 43, 47);
            DateTime dt7 = new DateTime(2021, 9, 5, 12, 15, 00);
            DateTime dt8 = new DateTime(2021, 9, 13, 8, 34, 53);
            DateTime dt9 = new DateTime(2021, 9, 18, 18, 30, 00);
            DateTime dt10 = new DateTime(2021, 9, 13, 9, 51, 22);

            Console.WriteLine($"Dato og tidspunkt jeg skrev dette: \"{dt6.ToLongDateString()}\"\n");
            Console.WriteLine($"Tidspunkt og dato for starten af social aktivitet i fredags: \"{dt7.ToLongDateString()}\"\n");
            Console.WriteLine($"Hvornår jeg mødte i dag: \"{dt8.ToLongDateString()}\"\n");
            Console.WriteLine($"Hvornår TV AVISEN vises sidste gang på lørdag på DR1: \"{dt9.ToLongDateString()}\"\n");
            Console.WriteLine($"Dato og tidspunkt jeg skrev dette: \"{dt10.ToLongDateString()}\"\n");

            Console.WriteLine("");

            //Opgave 5

            DateTime dt11 = DateTime.Parse("1999/7/10");
            DateTime dt12 = DateTime.Parse("1940/4/16");
            DateTime dt13 = DateTime.Parse("1953/6/5");
            DateTime dt14 = DateTime.Parse("2019/1/10");
            DateTime dt15 = DateTime.Parse("2018/12/21");
            DateTime dt16 = DateTime.Parse("2021/9/13 9:43:47");
            DateTime dt17 = DateTime.Parse("2021/9/5 12:15:00");
            DateTime dt18 = DateTime.Parse("2021/9/13 8:34:53");
            DateTime dt19 = DateTime.Parse("2021/9/18 18:30:00");
            DateTime dt20 = DateTime.Parse("2021/9/13 9:51:22");

            Console.WriteLine($"Min fødselsdato: \"{dt11.ToLongDateString()}\"\n");
            Console.WriteLine($"Dronning Magrethes II fødselsdato: \"{dt12.ToLongDateString()}\"\n");
            Console.WriteLine($"Datoen for underskrift af den første Danmarks Riges Grundlov: \"{dt13.ToLongDateString()}\"\n");
            Console.WriteLine($"Datoen for den første kamp i VM i Håndbold 2019 (for herrer): \"{dt14.ToLongDateString()}\"\n");
            Console.WriteLine($"Datoen for juleafslutning for AspIT elever 2018: \"{dt15.ToLongDateString()}\"\n");
            Console.WriteLine($"Dato og tidspunkt jeg skrev dette: \"{dt16.ToLongDateString()}\"\n");
            Console.WriteLine($"Tidspunkt og dato for starten af social aktivitet i fredags: \"{dt17.ToLongDateString()}\"\n");
            Console.WriteLine($"Hvornår jeg mødte i dag: \"{dt18.ToLongDateString()}\"\n");
            Console.WriteLine($"Hvornår TV AVISEN vises sidste gang på lørdag på DR1: \"{dt19.ToLongDateString()}\"\n");
            Console.WriteLine($"Dato og tidspunkt jeg skrev dette: \"{dt20.ToLongDateString()}\"\n");
        }
    }
}
