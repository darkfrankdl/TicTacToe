using ApplicationLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAdapterLayer
{
    public class InterfaceAdapter
    {
        public InterfaceAdapter()
        {

        }

        public bool CreatePlayer (string name , int number)
        {
            bool success = false;
            try
            {
                DTOPlayer playerDto = new DTOPlayer(name);
                playerDto.Player1Or2 = number;

                ApplicationPlayerModel player = DTOToDomainModelConverter.DTOToApplicationPlayer(playerDto);
                ApplicationGame appGame = new ApplicationGame();
                appGame.CreatePlayer(player);
                success = true;
            }
            catch (Exception ex)
            {
                Exception exception = new Exception("Error in creating player, check name or number");
                Console.WriteLine(exception.Message);
            }
           return success;

        }
    }
}
