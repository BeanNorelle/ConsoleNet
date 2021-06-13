using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System;

namespace Get_ipaddress{

public class listAddress{

     public static List<getIpaddress> loadAddress(string server){
         
   
         IPHostEntry heserver = Dns.GetHostEntry(server);
    
      
         List<getIpaddress> ipList = new List<getIpaddress>();

    try{
            foreach(IPAddress currAdd in heserver.AddressList){


                     Byte[] bytes = currAdd.GetAddressBytes(); string sBytes = "";
                            for (int i = 0; i < bytes.Length; i++){sBytes += bytes[i]; }



                ipList.Add(new getIpaddress{
                   addressFamily =  currAdd.AddressFamily.ToString(),
                   scopeId = currAdd.ScopeId.ToString(),
                   address = currAdd.ToString(),
                   getBytes= sBytes,
                    getType= currAdd.GetType().ToString(),
                   getHashCode = currAdd.GetHashCode().ToString(),
                });
                            
            }

    }
    catch (Exception e)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("[DoResolve] Exception: \n\n\n" + e.ToString(),Console.ForegroundColor);
                    }

         return ipList;

     }
        
}

}