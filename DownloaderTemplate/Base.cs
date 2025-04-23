using System;
using System.Net;
using static System.Net.WebRequestMethods;

namespace ConsoleApp1
{
    public class Base
    {
        static void Main()
        {
            d();
        }
        static void d()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("-------------------------------");
                Console.WriteLine("1. Download iis Stupid Menu");
                Console.WriteLine("2. Download Fortnite Emote Wheel");
                Console.WriteLine("3. Download Aura Obfuscator");
                Console.WriteLine("4. Exit the application");
                Console.WriteLine("-------------------------------");
                Console.Write("Please enter your choice (1, 2, 3 or 4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        iidk();
                        break;
                    case "2":
                        iidk2();
                        break;
                    case "3":
                        aura();
                        break;
                    case "4":
                        exitapp();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Press Enter to try again.");
                        Console.ReadLine();
                        break;
                }
            }
        }
        static void iidk()
        {
            Console.WriteLine("ok now check the bin folder in the source for Downloader.");
            using (WebClient client = new WebClient())
            {
                string address = "https://github.com/iiDk-the-actual/iis.Stupid.Menu/releases/download/5.9.0/iis_Stupid_Menu.dll";
                string fileName = "iis Stupid Menu.dll";

                client.DownloadFile(address, fileName);
            }
            Console.WriteLine("File download! Press Enter to return to the main menu.");
            Console.ReadLine();
        }
        static void exitapp()
        {
            Environment.Exit(0);
        }
        static void iidk2()
        {
            Console.WriteLine("ok now check the bin folder in the source for DownloaderTemplate.");
            using (WebClient client = new WebClient())
            {
                string address = "https://github.com/iiDk-the-actual/FortniteEmoteWheel/releases/download/1.2.0/FortniteEmoteWheel.dll";
                string fileName = "FortniteEmoteWheel.dll";

                client.DownloadFile(address, fileName);
            }
            Console.WriteLine("File download! Press enter to return to the main menu.");
            Console.ReadLine();
        }
        static void aura()
        {
            Console.WriteLine("ok now check the bin folder in the source for DownloaderTemplate.");
            using (WebClient client = new WebClient())
            {
                string address = "https://github.com/loomisntreal/Aura-.NET-Obfuscator/archive/refs/heads/main.zip";
                string fileName = "Aura-.NET-Obfuscator-main.zip";

                client.DownloadFile(address, fileName);
            }
            Console.WriteLine("File download! Press enter to return to the main menu.");
            Console.ReadLine();
        }
    }
}