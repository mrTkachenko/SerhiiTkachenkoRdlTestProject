using System;
using System.Linq;
using NUnit.Framework;
using SerhiiTkachenkoTestRdl.Models;

namespace SerhiiTkachenkoTestRdl.Helpers
{
    public static class PetDataComparator
    {
        public static void Compare(Pet expected, Pet actual)
        {
            expected.Tags.AsEnumerable().OrderBy(tag => tag.Id);
            actual.Tags.AsEnumerable().OrderBy(tag => tag.Id);

            Assert.AreEqual(expected.Id, actual.Id, "incorrect pet id");
            Assert.AreEqual(expected.Name, actual.Name, "incorrect pet name");
            Compare(expected.Category, actual.Category);
            Assert.AreEqual(expected.Status, actual.Status);
            CollectionAssert.AreEqual(expected.PhotoUrls, actual.PhotoUrls,
                "incorrect photoUrls");

            for (int i=0;i <= expected.Tags.Count-1;i++)
            {
                Compare(expected.Tags[i], actual.Tags[i]);
            }
        }

        public static void Compare(Category expected, Category actual)
        {
            Assert.AreEqual(expected.Id, actual.Id, "incorrect category id");
            Assert.AreEqual(expected.Name, actual.Name, "incorrect category name");
        }

        public static void Compare(Tag expected, Tag actual)
        {
            Assert.AreEqual(expected.Id, actual.Id, "incorrect tag id");
            Assert.AreEqual(expected.Name, actual.Name, "incorrect tag name");
        }
    }
}
