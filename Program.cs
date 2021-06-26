using System;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
namespace Get_ipaddress
{
    class Program
    {
        static void Main() => startProg();
        public static void startProg(){

             string server = Dns.GetHostName(); 

             Console.WriteLine(GetGateway.NetworkGateway());
           
             menuSelection.menuSelect(server);    //calls a method from menuselection class               
        }       
        
     }
    }

