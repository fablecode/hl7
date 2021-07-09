using System.Collections.Generic;
using hl7.Core.Segments;

namespace hl7.Core.Messages
{
    public abstract class Hl7Message : IHl7Message
    {
        public abstract string MessageType { get; }
        public LinkedList<Segment> Segments { get; init; }
    }
}