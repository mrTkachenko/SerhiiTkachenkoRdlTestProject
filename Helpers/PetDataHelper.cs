using System;
using System.Linq;
using SerhiiTkachenkoTestRdl.Models;

namespace SerhiiTkachenkoTestRdl.Helpers
{
    public static class PetDataHelper
    {
        private static Random r = new Random();

        public static string GenerateText()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 10)
              .Select(s => s[r.Next(s.Length)]).ToArray());
        }

        public static int GenerateId()
        {
            return r.Next(0, 10000);
        }

        public static Category GenerateRandomValidCategory()
        {
            return new Category(GenerateId(), GenerateText());
        }

        public static Tag GenerateRandomValidTag()
        {
            return new Tag(GenerateId(), GenerateText());
        }
    }
}
