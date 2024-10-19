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
            bool stepStatus = false;
            DTOPlayer playerDto = new DTOPlayer(name);
            playerDto.Player1Or2 = number;

            ApplicationPlayerModel player = DTOModelConverter.DTOToApplicationPlayer(playerDto);
            // send data to the ApplicationLayer
            stepStatus = GameRepository.GetRepo().AppGame.CreatePlayer(player);
            if (stepStatus)
            {
                success = true; // status on player Creation
            }
            return success;
        }

        public DTOPlayer GetPlayer (int playerNumber)
        {
            return DTOModelConverter.ApplcationPlayerToDTO(GameRepository.GetRepo().AppGame.GetPlayer(playerNumber));
        }

        public bool CreateBoard ()
        {
            bool isBoardCreated = GameRepository.GetRepo().AppGame.CreateBoard();
            return isBoardCreated;
        }

        public bool MakeMoveXorO(string XorO, int xPos, int yPos)
        {
            GameRepository repo = GameRepository.GetRepo();
            ApplicationGame game = repo.AppGame;
            bool success = game.MakeMoveXorO(XorO, xPos, yPos);
            return success;
        }
    }
}
