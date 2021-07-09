using System;
using hl7.Core.Messages;
using hl7.Parsing.Segments;

namespace hl7.Parsing.Messages
{
    public sealed class MessageParser
    {
        private readonly ISegmentParser _segmentParser;

        public MessageParser(ISegmentParser segmentParser)
        {
            _segmentParser = segmentParser;
        }

        public IHl7Message Parse(string message)
        {
            throw new NotImplementedException();
        }
    }
}