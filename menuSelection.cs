using System;

namespace Get_ipaddress{
    public class menuSelection{

                //this method takes user input and returns in a switch method  
            public static void menuSelect(string server)
            {   
                    CommandList();
                while (true)
                {
                                   
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

                    case "D":  
                     CommandList();
                     Console.WriteLine("Input IP range:");
                     string IpRange = Console.ReadLine();
                     PingRange.pingRange(Convert.ToInt32(IpRange));
                     break;
                    
                    default: 
                     CommandList();
                     Console.WriteLine("Invalid entry"); 
                     break;
                }
                }   
                 void CommandList(){ Console.ForegroundColor = ConsoleColor.DarkYellow;   
                                Console.Clear();
                                Console.WriteLine("\n| 'A' - gethostnetwork | 'B' - Load Address  | 'C' - Get Net Interface | 'D' - Ping Ip Range |\n",Console.ForegroundColor);
                }            
            }
        }
}

    

