using ApplicationLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAdapterLayer
{
    internal class DTOModelConverter
    {
        public static ApplicationPlayerModel DTOToApplicationPlayer (DTOPlayer dtoPlayer)
        {
            ApplicationPlayerModel playerModel = new ApplicationPlayerModel ();
            playerModel.Name = dtoPlayer.Name;
            playerModel.Player1Or2 = dtoPlayer.Player1Or2;
            return playerModel;
        }

        public static DTOPlayer ApplcationPlayerToDTO(ApplicationPlayerModel applicationPlayer)
        {
            DTOPlayer DtoPlayer = null;
            if (applicationPlayer != null)
            {
                DtoPlayer = new DTOPlayer(applicationPlayer.Name);
                DtoPlayer.Player1Or2 = applicationPlayer.Player1Or2;
            }

            return DtoPlayer;
        }

        public static DTOBoard ApplicationBoardToDTOBoardModel (ApplicationBoardPositionModel appModel)
        {
            DTOBoard dto = new DTOBoard();
            dto.Position = appModel.BoardPosition;
            return dto;
        }

        public static ApplicationBoardPositionModel DTOBoardToApplicationBoardModel (DTOBoard dto)
        {
            ApplicationBoardPositionModel boardModel = new ApplicationBoardPositionModel ();
            boardModel.BoardPosition = dto.Position;
            return boardModel;
        }
    }
}
