using System;
using System.Net;

namespace Get_ipaddress{
    public class LoadAddress{       
          public static void loadAddress(string server){

               foreach(var s in listAddress.loadAddress(server)){
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("ScopeID             :  {0}",s.scopeId,Console.ForegroundColor);
                Console.WriteLine("Address             :  {0}",s.address);
                Console.WriteLine("Address Family      :  {0}",s.addressFamily);
                Console.WriteLine("Address Bytes       :  {0}",s.getBytes);
                Console.WriteLine("Hashtype            :  {0}",s.getHashCode);
                Console.WriteLine("Type                :  {0}",s.getType);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(".............................................\n\n",Console.ForegroundColor);
            } 
        }

    }
}