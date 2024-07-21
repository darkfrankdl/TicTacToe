using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InterfaceAdapterLayer;
namespace AllTest.InterfaceAdapterLayerTests
{
    public class InterFaceAdapterTests
    {

        [Fact]
        public void CreatePlayerTest_expect_sucess ()
        {
            // arrange
            string playerName = "Joe";
            int playerNumber = 1;
            InterfaceAdapter ifa = new InterfaceAdapter ();

            // act
            bool success = ifa.CreatePlayer(playerName, playerNumber);

            // arrange
            Assert.True(success);
        }

        [Fact]
        public void PlayerToDTOTest_expect_failure()
        {
            Action action = () => throw new Exception("Failure");
            Assert.Throws<Exception>(action);
        }
    }
}
