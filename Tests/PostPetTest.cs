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
    public class PostPetTest
    {
        private int petId = 0;

        [Test()]
        [TestCaseSource(typeof(PostPetTestData), nameof(PostPetTestData.validPets))]
        public void PostPetPositiveTest(Pet pet, string testName)
        {
            petId = pet.Id;

            IRestResponse response = ApiClient.PostPet(pet);
            Pet responseContent = new JsonDeserializer().Deserialize<Pet>(response);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode, "incorrect status code");
            PetDataComparator.Compare(pet, responseContent);
        }

        [TearDown]
        public void Cleanup()
        {
            ApiClient.DeletePet(petId);
        }
    }
}
