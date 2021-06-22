using System.Net.NetworkInformation;  
using System.Collections.Generic;
using System;
using System.Threading;

namespace Get_ipaddress{

    public class PingRange{

        public static void pingRange(int IpRange){

                Ping pingResponse = null;
                string canPing = "";
                string  pingAddress = "";

                Console.WriteLine("\n\nPinging Range of IP Address...");

                Thread.Sleep(1500);
                //Clear Console line "Pinging Range of IP Address . . ."
                Console.SetCursorPosition(0, Console.CursorTop - 1);
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
                             Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else
                        {
                            canPing = "Not Responsive";
                             Console.ForegroundColor = ConsoleColor.Red;
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