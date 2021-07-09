using System;
using System.Linq;
using hl7.Constants;
using hl7.Core.Segments;

namespace hl7.Parsing.Segments
{
    public class MessageHeaderSegmentParser : SegmentTypeParser
    {
        public override MessageHeaderSegment Parse(string segment)
        {
            var message = new MessageHeaderSegment();

            message.Delimiters = segment.Skip(3).Take(5).ToArray();

            return message;
        }

        public override bool Handles(string segment)
        {
            return GetSegmentType(segment).Equals(SegmentTypes.MessageHeader, StringComparison.OrdinalIgnoreCase);
        }

    }
}