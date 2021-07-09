using hl7.Constants;

namespace hl7.Core.Segments
{
    public sealed class AdmitDischargeTransferSegment : Segment
    {
        public override string SegmentType => SegmentTypes.Adt;
    }
}