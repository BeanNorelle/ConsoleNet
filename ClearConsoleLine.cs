using System;

namespace Get_ipaddress{

public class ClearCurrentConsoleLine{


        public static void ClearLine()
                {
                    int currentLineCursor = Console.CursorTop;
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.Write(new string(' ', Console.WindowWidth)); 
                    Console.SetCursorPosition(0, currentLineCursor);
                }

    }

}