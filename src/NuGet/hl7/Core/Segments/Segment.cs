namespace hl7.Core.Segments
{
    public abstract class Segment : ISegment
    {
        public abstract string SegmentType { get; }
    }
}