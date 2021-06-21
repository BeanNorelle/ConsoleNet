using System.Net.NetworkInformation;  
using System.Collections.Generic;
using System;
using System.Threading;

namespace Get_ipaddress{

    public class PingRange{

        public static bool PingHost(string nameOrAddress)
        {
            bool pingable = false;
            Ping pinger = null;
            
            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(nameOrAddress);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                // Discard PingExceptions and return false;
            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }

            return pingable;
        }

        public static void pingRange(){



                Ping pingResponse = null;
                string canPing = "";
                string  pingAddress = "";

                Console.WriteLine("\n\nPinging Range of IP Address . . .");

                Thread.Sleep(1500);
                
  //              Console.Clear();

                for(int i = 1;i<20;i++){
                    try
                    {
                        pingResponse = new Ping();
                        pingAddress = "192.168.1."+i.ToString();
                        PingReply reply = pingResponse.Send(pingAddress);

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

        }
    }

}