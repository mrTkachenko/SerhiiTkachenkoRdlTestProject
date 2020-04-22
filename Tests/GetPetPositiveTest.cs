using System.Net;
using NUnit.Framework;
using RestSharp;
using RestSharp.Serialization.Json;
using SerhiiTkachenkoTestRdl.Helpers;
using SerhiiTkachenkoTestRdl.Models;
using SerhiiTkachenkoTestRdl.TestData;

namespace SerhiiTkachenkoTestRdl.Tests
{
    [TestFixture()]
    public class GetPetPositiveTest
    {
        private Pet petUnderTest;

        [SetUp]
        public void PrepareData()
        {
            petUnderTest = new JsonDeserializer().Deserialize<Pet>(ApiClient.PostPet(PostPetTestData.validPet));
        }

        [Test()]
        public void GetPetTest()
        {
            IRestResponse response = ApiClient.GetPetById(petUnderTest.Id);
            Pet responseContent = new JsonDeserializer().Deserialize<Pet>(response);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode, "incorrect status code");
            PetDataComparator.Compare(petUnderTest, responseContent);
        }

        [TearDown]
        public void Cleanup()
        {
            ApiClient.DeletePet(petUnderTest.Id);
        }
    }
}
