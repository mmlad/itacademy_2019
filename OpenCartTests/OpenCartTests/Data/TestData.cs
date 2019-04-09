using OpenCartTests.Data.Models;
using OpenCartTests.Utils;

namespace OpenCartTests.Data
{
    public static class TestData
    {
        public static User User
        {
            get
            {
                return new User("demo", "demo");
            }
        }

        public static string UserFullName
        {
            get
            {
                return "demo demo";
            }
        }

        public static string UsernameDefaultValue
        {
            get
            {
                return "demo";
            }
        }

        public static string RandomString(int length)
        {
            return StringHelper.GenerateRandomString(length);
        }

    }
}
