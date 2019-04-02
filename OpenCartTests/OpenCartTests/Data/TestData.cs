using OpenCartTests.Data.Models;

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
    }
}
