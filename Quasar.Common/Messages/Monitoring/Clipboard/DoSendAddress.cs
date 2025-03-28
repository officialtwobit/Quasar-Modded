﻿using ProtoBuf;
using Quasar.Common.Messages.other;

namespace Quasar.Common.Messages.Monitoring.Clipboard
{
    [ProtoContract]
    public class DoSendAddress : IMessage
    {
        [ProtoMember(1)]
        public string Address { get; set; }
    }
}
