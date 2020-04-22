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
                    status: Enums.PetStatuses.available.ToString()
                    );

        public static Pet validPetEmptyTag = new Pet(id: PetDataHelper.GenerateId(),
                    name: PetDataHelper.GenerateText(),
                    category: PetDataHelper.GenerateRandomValidCategory(),
                    photoUrls: new List<string> { PetDataHelper.GenerateText() },
                    tags:new List<Tag> { },
                    status: Enums.PetStatuses.available.ToString()
                    );

        public static IEnumerable<TestCaseData> validPets
        {
            get
            {
                yield return new TestCaseData(validPet, "positive test all args");
                yield return new TestCaseData(validPetEmptyTag, "positive test empty tag");
                //yield return other cases, for example without some not
                //required parameters like tags (we will need to add more constructors to Pet
                //in this way)
            }
        }       
    }
}
