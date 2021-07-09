using System;
using hl7.Constants;
using hl7.Core.Segments;

namespace hl7.Parsing.Segments
{
    public class AdmitDischargeTransferSegmentParser : SegmentTypeParser
    {
        public override AdmitDischargeTransferSegment Parse(string segment)
        {
            return new();
        }
        public override bool Handles(string segment)
        {
            return GetSegmentType(segment).Equals(SegmentTypes.Adt, StringComparison.OrdinalIgnoreCase);
        }
    }
}