using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notes;

namespace UserXUnitTest
{
    public class UserTest
    {
        [Fact]
        public void Test1()
        {
            User user1 = new User();
            user1.Name= "Test";
            Assert.Equal("Test", user1.Name);
        }
    }
}