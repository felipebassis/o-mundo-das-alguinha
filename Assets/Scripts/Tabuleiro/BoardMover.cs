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
        return board.IsLastCell(player.ActualCell);
    }

    public override void SetInnitialPosition(PlayerMovement[] players)
    {
        var firstPosition = board.GetFirstPosition();

        foreach(var player in players)
        {
            firstPosition.AddPlayerPosition(player);
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
        var actualPosition = board.GetActualPosition(playerMovement.ActualCell);
        actualPosition.RemovePlayerPosition(playerMovement);

        var nextPosition = board.GetNexPosition(actualPosition.Cell, amountOfCellsToMove);
        nextPosition.AddPlayerPosition(playerMovement);
    }
}
