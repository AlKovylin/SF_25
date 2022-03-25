using System;
using System.Collections.Generic;
using System.Text;

namespace SF_25.PLL
{
    public class KeyReder
    {
        public string KeyRed()
        {
            ConsoleKeyInfo keyInfo;
            string command = "";

            do
            {
                keyInfo = Console.ReadKey();
                command += keyInfo.Key;

                if (keyInfo.Key == ConsoleKey.End)
                    break;
            }
            while (keyInfo.Key != ConsoleKey.Enter);



            return command;
        }
    }
}
