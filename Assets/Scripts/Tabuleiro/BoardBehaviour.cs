using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardBehaviour : MonoBehaviour
{
    [SerializeField] private List<CellBehaviour> _cells;
    
    public CellBehaviour GetFirstCell()
    {
        return _cells[0];
    }

    public CellBehaviour GetNexCell(CellBehaviour actualCell, int amountOfCellsToMove)
    {
        var index = _cells.FindIndex(x =>  x == actualCell);
        var nextCellIndex = index + amountOfCellsToMove;
    
        if(nextCellIndex >= _cells.Count)
        {
            return _cells[_cells.Count- 1];
        }
        if(nextCellIndex < 0)
        {
            return _cells[0];
        }
        return _cells[nextCellIndex];
        
    }

    public bool isLastCell(CellBehaviour actualCell)
    {
        return actualCell == _cells[_cells.Count - 1];
    }
}
