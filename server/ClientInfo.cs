﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace server
{
    internal class ClientInfo
    {
        public int Id { get; set; }
        public TcpClient TcpClient { get; set; }
        public string Name { get; set; }
        public int RoomId { get; set; }
        public string ClientState { get; set; }
        public string RandomWordInClientInfo { get; set; }

    }
}
