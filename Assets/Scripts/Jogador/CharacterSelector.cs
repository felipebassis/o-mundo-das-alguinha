using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelector : IPlayerSelection
{
    
    private IPlayerDetails _players;

    public override void ShowElements()
    {
        throw new System.NotImplementedException();
    }

    protected override void HideComponent()
    {
        throw new System.NotImplementedException();
    }

    public override IPlayerDetails[] GetPlayers()
    {
        throw new System.NotImplementedException();
    }
    
}