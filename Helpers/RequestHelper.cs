using Newtonsoft.Json;
using RestSharp;
using SerhiiTkachenkoTestRdl.Models;

namespace SerhiiTkachenkoTestRdl.Helpers
{
    public static class RequestHelper
    {
        public static RestRequest GetPetByIdRequest(int petId)
        {
            return new RestRequest(string.Format("v2/pet/{0}", petId), Method.GET);
        }

        public static RestRequest GetPetByIdRequest(string petId)
        {
            return new RestRequest(string.Format("v2/pet/{0}", petId), Method.GET);
        }

        public static RestRequest PostPetByName(Pet pet)
        {
            RestRequest request = new RestRequest("v2/pet/", Method.POST);
            request.AddJsonBody(JsonConvert.SerializeObject(pet));
            return request;
        }

        public static RestRequest DeletePet(int petId)
        {
            return new RestRequest(string.Format("v2/pet/{0}", petId), Method.DELETE);
        }
    }
}
