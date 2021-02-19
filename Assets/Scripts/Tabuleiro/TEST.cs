using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST : MonoBehaviour
{
    public PlayerMovement player;
    public BoardMover mover;
    
    public void Test01(int valor)
    {
        mover.MovePlayer(player, valor);

    }
    void Test02()
    {

    }
}
