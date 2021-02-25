using System.Collections;
using System.Collections.Generic;
using Tabuleiro;
using UnityEngine;

public class Player : ScriptableObject, IPlayerDetails
{
    
    private Character _character;

    private int _position;
    
    private ICard[] _drawnCards;

    public Character getCharacter()
    {
        return _character;
    }
    
}
