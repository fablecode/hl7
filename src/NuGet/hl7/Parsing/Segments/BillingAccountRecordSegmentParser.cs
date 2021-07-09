using System;
using hl7.Constants;
using hl7.Core.Segments;

namespace hl7.Parsing.Segments
{
    public class BillingAccountRecordSegmentParser : SegmentTypeParser
    {
        public override BillingAccountRecordSegment Parse(string segment)
        {
            return new();
        }
        public override bool Handles(string segment)
        {
            return GetSegmentType(segment).Equals(SegmentTypes.Bar, StringComparison.OrdinalIgnoreCase);
        }
    }
}