<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CellBehaviour ActualCell { get; set; }
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CellBehaviour actualCell;

    public CellBehaviour ActualCell
    {
        get { return actualCell; }
        set { actualCell = value; Debug.Log(actualCell.name); }
    }

}
>>>>>>> 1c3c20e (Criação de componentes para movimentação do jogador)
