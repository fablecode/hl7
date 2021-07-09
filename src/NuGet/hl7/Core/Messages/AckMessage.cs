using hl7.Constants;

namespace hl7.Core.Messages
{
    public sealed class AckMessage : Hl7Message
    {
        public override string MessageType => MessageTypes.Ack;
    }
}