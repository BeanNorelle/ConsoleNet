using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text.RegularExpressions;
namespace Get_ipaddress
{
    class Program
    {
        static void Main(string[] args)
        {
           // listAddress.loadAddress();
          
          string server = Dns.GetHostName();
          Console.WriteLine("Hostname ............................ "+server);

            foreach(NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
            if(ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
            {
                Console.Write(ni.Name+" "+strDot(ni.Name.Length)+" ");
                foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                {
                    if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {   
                        Console.WriteLine(ip.Address.ToString());
                    }
                }
            }  
            }

            string strDot(int nLength){ 
                string line="";  for(int n=nLength;n<=35;n++){
                 line+=".";  
                }return line;}
        
             Console.ReadKey();
          
        }

        void ipaddress(string server){
               foreach(var s in listAddress.loadAddress(server)){
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("ScopeID............{0}",s.scopeId,Console.ForegroundColor);
                Console.WriteLine("Address............{0}",s.address);
                Console.WriteLine("Address Family.....{0}",s.addressFamily);
                Console.WriteLine("Address Bytes......{0}",s.getBytes);
                Console.WriteLine("Hashtype...........{0}",s.getHashCode);
                Console.WriteLine("Type...............{0}",s.getType);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(".............................................",Console.ForegroundColor);
            }
        }


    }
}
