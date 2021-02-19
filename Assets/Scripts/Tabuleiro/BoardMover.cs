using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardMover : MonoBehaviour
{
    private BoardBehaviour board;
    
    public void MovePlayer(PlayerMovement player, int amountOfCellsToMove)
    {
        var actualCell = player.ActualCell;
        var nextCell = board.GetNexCell(actualCell, amountOfCellsToMove);
        player.ActualCell = nextCell;
    }
}
