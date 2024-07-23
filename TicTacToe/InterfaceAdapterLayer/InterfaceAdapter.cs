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

                ApplicationPlayerModel player = DTOModelConverter.DTOToApplicationPlayer(playerDto);
                // send data to the ApplicationLayer
                GameRepository.GetRepo().AppGame.CreatePlayer(player);

                success = true; // status on player Creation
            }
            catch (Exception ex)
            {
                ex = new Exception("Error in creating player, check name or number");
            }
           return success;
        }

        public DTOPlayer GetPlayer (int playerNumber)
        {
            return DTOModelConverter.ApplcationPlayerToDTO(GameRepository.GetRepo().AppGame.GetPlayer(playerNumber));
        }
    }
}
