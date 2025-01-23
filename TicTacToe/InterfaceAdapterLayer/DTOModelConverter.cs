using ApplicationLayer;
using Domain.AggregateRoot;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

        public static DTOBoard ApplicationBoardToDTOBoardModel (ApplicationBoardModel appModel)
        {
            DTOBoard dto = new DTOBoard();
            dto.PositionSymbols = new string[3, 3];
            return dto;
        }

        public static ApplicationBoardModel DTOBoardToApplicationBoardModel (DTOBoard dto)
        {
            ApplicationBoardModel boardModel = new ApplicationBoardModel ();
            boardModel.BoardPositionSymbols = new string[3,3];
            return boardModel;
        }
    }
}
