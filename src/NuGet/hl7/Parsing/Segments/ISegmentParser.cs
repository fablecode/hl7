using hl7.Core.Segments;

namespace hl7.Parsing.Segments
{
    public interface ISegmentParser
    {
        ISegment Parse(string segment);
    }
}