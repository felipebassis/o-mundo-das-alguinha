using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class CellPosition : MonoBehaviour
{
    [SerializeField] private CellBehaviour cell;
    [SerializeField] private SpriteRenderer[] CellBorders;
    [SerializeField] private List<Transform> cellPositions1;
    [SerializeField] private List<Transform> cellPositions2; 
    [SerializeField] private List<Transform> cellPositions3; 
    [SerializeField] private List<Transform> cellPositions4; 
    [SerializeField] private List<Transform> cellPositions5;

    private List<PlayerMovement> _players = new List<PlayerMovement>();

    public CellBehaviour Cell => cell;

    public void AddPlayerPosition(PlayerMovement player)
    {
        if (_players.Contains(player))
        {
            Debug.LogError($"Jogador {player.name} já está inserido na célula {this.name}");
            return;
        }

        player.ActualCell = cell;
        
        _players.Add(player);
        
        ReorganizePlayers();
    }

    public void RemovePlayerPosition(PlayerMovement player)
    {
        if (!_players.Contains(player))
        {
            Debug.LogError($"Jogador {player.name} não está inserido na célula {this.name} para ser removido");
            return;
        }

        _players.Remove(player);

        ReorganizePlayers();
    }

    private void ReorganizePlayers()
    {
        var positionToOrganize = GetPositionToOrganize();
        var positionsWithIndex = positionToOrganize.Select((item, index) => (item, index));
        
        foreach(var (position, index) in positionsWithIndex)
        {
            _players[index].MoveTo(position);
        }

    }

    private IEnumerable<Transform> GetPositionToOrganize()
    {
        switch(_players.Count)
        {
            case 1: return cellPositions1;
            case 2: return cellPositions2;
            case 3: return cellPositions3;
            case 4: return cellPositions4;
            case 5: return cellPositions5;
            default: return new List<Transform>();
        };
    }
}
