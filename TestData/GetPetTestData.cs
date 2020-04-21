using System;
using System.Collections.Generic;
using System.Net;
using NUnit.Framework;
using SerhiiTkachenkoTestRdl.Helpers;

namespace SerhiiTkachenkoTestRdl.TestData
{
    public static class GetPetTestData
    {
        public static IEnumerable<TestCaseData> invalidIds
        {
            get
            {
                yield return new TestCaseData(PetDataHelper.GenerateId(),
                    HttpStatusCode.NotFound, "not existing id");
                yield return new TestCaseData(Int64.Parse(""),
                    HttpStatusCode.NotFound, "empty");
            }
        }
    }
}
