using System.Collections.Generic;
using hl7.Core.Segments;

namespace hl7.Core.Messages
{
    public interface IHl7Message
    {
        string MessageType { get; }
        LinkedList<Segment> Segments { get; init; }
    }
}