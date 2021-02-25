using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CellBehaviour actualCell;

    public CellBehaviour ActualCell
    {
        get { return actualCell; }
        set { actualCell = value; Debug.Log(actualCell.name); }
    }

    public void SetInnitialPosition(CellBehaviour cellBehaviour)
    {
        actualCell = cellBehaviour;
    }

}
