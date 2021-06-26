using System.Net.NetworkInformation;  
using System.Collections.Generic;
using System;
using System.Threading;

namespace Get_ipaddress{

    public class PingRange{

        public static void pingRange(int IpRange){
             //this method get an IP range in 'n' from user input and iterates over 'n' times sends a ping for each iteration.

                Ping pingResponse = null;
                string canPing = "";
                string  pingAddress = "";

                Console.WriteLine("\n\nPinging Range of IP Address...");

                Thread.Sleep(1500);
                ClearCurrentConsoleLine.ClearLine();
                
                int IpCount = 0;

                for(int i = 1;i<=IpRange;i++){
                    try
                    {
                        pingResponse = new Ping();
                        pingAddress = "192.168.1."+i.ToString();
                        PingReply reply = pingResponse.Send(pingAddress);
                        IpCount++;
                        
                        if(reply.Status == IPStatus.Success){
                            canPing = "Responsive";
                             Console.ForegroundColor = ConsoleColor.Green; //change color to indicates states of success 
                        }
                        else
                        {
                            canPing = "Not Responsive";
                             Console.ForegroundColor = ConsoleColor.Red;//change color to indicates states of fail
                        } 

                        Console.WriteLine("Ping Address: {0}    :  {1}",pingAddress,canPing,Console.ForegroundColor);
       
                    }
                    catch(PingException)
                    {
                        Console.WriteLine("Error on Ping.cs pingrange");
                    }
                    finally
                    {
                        if(pingResponse!=null) pingResponse.Dispose();
                         Console.ForegroundColor = ConsoleColor.Yellow;
                        
                    }                
                }    
                   Console.WriteLine("\nFinished Pinging {0} address", IpCount);   
        }    
    }
}