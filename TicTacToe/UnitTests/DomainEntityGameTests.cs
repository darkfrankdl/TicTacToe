using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.AggregateRoot;
using Domain.Entity;

namespace UnitTests
{
    public class DomainEntityGameTests
    {
        [Fact]
        public void TestCreateBoard_ExpectTrue()
        {
            // arrange
            Game game = new Game();
            // act
            bool result = game.CreateBoard();
            // assert
            Assert.True(result);
        }

        [Fact]
        public void TestCreatePlayer1_ExpectTrue ()
        {
            //Arrange
            int playerNumber = 1;
            Game game = new Game();
            //Act
            bool result = game.CreatePlayer("Test",playerNumber);
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void TestCreatePlayer2_ExpectTrue()
        {
            //Arrange
            int playerNumber = 2;
            Game game = new Game();
            //Act
            bool result = game.CreatePlayer("Test", playerNumber);
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void TestCreatePlayer_ExpectFalse()
        {
            //Arrange
            int playerNumber = 3;
            Game game = new Game();
            //Act
            bool result = game.CreatePlayer("Test", playerNumber);
            //Assert
            Assert.False(result);
        }

        [Fact]
        public void TestMakeX_ExpectTrue()
        {
            // Arrange 
            Board board = new Board();
            // Act
            bool success = false;
            success = board.MakeMoveXorO("X",0,0);
            // Assert
            Assert.True(success);
        }

        [Fact]
        public void TestMakeO_ExpectTrue()
        {
            // Arrange 
            Board board = new Board();
            // Act
            bool success = false;
            success = board.MakeMoveXorO("O", 0, 0);
            // Assert
            Assert.True(success);
        }

        [Fact]
        public void TestMakeXorO_ExpectFalse()
        {
            // Arrange 
            Board board = new Board();
            board.MakeMoveXorO("X", 0, 0);
            // Act
            bool success = false;
            success = board.MakeMoveXorO("X", 0, 0);
            // Assert
            Assert.False(success);
        }
    }
}
