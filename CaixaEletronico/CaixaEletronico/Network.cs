using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Fleyhe.Network
{

    public class Request {

        public static string Host = "localhost";
        public static int Port = 3030;

        public string Event;
        public string[] response;

        public Request (string evnt, object[] args)
        {

            TcpClient tcp = new TcpClient(Host, Port);
            StreamWriter writer = new StreamWriter(tcp.GetStream());
            StreamReader reader = new StreamReader(tcp.GetStream());

            writer.WriteLine(evnt.Normalize());
            writer.WriteLine(args.Length.ToString());

            foreach( object arg in args)
            {
                writer.WriteLine(arg.ToString().Normalize());
            }

            this.Event = reader.ReadLine().Normalize();
            int count =  int.Parse(reader.ReadLine());
            this.response = new String[count];
            for (int i = 0; i < count; i++)
            {
                response[i] = reader.ReadLine().Normalize();
            }

        }


    }

}
