public abstract class IPlayerBoardMovement: ITurnComponent
{
    public abstract void SetPlayerMovement(IPlayerDetails player, int quantityToWalk);
    public abstract CellType GetLandedCell();
    public abstract bool IsWinner(IPlayerDetails player);
}