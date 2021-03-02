using Jogador;

namespace Turno
{
    public abstract class PlayerSelection: TurnComponent
    {
        public abstract IPlayerDetails[] GetPlayers();
    }
}