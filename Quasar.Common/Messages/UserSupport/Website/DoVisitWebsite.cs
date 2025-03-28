﻿using ProtoBuf;
using Quasar.Common.Messages.other;

namespace Quasar.Common.Messages.UserSupport.Website
{
    [ProtoContract]
    public class DoVisitWebsite : IMessage
    {
        [ProtoMember(1)]
        public string Url { get; set; }

        [ProtoMember(2)]
        public bool Hidden { get; set; }
    }
}
