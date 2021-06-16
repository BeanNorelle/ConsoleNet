using System;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace Get_ipaddress
{
    public class getHostNetwork{

             public static void getIpPrint(string server)  { Console.ForegroundColor = ConsoleColor.Gray;
                 Console.WriteLine("Hostname ............................ "+server);

            foreach(NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces()){

                if(ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet){
      
                    Console.Write(ni.Name+" "+strDot(ni.Name.Length)+" ",Console.ForegroundColor);
                    
                    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses){
                        
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork){  

                            Console.WriteLine(ip.Address.ToString());}
                    }
                }  
            }

            string strDot(int nLength){     string line="";  

                for(int n=nLength;n<=35;n++){

                            line+=".";  

                }return line;}
            
             Console.ReadKey();
        }
    }
    
}