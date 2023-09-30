using Algorithms.Strings;
using NUnit.Framework;

namespace Algorithms.Tests.Strings
{
    public static class KnuthMorrisPrattSearcherTests
    {
        [Test]
        public static void FindIndexes_ItemsPresent_PassExpected()
        {
            // Arrange
            var str = "ABABAcdeABA";
            var pat = "ABA";

            // Act
            var expectedItem = new[] { 0, 2, 8 };
            var actualItem = KnuthMorrisPrattSearcher.FindIndexes(str, pat);

            // Assert
            CollectionAssert.AreEqual(expectedItem, actualItem);
        }

        [Test]
        public static void FindIndexes_ItemsMissing_NoIndexesReturned()
        {
            // Arrange
            var str = "ABABA";
            var pat = "ABB";

            // Act & Assert
            var indexes = KnuthMorrisPrattSearcher.FindIndexes(str, pat);

            // Assert
            Assert.IsEmpty(indexes);
        }

        [Test]
        public static void LongestPrefixSuffixArray_PrefixSuffixOfLength1_PassExpected()
        {
            // Arrange
            var s = "ABA";

            // Act
            var expectedItem = new[] { 0, 0, 1 };
            var actualItem = KnuthMorrisPrattSearcher.FindLongestPrefixSuffixValues(s);

            // Assert
            CollectionAssert.AreEqual(expectedItem, actualItem);
        }

        [Test]
        public static void LongestPrefixSuffixArray_PrefixSuffixOfLength5_PassExpected()
        {
            // Arrange
            var s = "AABAACAABAA";

            // Act
            var expectedItem = new[] { 0, 1, 0, 1, 2, 0, 1, 2, 3, 4, 5 };
            var actualItem = KnuthMorrisPrattSearcher.FindLongestPrefixSuffixValues(s);

            // Assert
            CollectionAssert.AreEqual(expectedItem, actualItem);
        }

        [Test]
        public static void LongestPrefixSuffixArray_PrefixSuffixOfLength0_PassExpected()
        {
            // Arrange
            var s = "AB";

            // Act
            var expectedItem = new[] { 0, 0 };
            var actualItem = KnuthMorrisPrattSearcher.FindLongestPrefixSuffixValues(s);

            // Assert
            CollectionAssert.AreEqual(expectedItem, actualItem);
        }
    }
}
