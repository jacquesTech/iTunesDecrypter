using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace idecrypter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string predefinedVerification = "gsmadjaa";
            if (args.Length == 3)
            {
                string backupPath = args[0];
                string password = args[1];
                string verification = args[2];


                if (verification == predefinedVerification)
                {
                    if (!string.IsNullOrWhiteSpace(backupPath))
                    {
                        Console.WriteLine("Backup Path: " + backupPath);
                        Console.WriteLine("Password: " + password);

                        finishBackup(backupPath, password);
                    }
                    else
                    {
                        Console.WriteLine("Backup path cannot be empty.");
                    }
                }
                else
                {
                    Console.WriteLine("Verification failed. Please provide the correct verification value.");
                }
            }
            else
            {
             
                Console.WriteLine("Check instructions");
            }

        }


        
        public static void finishBackup(string path , string password)
        {
            string filePath = "data.txt";
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                File.Create(filePath).Close();
            }

            string keyfolderbk = path;

           code.decrypt(keyfolderbk, password , new Version(12, 3, 0));

        }
    }
}
