using FluentAssertions;
using hl7.Parsing.Segments;
using NUnit.Framework;

namespace hl7.Unit.Tests.CoreTests.SegmentsTests.MessageHeaderSegmentTests
{
    [TestFixture]
    public sealed class ParseTests
    {
        private MessageHeaderSegmentParser _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = new MessageHeaderSegmentParser();
        }

        [TestCase("MSH|^~\\&", new[] { '|', '^', '~', '\\', '&', })]
        [TestCase("MSH#^~\\&", new[] { '#', '^', '~', '\\', '&', })]
        [TestCase("MSH$^~\\&", new[] { '$', '^', '~', '\\', '&', })]
        public void Given_A_MessageHeader_Segment_Should_Parse_Segment_And_Initialize_Delimiters(string segment, char[] expected)
        {
            // Arrange
            // Act
            var result = _sut.Parse(segment);

            // Assert
            result.Delimiters.Should().BeEquivalentTo(expected);
        }

    }
}