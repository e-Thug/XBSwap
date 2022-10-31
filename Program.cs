using System;
using System.Diagnostics;
using Microsoft.Win32;

namespace XBSwap
{
    class disable
    {
        public static void Main()
        {
            Console.WriteLine("XBSwap by ASN\n");
            Console.WriteLine("Sign out of your XBL account before launching a game.");

            foreach (var process in Process.GetProcessesByName("GameBarFTServer"))
            {
                process.Kill();
            }
            foreach (var process0 in Process.GetProcessesByName("gamingservices"))
            {
                process0.Kill();
            }
            foreach (var process00 in Process.GetProcessesByName("GameBar"))
            {
                process00.Kill();
            }
            foreach (var process000 in Process.GetProcessesByName("gamingservicesnet.exe"))
            {
                process000.Kill();
            }
            Console.WriteLine("Processes Ended.");
            Thread.Sleep(500);
            const string userRoot = "HKEY_CURRENT_USER";
            const string subkey = "DisallowRun";
            const string keyName = userRoot + @"\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer\" + subkey;

            string key1 = ("GameBar.exe");
            Registry.SetValue(keyName, "1", key1);

            string key2 = ("GameBarFTServer.exe");
            Registry.SetValue(keyName, "2", key2);

            string key3 = ("gamingservices.exe");
            Registry.SetValue(keyName, "3", key3);
            Thread.Sleep(200);

            if (key1 != null) ;
            {
                Console.WriteLine($"{key1} Blocked");

            }
            Thread.Sleep(200);
            if (key2 != null) ;
            {
                Console.WriteLine($"{key2} Blocked");

            }
            Thread.Sleep(200);
            if (key3 != null) ;
            {
                Console.WriteLine($"{key3} Blocked");
            }
            Thread.Sleep(500);

            Console.WriteLine("\nOpen a Windows game.\nSign in when prompted.\n\nPress any key to clean up & close the console.");
            Console.ReadKey();


            string rkpath = @"\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun";

            using (RegistryKey drk =
                Registry.CurrentUser.OpenSubKey(rkpath, writable: true))
            {

                if (key1 != null)
                {
                    string key01 = ("");
                    Registry.SetValue(keyName, "1", key01);
                    Console.WriteLine("\nGamebar.exe Unblocked");
                }
                if (key2 != null)
                {
                    string key02 = ("");
                    Registry.SetValue(keyName, "2", key02);
                    Console.WriteLine("\nGameBarFTServer.exe Unblocked");
                }
                if (key3 != null)
                {
                    string key03 = ("");
                    Registry.SetValue(keyName, "3", key03);
                    Console.WriteLine("\ngamingservices.exe Unblocked\n\n");
                }
            }
            Thread.Sleep(450);
            Console.WriteLine("Exiting...");
            Thread.Sleep(250);
            Environment.Exit(0);
        }
    }
}
