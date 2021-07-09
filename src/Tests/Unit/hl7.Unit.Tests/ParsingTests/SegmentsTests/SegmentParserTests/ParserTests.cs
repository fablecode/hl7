using System;
using FluentAssertions;
using hl7.Core.Segments;
using hl7.Parsing.Segments;
using NUnit.Framework;

namespace hl7.Unit.Tests.ParsingTests.SegmentsTests.SegmentParserTests
{
    [TestFixture]
    public class ParserTests
    {
        private ISegmentParser _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = new SegmentParser(new ISegmentTypeParser []
            {
                new MessageHeaderSegmentParser(),
                new AdmitDischargeTransferSegmentParser(),
                new BillingAccountRecordSegmentParser()
            });
        }

        [TestCase("MSH", typeof(MessageHeaderSegment))]
        [TestCase("ADT", typeof(AdmitDischargeTransferSegment))]
        [TestCase("BAR", typeof(BillingAccountRecordSegment))]
        public void Given_A_Segment_Should_Parse_Segment_To_Correct_SegmentType(string segment, Type type)
        {
            // Arrange
            // Act
            var result = _sut.Parse(segment);

            // Assert
            result.Should().BeOfType(type);
        }

    }
}
