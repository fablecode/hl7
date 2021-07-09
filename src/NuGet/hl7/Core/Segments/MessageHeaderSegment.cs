using hl7.Constants;

namespace hl7.Core.Segments
{
    public sealed class MessageHeaderSegment: Segment
    {
        public override string SegmentType => SegmentTypes.MessageHeader;
        public char[] Delimiters { get; set; }
        public char FieldSeparator { get; init; }
        public char EncodingCharacters { get; init; }
        public string SendingApplication { get; init; }
        public string SendingFacility { get; init; }
    }
}