using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class BoardBehaviour : MonoBehaviour
{
    [SerializeField] private List<CellPosition> _cells;
    
    public CellPosition GetFirstPosition()
    {
        return _cells[0];
    }

    public CellPosition GetActualPosition(CellBehaviour actualCell)
    {
        var actualPosition = _cells.FirstOrDefault(x => x.Cell == actualCell);

        if (!actualPosition)
        {
            Debug.LogError("Não foi encontrado nenhuma celula");
            return GetFirstPosition();
        }

        return actualPosition;
    }

    public CellPosition GetNexPosition(CellBehaviour actualCell, int amountOfCellsToMove)
    {
        var index = _cells.FindIndex(x =>  x.Cell == actualCell);
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

    public bool IsLastCell(CellBehaviour actualCell)
    {
        return actualCell == _cells[_cells.Count - 1].Cell;
    }
}
