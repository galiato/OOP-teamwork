namespace TheSmartPenguin
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class StartMenu
    {
        public static void Initialize()
        {

        }

        private static void Text()
        {
            StreamReader readerLogo = new StreamReader(@"..\..\ExternalFiles\logo.txt");
            using (readerLogo)
            {
                Console.WriteLine(readerLogo.ReadToEnd());
            }

            StreamReader readerSrartMenu = new StreamReader(@"..\..\ExternalFiles\startmenu.txt");
            using (readerSrartMenu)
            {
                Console.WriteLine(readerSrartMenu.ReadToEnd());
            }
        }
    }
}
