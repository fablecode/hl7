using hl7.Core.Segments;

namespace hl7.Parsing.Segments
{
    public abstract class SegmentTypeParser : ISegmentTypeParser
    {
        public abstract bool Handles(string segment);

        public abstract ISegment Parse(string segment);

        protected string GetSegmentType(string segment) => segment[..3];
    }
}