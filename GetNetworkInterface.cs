using System;
using System.Net.NetworkInformation;
using System.Linq;
using System.Threading;

namespace Get_ipaddress{
    public class GetNetworkInterface{
        public static void GetNetInterface(){
            Console.ForegroundColor = ConsoleColor.Gray; 

            //Retrive all network interface using GetAllNetworkInterface() method off NetworkInterface class.
            NetworkInterface [] niArr = NetworkInterface.GetAllNetworkInterfaces();

            Console.WriteLine("\nRetriving basic information of network...\n\n");
            //Display all information of NetworkInterface using foreach loop.

                    Thread.Sleep(1500);

                    ClearCurrentConsoleLine.ClearLine();
            try{
                
                foreach(NetworkInterface tempNetworkInterface in niArr)
                {   
                    Console.WriteLine("\n\nNetwork Description         :  " + tempNetworkInterface.Description);
                    Console.WriteLine("Network ID                  :  " + tempNetworkInterface.Id);
                    Console.WriteLine("Network Name                :  " + tempNetworkInterface.Name);
               
                    //this piece takes a Physical address and transorms it into a valid MAC format
                    string GetMac = (!String.IsNullOrEmpty(tempNetworkInterface.GetPhysicalAddress().ToString())) ? string.Join(":", Enumerable.Range(0, 6)
                    .Select(i => tempNetworkInterface.GetPhysicalAddress().ToString().Substring(i * 2, 2))) : "No Available Data"; 
                   
                    Console.WriteLine("Network Physical Address    :  " + GetMac);
                        Console.Write("Network IP                  :  " );
                     
                     //get ipaddress 
                      foreach (UnicastIPAddressInformation ip in tempNetworkInterface.GetIPProperties().UnicastAddresses){                        
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork){  

                            Console.Write(ip.Address.ToString()+"\n");}
                         }
                    Console.WriteLine("Network interface type      :  " + tempNetworkInterface.NetworkInterfaceType.ToString());
                    Console.WriteLine("Network Operational Status  :  " + tempNetworkInterface.OperationalStatus.ToString());

                    //get speed of network interface in millieseconds
                    string ToBytes =  (tempNetworkInterface.Speed==-1)? "No Available Data" : ((((long)tempNetworkInterface.Speed)/1024)/1000).ToString()+" MB/s";
                  
                    Console.WriteLine("Network Speed               :  " + ToBytes);
                    Console.WriteLine("Support Multicast           :  " + tempNetworkInterface.SupportsMulticast);
                              
                    }
                }
                catch{
                    Console.WriteLine("Cannot read");
                }
        }
    }
}