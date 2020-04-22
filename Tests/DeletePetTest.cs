using System.Net;
using NUnit.Framework;
using RestSharp;
using RestSharp.Serialization.Json;
using SerhiiTkachenkoTestRdl.Helpers;
using SerhiiTkachenkoTestRdl.Models;
using SerhiiTkachenkoTestRdl.TestData;

namespace SerhiiTkachenkoTestRdl.Tests
{
    public class DeletePetTest
    {
        //Parametrized test was shown by me in Post tests
        //In delete test I'm doing only one case
        [Test()]
        public void DeletePetPositiveTest()
        {
            //Prepare test data
            Pet pet = new JsonDeserializer().Deserialize<Pet>(ApiClient.PostPet(PostPetTestData.validPet));

            IRestResponse response = ApiClient.DeletePet(pet.Id);
            DeleteResponse responseContent = new JsonDeserializer().Deserialize<DeleteResponse>(response);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode, "incorrect status code");
            Assert.AreEqual(pet.Id.ToString(), responseContent.Message);
        }
    }
}
