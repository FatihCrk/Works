using System;
using MyDictionaryWork;

namespace MyDictionaryWork
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDicClass<int, string, string> users = new MyDicClass<int, string, string> { };
            users.Add(1, "Fatih", "Çırak");
            users.Add(3, "Gülben", "KARAASLAN");
            users.Add(3, "Yekta", "ÇIRAK");

            Console.WriteLine("Sistemde " + users.Length + " kullanıcı vardır.");
            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine(users.personIds[i] + " " + users.personNames[i] + " " + users.personSurnames[i]);
            }


            Console.WriteLine("Sistemdeki Kullanıcı IDleri");
            foreach (var id in users.personIds)
            {
                Console.WriteLine(id);
            }



            Console.WriteLine("Sistemdeki Kullanıcı İsimleri");
            foreach (var name in users.personNames)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Sistemdeki kullanıcıların Soyisim");
            foreach (var surName in users.personSurnames)
            {
                Console.WriteLine(surName);
            }

        }
    }
}
