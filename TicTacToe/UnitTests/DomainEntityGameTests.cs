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
        public void TestCreateBoard_ExpectFalse()
        {
            // arrange
            GameAggregateRoot root = new GameAggregateRoot();
            root.Game.CreateBoard();
            // act
            bool result = root.Game.CreateBoard();
            // assert
            Assert.False(result);
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
    }
}
