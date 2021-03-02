using Jogador;
using Turno;

public abstract class IStartComponent: TurnComponent
{
    public abstract void SetPlayer(IPlayerDetails player);
}