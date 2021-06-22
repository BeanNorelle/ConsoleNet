using System;
using System.Net;
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

