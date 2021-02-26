using UnityEngine;

public class CellBehaviour : MonoBehaviour
{
    [SerializeField] private CellType cell;
    [SerializeField] private int cellNumber;

    public int CellNumber => cellNumber;
    public CellType Type => cell;
}
