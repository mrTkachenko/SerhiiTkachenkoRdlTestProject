using RestSharp;
using SerhiiTkachenkoTestRdl.Models;

namespace SerhiiTkachenkoTestRdl.Helpers
{
    /*In case of "bigger" framework it would be better to create "Clients" folder
    with all clients classes (in case "http://petstore.swagger.io/#/"
    it will be PetClient, StoreClient, UserClient etc..)

    But in current case we're working only with 3 methods so we'll put all 
    we need into the current class*/
    public static class ApiClient
    {
        private static RestClient petClient = new RestClient(ConfigHelper.GetConfigParameterByKey("apiLink"));

        public static IRestResponse GetPetById(int petId)
        {
            RestRequest request = RequestHelper.GetPetByIdRequest(petId);
            return petClient.Execute(request);
        }

        public static IRestResponse PostPet(Pet pet)
        {
            RestRequest request = RequestHelper.PostPetByName(pet);
            return petClient.Execute<Pet>(request);
        }

        public static IRestResponse DeletePet(int id)
        {
            RestRequest request = RequestHelper.DeletePet(id);
            return petClient.Execute(request);
        }
    }
}