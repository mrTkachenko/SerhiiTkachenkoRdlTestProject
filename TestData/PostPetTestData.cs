using System.Collections.Generic;
using NUnit.Framework;
using SerhiiTkachenkoTestRdl.Helpers;
using SerhiiTkachenkoTestRdl.Models;

namespace SerhiiTkachenkoTestRdl.TestData
{
    public static class PostPetTestData
    {
        public static Pet validPet = new Pet(id: PetDataHelper.GenerateId(),
                    name: PetDataHelper.GenerateText(),
                    category: PetDataHelper.GenerateRandomValidCategory(),
                    photoUrls: new List<string> { PetDataHelper.GenerateText() },
                    tags: new List<Tag> { PetDataHelper.GenerateRandomValidTag() },
                    status: "available"
                    );

        public static IEnumerable<TestCaseData> validPets
        {
            get
            {
                yield return new TestCaseData(validPet, "positive test all args");
                //yield return other cases..
            }
        }       
    }
}
