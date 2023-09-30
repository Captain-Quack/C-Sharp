using Algorithms.Search;
using NUnit.Framework;
using Utilities.Exceptions;

namespace Algorithms.Tests.Search
{
    public static class FastSearcherTests
    {
        [Test]
        public static void FindIndex_ItemPresent_IndexCorrect()
        {
            var arr = Helper.GetSortedArray(1000);
            var present = Helper.GetItemIn(arr);
            var index = FastSearcher.FindIndex(arr, present);
            Assert.AreEqual(present, arr[index]);
        }

        [TestCase(new[] { 1, 2 }, 1)]
        [TestCase(new[] { 1, 2 }, 2)]
        [TestCase(new[] { 1, 2, 3, 3, 3 }, 2)]
        public static void FindIndex_ItemPresentInSpecificCase_IndexCorrect(int[] arr, int present)
        {
            var index = FastSearcher.FindIndex(arr, present);
            Assert.AreEqual(present, arr[index]);
        }

        [Test]
        public static void FindIndex_ItemMissing_ItemNotFoundExceptionThrown()
        {
            var arr = Helper.GetSortedArray(1000);
            var missing = Helper.GetItemNotIn(arr);
            _ = Assert.Throws<ItemNotFoundException>(() => FastSearcher.FindIndex(arr, missing));
        }

        [TestCase(new int[0], 2)]
        public static void FindIndex_ItemMissingInSpecificCase_ItemNotFoundExceptionThrown(int[] arr, int missing)
        {
            _ = Assert.Throws<ItemNotFoundException>(() => FastSearcher.FindIndex(arr, missing));
        }

        [Test]
        public static void FindIndex_ItemSmallerThanAllMissing_ItemNotFoundExceptionThrown()
        {
            var arr = Helper.GetSortedArray(1000);
            var missing = Helper.GetItemSmallerThanAllIn(arr);
            _ = Assert.Throws<ItemNotFoundException>(() => FastSearcher.FindIndex(arr, missing));
        }

        [Test]
        public static void FindIndex_ItemBiggerThanAllMissing_ItemNotFoundExceptionThrown()
        {
            var arr = Helper.GetSortedArray(1000);
            var missing = Helper.GetItemBiggerThanAllIn(arr);
            _ = Assert.Throws<ItemNotFoundException>(() => FastSearcher.FindIndex(arr, missing));
        }

        [Test]
        public static void FindIndex_ArrayOfDuplicatesItemPresent_IndexCorrect()
        {
            var arr = new int[1000];
            var present = 0;
            var index = FastSearcher.FindIndex(arr, present);
            Assert.AreEqual(0, arr[index]);
        }

        [Test]
        public static void FindIndex_ArrayOfDuplicatesItemMissing_ItemNotFoundExceptionThrown()
        {
            var arr = new int[1000];
            var missing = 1;
            _ = Assert.Throws<ItemNotFoundException>(() => FastSearcher.FindIndex(arr, missing));
        }
    }
}
