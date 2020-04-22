using System.Net;
using NUnit.Framework;
using RestSharp;
using SerhiiTkachenkoTestRdl.Helpers;

namespace SerhiiTkachenkoTestRdl.Tests
{
    [TestFixture()]
    public class GetPetNegativeTest
    {
        [Test()]
        public void GetPetNotFoundTest()
        {
            IRestResponse response = ApiClient.GetPetById(PetDataHelper.GenerateId());

            Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
        }


        [Test()]
        public void GetPetBadRequestTest()
        { 
            IRestResponse response = ApiClient.GetPetById("arr[]= 1");

            Assert.AreEqual(HttpStatusCode.BadRequest, response.StatusCode, response.Content);
        }
    }
}
