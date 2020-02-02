using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using FluentAssertions;
using Xunit;

namespace BootCamp.Chapter.Tests
{
    // You don't have to be here for a long time.
    public class Lesson7Tests
    {
        [Theory]
        [ClassData(typeof(TableMessageInput))]
        public void BuildTabledMessage_With_Message_Hello_AndPadding_0_Returns_Message_In_Table(string message, int padding, string expectation)
        {
            var result = TextTable.Build(message, padding);

            result.Should().Be(expectation);
        }


        [Theory]
        [ClassData(typeof(TableMessageInput))]
        public void FindHighestBalanceEver(string[] peopleAndBalances)
        {

        }

        [Theory]
        [ClassData(typeof(TableMessageInput))]
        public void FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {

        }

        [Theory]
        [ClassData(typeof(TableMessageInput))]
        public void FindRichestPerson(string[] peopleAndBalances)
        {

        }

        [Theory]
        [ClassData(typeof(TableMessageInput))]
        public void FindMostPoorPerson(string[] peopleAndBalances)
        {

        }
    }
}