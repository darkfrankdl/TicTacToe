using InterfaceAdapterLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemTests
{
    public class InterfaceAdapterTests
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
    }
}
