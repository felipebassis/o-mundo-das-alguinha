using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

namespace Turno
{
    public abstract class DiceComponent : TurnComponent
    {
        [SerializeField] [Range(1, 6)] private int diceSide;
        private Random rnd = new Random();

        public int RollDice()
        {
            diceSide = rnd.Next();
            return diceSide;
        }
    }
}