// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Linq;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class Program
{
     List<String> users = new List<String>();
     List<string> Category = new List<string>();
    int film = 0;
    int dizi = 0;
    int frag = 0;

    static void Main(string[] args)

    {
        Program program = new Program();

        program.Run();

        



    }

    public void UserRegistration()
    {
        Console.WriteLine("Yeni kullanıcı ismini giriniz..");

        string user = Console.ReadLine();

       users.Add(user);
        Console.WriteLine("Kullanıcı başarılı bir şekilde eklendi..");
       

    }

   

    public void Run()
    {
        string choise = "";

        Console.WriteLine("Kullanıcı adını giriniz.");
        string nick = Console.ReadLine();


        if (users.Contains(nick))
        {
            Category.Add("Filmler ");
            Category.Add("Diziler ");
            Category.Add("Fragmanlar ");

            
                Console.WriteLine("Oylamak istediğiniz kategori için tuşlama yapınız; \n Filmler için 1\n Diziler için 2 \n Fragmanlar için 3'ü tuşalayınız..");
            

            choise = Console.ReadLine();
        }

        else
        {
            Console.WriteLine("Kullanıcı bulunamadı lütfen kayıt olun..");
            UserRegistration();
            Run();
        }

        switch (choise)
        {
            case "1":

                film += 1;

                break;
            case "2":

                dizi += 1;

                break;
            case "3":

                frag += 1;

                break;


            default:
                break;
        }
        

        Console.WriteLine($"Oylama sonuçları : \n Filmler {film}\n Diziler {dizi}\n Fragmanlar {frag} şeklindedir. ");

        var result = new List<Tuple<string, int>>

        {
            new Tuple<string, int>("Filmler ", film),
            new Tuple<string, int>("Diziler ", dizi),
            new Tuple<string, int>("Fragmanlar ", frag)
        };

        var winner = result.OrderByDescending(x => x.Item2).First();

        Console.WriteLine($"Kazanan kategori: {winner.Item1}");

    }

}

