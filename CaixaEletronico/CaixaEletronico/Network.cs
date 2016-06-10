using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Fleyhe.Network
{

    public class Listener
    {

    }

    public class Bridge
    {

    }

    public class Event
    {
        public static Hashtable hash = new Hashtable();

        public static void GenerateHash()
        {
            List<Object> lista = new List<Object>();
            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                foreach (var type in asm.GetTypes())
                {
                    if (type.BaseType == typeof(Event))
                    {
                        lista.Add(type);
                    }
                        
                }
            }

            for(int i = 0; i < lista.ToArray().Length; i++){
                Console.WriteLine(lista.ToArray()[i].ToString());
            }
        }
    }

    class Testezinho : Event
    {

    }
}
