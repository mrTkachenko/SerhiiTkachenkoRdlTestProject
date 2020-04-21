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
    public class GetPetTest
    {
        [Test()]
        public void GetPetPositiveTest()
        {
            //PrepareTestData
            Pet pet = new JsonDeserializer().Deserialize<Pet>(ApiClient.PostPet(PostPetTestData.validPet));

            IRestResponse response = ApiClient.GetPetById(pet.Id);
            Pet responseContent = new JsonDeserializer().Deserialize<Pet>(response);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode, "incorrect status code");
            PetDataComparator.Compare(pet, responseContent);

            //Do cleanup
            ApiClient.DeletePet(pet.Id);
        }

        [Test()]
        public void GetPetNotFoundTest()
        {
            IRestResponse response = ApiClient.GetPetById(PetDataHelper.GenerateId());

            Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}
