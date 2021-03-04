using Jogador;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int ActualCellNumber => actualCell.CellNumber;
    private CellBehaviour actualCell;
    private IPlayerDetails playerDetail;

    public CellBehaviour ActualCell
    {
        get { return actualCell; }
        set { actualCell = value; Debug.Log(actualCell.name); }
    }

    public void SetInnitialPosition(CellBehaviour cellBehaviour)
    {
        actualCell = cellBehaviour;
    }

    public void MoveTo(Transform positionToGo)
    {
        gameObject.transform.position = positionToGo.position;
    }

    public void SetPlayerDetails(IPlayerDetails playerDetail)
    {
        this.playerDetail = playerDetail;
    }
    
    public IPlayerDetails GetDetails()
    {
        return playerDetail;
    }
}
