using System;

namespace Get_ipaddress{
    public class menuSelection{
            public static void menuSelect(string server)
            {   
                    CommandList();
                while (true)
                {
                 //   CommandList();                    
                string swS = Console.ReadLine();
                switch(swS){
                    case "A":  
                    CommandList();
                     break;
                    case "B":
                    CommandList();
                    LoadAddress.loadAddress(server); break;
                    case "C":
                     CommandList();
                     GetNetworkInterface.GetNetInterface();
                     break;
                    
                    default: 
                     CommandList();
                     Console.WriteLine("Invalid entry"); 
                     break;
                }
                }   
                 void CommandList(){ Console.ForegroundColor = ConsoleColor.DarkYellow;   
                                Console.Clear();
                                Console.WriteLine("\n| 'A' - gethostnetwork | 'B' - Get Net Inteface| 'C' - clear |\n",Console.ForegroundColor);
                }            
            }

        }
}

    

