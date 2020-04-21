using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp;
using SerhiiTkachenkoTestRdl.Models;

namespace SerhiiTkachenkoTestRdl.Helpers
{
    public static class RequestHelper
    {
        public static RestRequest GetPetByIdRequest(int petId)
        {
            RestRequest request = new RestRequest(string.Format("v2/pet/{0}", petId), Method.GET);
            return request;
        }

        public static RestRequest PostPetByName(Pet pet)
        {
            RestRequest request = new RestRequest("v2/pet/", Method.POST);
            request.AddJsonBody(JsonConvert.SerializeObject(pet));
            return request;
        }

        public static RestRequest DeletePet(int petId)
        {
            RestRequest request = new RestRequest(string.Format("v2/pet/{0}", petId), Method.DELETE);

            return request;
        }
    }
}
