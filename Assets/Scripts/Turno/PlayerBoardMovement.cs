using Jogador;

namespace Turno
{
	public abstract class PlayerBoardMovement : TurnComponent
	{
		public abstract void SetPlayerMovement(IPlayerDetails player, int quantityToWalk);
		public abstract CellType GetLandedCell();
		public abstract bool IsWinner(IPlayerDetails player);
	}
}