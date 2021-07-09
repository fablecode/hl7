using hl7.Core.Segments;

namespace hl7.Parsing.Segments
{
    public interface ISegmentTypeParser
    {
        bool Handles(string segment);
        ISegment Parse(string segment);
    }
}