using System;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace Get_ipaddress{
    public class GetNetworkInterface{
        public static void GetNetInterface(){
            Console.ForegroundColor = ConsoleColor.Gray; 

            //Retrive all network interface using GetAllNetworkInterface() method off NetworkInterface class.
            NetworkInterface [] niArr = NetworkInterface.GetAllNetworkInterfaces();

            Console.WriteLine("Retriving basic information of network.\n\n");
            //Display all information of NetworkInterface using foreach loop.
            try{
                foreach(NetworkInterface tempNetworkInterface in niArr)
                {
                    Console.WriteLine("Network Description         :  " + tempNetworkInterface.Description);
                    Console.WriteLine("Network ID                  :  " + tempNetworkInterface.Id);
                    Console.WriteLine("Network Name                :  " + tempNetworkInterface.Name);
                    Console.WriteLine("Network interface type      :  " + tempNetworkInterface.NetworkInterfaceType.ToString());
                    Console.WriteLine("Network Operational Status  :  " + tempNetworkInterface.OperationalStatus.ToString());

                    string ToBytes =  (tempNetworkInterface.Speed==-1)? "No Available Data" : ((((long)tempNetworkInterface.Speed)/1024)/1000).ToString()+" MB/s";
                  
                    Console.WriteLine("Network Speed               :  " + ToBytes);
                    Console.WriteLine("Support Multicast           :  " + tempNetworkInterface.SupportsMulticast);
                    Console.Write("Network IP                  :  " );
                     
                     //get ipaddress 
                      foreach (UnicastIPAddressInformation ip in tempNetworkInterface.GetIPProperties().UnicastAddresses){                        
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork){  

                            Console.Write(ip.Address.ToString()+"\n\n");}
                         }
          
               
                }
            }
                catch{
                    Console.WriteLine("Cannot read");
                }
        }

    }
}