using Jogador;

public abstract class IPlayerSelection: ITurnComponent
{
    public abstract IPlayerDetails[] GetPlayers();
}