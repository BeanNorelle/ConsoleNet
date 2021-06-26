using System;

namespace Get_ipaddress{
    public class menuSelection{

              private static void CommandList(string server){ Console.ForegroundColor = ConsoleColor.DarkYellow;   
                                Console.Clear();
               Console.WriteLine("Hostname: {0}", server);
               Console.WriteLine("Gateway:  {0}", GetGateway.NetworkGateway());
               Console.WriteLine("\n| 'X' - Exit App | 'B' - Load Address  | 'C' - Get Net Interface | 'D' - Ping Ip Range |\n",Console.ForegroundColor);
               
                }  

                //this method takes user input and returns in a switch method  
            public static void menuSelect(string server)
            {   
                    CommandList(server);
                while (true)
                {
                                   
                string swS = Console.ReadLine();
                switch(swS){
                    case "X":  
                    Environment.Exit(0); //application exits clean
                     break;
                    case "B":
                    CommandList(server);
                    LoadAddress.loadAddress(server); break;

                    case "C":
                     CommandList(server);
                     GetNetworkInterface.GetNetInterface();
                     break;

                    case "D":  
                     CommandList(server);
                     Console.WriteLine("Input IP range:");
                     string IpRange = Console.ReadLine();
                     PingRange.pingRange(Convert.ToInt32(IpRange));
                     break;
                    
                    default: 
                     CommandList(server);
                     Console.WriteLine("Invalid entry"); 
                     break;
                }
                }   
                        
            }
        }
}

    

