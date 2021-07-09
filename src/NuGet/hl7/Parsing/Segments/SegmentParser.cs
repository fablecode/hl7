using System.Collections.Generic;
using System.Linq;
using hl7.Core.Segments;

namespace hl7.Parsing.Segments
{
    public class SegmentParser : ISegmentParser
    {
        private readonly IEnumerable<ISegmentTypeParser> _segmentTypeParsers;

        public SegmentParser(IEnumerable<ISegmentTypeParser> segmentTypeParsers)
        {
            _segmentTypeParsers = segmentTypeParsers;
        }
        public ISegment Parse(string segment)
        {
            var segmentType = segment[..3];

            var handler = _segmentTypeParsers.Single(s => s.Handles(segmentType));

            return handler.Parse(segment);
        }
    }
}