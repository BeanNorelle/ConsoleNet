using System;

namespace Get_ipaddress{
    public class menuSelection{
            public static void menuSelect(string server)
            {   
                Console.WriteLine("| 'A' - gethostnetwork | 'B' - | 'C' - clear |");
                while (true)
                {
                 //   CommandList();                    
                string swS = Console.ReadLine();
                switch(swS){
                    case "A":  
                    CommandList();
                    getHostNetwork.getIpPrint(server); break;
                    case "B":
                    CommandList();
                    LoadAddress.loadAddress(server); break;
                    case "C":
                     break;
                    //default: 
                    //CommandList();
                    //Console.WriteLine("Invalid entry"); 
                   // break;
                }
                }   
                 void CommandList(){ Console.ForegroundColor = ConsoleColor.DarkYellow;   
                                Console.Clear();
                                Console.WriteLine("| 'A' - gethostnetwork | 'B' - | 'C' - clear |",Console.ForegroundColor);
                }            
            }

        }
}

    

