using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationLayer;
using Domain.AggregateRoot;
using Moq;

namespace UnitTests
{
    public class ApplicationLayer_ApplicationGame_Tests
    {
        [Fact]
        public void TestCreatePlayer_ExpectTrue ()
        {
                // Arrange
                var mockGameAggregateRoot = new Mock<GameAggregateRoot>();
                mockGameAggregateRoot
                    .Setup(g => g.CreatePlayer(It.IsAny<string>(), It.IsAny<int>()))
                    .Returns(true);

                var applicationGame = new ApplicationGame(mockGameAggregateRoot.Object);

                var player = new ApplicationPlayerModel
                {
                    Name = "Player1",
                    Player1Or2 = 1
                };

                // Act
                var result = applicationGame.CreatePlayer(player);

                // Assert
                Assert.True(result);
        }

        [Fact]
        public void TestCreatePlayer_ExpectFalse()
        {
            // Arrange
            var mockGameAggregateRoot = new Mock<GameAggregateRoot>();
            mockGameAggregateRoot
                .Setup(g => g.CreatePlayer(It.IsAny<string>(), It.IsAny<int>()))
                .Returns(false);

            var applicationGame = new ApplicationGame(mockGameAggregateRoot.Object);

            var player = new ApplicationPlayerModel
            {
                Name = "Player1",
                Player1Or2 = 1
            };

            // Act
            var result = applicationGame.CreatePlayer(player);

            // Assert
            Assert.False(result);
        }
    }
}
