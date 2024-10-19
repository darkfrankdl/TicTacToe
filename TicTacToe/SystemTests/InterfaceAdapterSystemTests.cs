using InterfaceAdapterLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemTests
{
    public class InterfaceAdapterSystemTests
    {
        [Fact]
        public void TestCreateBoard()
        {
            // arrange
            InterfaceAdapter adapter = new InterfaceAdapter();
            // act
            bool isSucess = adapter.CreateBoard();
            // Assert
            Assert.True(isSucess);
        }

        [Fact]
        public void TestCreatePlayer_ExpectTrue()
        {
            // arrange
            InterfaceAdapter interfaceAdapter = new InterfaceAdapter();
            string playerName = "Joe";
            int playerNumber = 1;
            bool succesStatus = false;
            // act 
            succesStatus = interfaceAdapter.CreatePlayer(playerName, playerNumber);
            // assert
            Assert.True(succesStatus);
        }

        [Fact]
        public void TestCreatePlayer_ExpectFalse()
        {
            // arrange
            InterfaceAdapter interfaceAdapter = new InterfaceAdapter();
            string playerName = "Joe";
            int playerNumber = 3;
            bool succesStatus = false;
            // act 
            succesStatus = interfaceAdapter.CreatePlayer(playerName, playerNumber);
            // assert
            Assert.False(succesStatus);
        }

        [Fact]
        public void TestGetPlayer_ExpectNotNull()
        {
            // arrange
            InterfaceAdapter interfaceAdapter = new InterfaceAdapter();
            int playerNumberToGet = 1;
            string playerName = "Joe";
            int playerNumber1 = 1;
            interfaceAdapter.CreatePlayer(playerName, playerNumber1);
            // act 
            DTOPlayer player = interfaceAdapter.GetPlayer(playerNumberToGet);
            // assert
            Assert.NotNull(player);
        }

        [Fact]
        public void TestGetPlayer_ExpectNull()
        {
            // arrange
            InterfaceAdapter interfaceAdapter = new InterfaceAdapter();
            int playerNumber = 3;
            // act 
            DTOPlayer player = interfaceAdapter.GetPlayer(playerNumber);
            // assert
            Assert.Null(player);
        }

        [Fact]
        public void TestMakeMoveX_ExpectTrue()
        {
            // arrange
            InterfaceAdapter interfaceAdapter = new InterfaceAdapter();
            string XorO = "X";
            int xPos = 0;
            int yPos = 0;
            interfaceAdapter.CreateBoard();
            // act 
            bool success = interfaceAdapter.MakeMoveXorO(XorO, xPos, yPos);
            // assert
            Assert.True(success);
        }

        [Fact]
        public void TestMakeMoveO_ExpectTrue()
        {
            // arrange
            InterfaceAdapter interfaceAdapter = new InterfaceAdapter();
            string XorO = "O";
            int xPos = 0;
            int yPos = 0;
            interfaceAdapter.CreateBoard();
            // act 
            bool success = interfaceAdapter.MakeMoveXorO(XorO, xPos, yPos);
            // assert
            Assert.True(success);
        }

        [Fact]
        public void TestMakeMoveX_ExpectFalse()
        {
            // arrange
            InterfaceAdapter interfaceAdapter = new InterfaceAdapter();
            string XorO = "X";
            int xPos = 0;
            int yPos = 0;
            interfaceAdapter.CreateBoard();
            // act 
            interfaceAdapter.MakeMoveXorO(XorO, xPos, yPos);
            bool success = interfaceAdapter.MakeMoveXorO(XorO, xPos, yPos);
            // assert
            Assert.False(success);
        }
    }
}
