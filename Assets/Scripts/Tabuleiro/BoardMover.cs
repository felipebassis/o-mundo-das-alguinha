using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardMover : IPlayerBoardMovement
{
    [SerializeField] private BoardBehaviour board;

    private PlayerMovement playerMovement;
    private int amountOfCellsToMove;

    public override CellType GetLandedCell()
    {
        return playerMovement.ActualCell.Type;
    }

    public override bool IsWinner(PlayerMovement player)
    {
        return board.isLastCell(player.ActualCell);
    }

    public override void SetInnitialPosition(PlayerMovement[] players)
    {
        var firstPosition = board.GetFirstCell();

        foreach(var player in players)
        {
            player.SetInnitialPosition(firstPosition);
        }
    }

    public override void SetPlayerMovement(PlayerMovement player, int quantityToWalk)
    {
        this.playerMovement = player;
        this.amountOfCellsToMove = quantityToWalk;
    }

    public override void ShowElements()
    {
        MovePlayer();
    }

    protected override void HideComponent()
    {
        
    }
    private void MovePlayer()
    {
        var actualCell = playerMovement.ActualCell;
        var nextCell = board.GetNexCell(actualCell, amountOfCellsToMove);
        playerMovement.ActualCell = nextCell;
    }
}
