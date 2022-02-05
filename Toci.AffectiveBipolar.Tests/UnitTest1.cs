using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.AffectiveBipolar.Bll;
using Toci.AffectiveBipolar.Database.Persistence.Models;

namespace Toci.AffectiveBipolar.Tests
{
    [TestClass]
    public class UnitTest1
    {
        Logic<User> user = new Logic<User>();

        [TestMethod]
        public void TestMethod1()
        {
            user.Insert(new User()
            {
                Name = "Wiechu"
            });
        }
    }
}
