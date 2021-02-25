namespace Jogador
{
    public interface IPlayerDetails
    {
        Character GetCharacter();
    
        int GetPosition();

        void SetPosition(int playerCell);
        
        PlayerMovement GetPlayerMovement();

    }
}
