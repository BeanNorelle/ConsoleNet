using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text.RegularExpressions;
namespace Get_ipaddress
{
    class Program
    {
        static void Main() => startProg();
        public static void startProg(){

             string server = Dns.GetHostName();
             
             menuSelection.menuSelect(server);
                    
        }

        
     }


    }

