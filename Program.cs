using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batch_shield_deob
{
    internal class Program
    {
        static void banner()
        {
            Console.WriteLine(@"
__________         __         .__      _________.__    .__       .__       .___    ________         ________ ___.    
\______   \_____ _/  |_  ____ |  |__  /   _____/|  |__ |__| ____ |  |    __| _/    \______ \   ____ \_____  \\_ |__  
 |    |  _/\__  \\   __\/ ___\|  |  \ \_____  \ |  |  \|  |/ __ \|  |   / __ |      |    |  \_/ __ \ /   |   \| __ \ 
 |    |   \ / __ \|  | \  \___|   Y  \/        \|   Y  \  \  ___/|  |__/ /_/ |      |    `   \  ___//    |    \ \_\ \
 |______  /(____  /__|  \___  >___|  /_______  /|___|  /__|\___  >____/\____ |_____/_______  /\___  >_______  /___  /
        \/      \/          \/     \/        \/      \/        \/           \/_____/       \/     \/        \/    \/ 
                    By: https://github.com/imjzcodes/
");
        }
        static void Main(string[] args)
        {
            string filePath = args[0];
            string outputPath = args[1];

            string data = functions.ReadFile(filePath);
            string deobfuscated = functions.Deobfuscate(data);
            functions.WriteFile(outputPath, deobfuscated);
            banner();
            Console.WriteLine("Finished deobfuscating");
        }
    }
}
