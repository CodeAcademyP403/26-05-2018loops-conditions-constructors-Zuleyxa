using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsHelpCommandList
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandLine commandLine = new CommandLine();

            bool Loop = true;
            while (commandLine.Name != "q")
            {
                commandLine.Name = Console.ReadLine();
                switch (commandLine.Name)
                {
                    case "help":Menu();
                        break;
                    case "dir":Console.WriteLine(Environment.CurrentDirectory);
                        break;
                    case "disks":Console.WriteLine(Environment.GetLogicalDrives());
                        break;
                    case "is64proc":Console.WriteLine(Environment.Is64BitOperatingSystem);
                        break;
                    case "macname":Console.WriteLine(Environment.MachineName);
                        break;
                    case "osdetail":Console.WriteLine(Environment.OSVersion);
                        break;
                    case "osplatform":Console.WriteLine(Environment.OSVersion.Platform);
                        break;
                    case "osversion":Console.WriteLine(Environment.OSVersion.Version);
                        break;
                    case "domname":Console.WriteLine(Environment.UserDomainName);
                        break;
                    case "username":Console.WriteLine(Environment.UserDomainName);
                        break;
                    case "osdir":Console.WriteLine(Environment.SystemDirectory);
                        break;
                    
                }
            }

        }

        static void Menu()
        {
            Console.WriteLine("dir - Enviroment.CurrentDirectory");
            Console.WriteLine("disks - Enviroment.GetLogicalDrives()");
            Console.WriteLine("is64proc - Enviroment.Is64BitOperatingSystem");
            Console.WriteLine("macname - Enviroment.MachineName");
            Console.WriteLine("osdetail - Enviroment.OSVersion");
            Console.WriteLine("osplatform - Enviroment.OSVersion.Platform");
            Console.WriteLine("osversion - Enviroment.OSVersion.Version");
            Console.WriteLine("domname - Enviroment.UserDomainNAme");
            Console.WriteLine("username - Enviroment.UserName");
            Console.WriteLine("osdir - Enviroment.SystemDirectory");

        }

    }

}
   


