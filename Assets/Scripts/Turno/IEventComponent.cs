using Jogador;
using Turno;

internal abstract class IEventComponent: MoveComponent
{
    public abstract void SetPlayer(IPlayerDetails playerDetails);
}