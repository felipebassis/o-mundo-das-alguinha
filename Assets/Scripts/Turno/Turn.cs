using System;
using System.Collections.Generic;
using Jogador;
using Turno;
using UnityEngine;

public class Turn : MonoBehaviour
{
    [SerializeField] private IPlayerSelection _playerSelection;
    [SerializeField] private IStartComponent _startTurn;
    [SerializeField] private IMoveComponent _diceRoll;
    [SerializeField] private PlayerBoardMovement _playerMovement;
    [SerializeField] private IEventComponent _eventCardExecuter;
    [SerializeField] private IMoveComponent _questionCardExecuter;
    [SerializeField] private ITurnComponent _finishedTurn;
    [SerializeField] private ITurnComponent _playerWin;

    private IPlayerDetails[] players;
    private Dictionary<TurnStates, (ITurnComponent, Func<TurnStates>)> _actionMap;
    private IPlayerDetails currentPlayer => players[currentPlayerIndex];
    private TurnStates currentState = TurnStates.PLAYER_SELECTION;
    private int currentPlayerIndex = 0;

    private void Start()
    {
        _actionMap = new Dictionary<TurnStates, (ITurnComponent, Func<TurnStates>)>
        {
            {TurnStates.PLAYER_SELECTION, (_playerSelection, () => SelectPlayers()) },
            {TurnStates.START_TURN, (_startTurn, () => StartTurn()) },
            {TurnStates.DICE_ROLL, (_diceRoll, () => GetPlayerDiceRoll()) },
            {TurnStates.DICE_MOVEMENT, (_playerMovement, () => GetPlayerLandedCell()) },
            {TurnStates.EVENT, (_eventCardExecuter, () => GetPlayerEvent())},
            {TurnStates.QUESTION, (_questionCardExecuter, () => GetPlayerAnswer()) },
            {TurnStates.EVENT_MOVEMENT, (_playerMovement, () => GetPlayerLandedCell()) },
            {TurnStates.FINISHED_TURN, (_finishedTurn, () => EndTurn()) },
            {TurnStates.PLAYER_WIN, (_playerWin, () => WinGame()) }
        };

         _playerSelection.ShowElements();
    }

    public void ExecuteTurn()
    {
        var(_, turnAction) = _actionMap[currentState];

        var nextState = turnAction.Invoke();

        currentState = nextState;

        var (scene, _) = _actionMap[currentState];

        scene.ShowElements();
    }

    private TurnStates SelectPlayers()
    {
        players = _playerSelection.GetPlayers();

        currentPlayerIndex = 0;
        _startTurn.SetPlayer(currentPlayer);

        return TurnStates.START_TURN;
    }

    private TurnStates StartTurn()
        => TurnStates.DICE_ROLL;

    private TurnStates GetPlayerDiceRoll()
    {
        var quantityToWalk = _diceRoll.GetQuantityToMove();

        _playerMovement.SetPlayerMovement(currentPlayer, quantityToWalk);

        return TurnStates.DICE_MOVEMENT;
    }

    private TurnStates GetPlayerLandedCell()
    {
        var landedCell = _playerMovement.GetLandedCell();

        var doNotVerifyCell = currentState == TurnStates.EVENT_MOVEMENT;

        if (doNotVerifyCell)
        {
            return TurnStates.FINISHED_TURN;
        }

        var isAEventCell = landedCell == CellType.EVENT;

        if (isAEventCell)
        {
            _eventCardExecuter.SetPlayer(currentPlayer);
            return TurnStates.EVENT;

        }

        var isAQuestionCell = landedCell == CellType.QUESTION;

        if (isAQuestionCell)
        {
            return TurnStates.QUESTION;
        }

        return TurnStates.FINISHED_TURN;
    }

    private TurnStates GetPlayerEvent()
    {
        var quantityToWalk = _eventCardExecuter.GetQuantityToMove();

        if (quantityToWalk == 0)
        {
            return TurnStates.FINISHED_TURN;
        }

        _playerMovement.SetPlayerMovement(currentPlayer, quantityToWalk);

        return TurnStates.EVENT_MOVEMENT;
    }

    private TurnStates GetPlayerAnswer()
    {
        var quantityToWalk =_questionCardExecuter.GetQuantityToMove();

        _playerMovement.SetPlayerMovement(currentPlayer, quantityToWalk);

        return TurnStates.EVENT_MOVEMENT;
    }

    private TurnStates EndTurn()
    {
        var playerWon = _playerMovement.IsWinner(currentPlayer);

        if (playerWon)
        {
            return TurnStates.PLAYER_WIN;
        }

        currentPlayerIndex = currentPlayerIndex + 1 == players.Length ? 0 : currentPlayerIndex + 1;

        _startTurn.SetPlayer(currentPlayer);

        return TurnStates.START_TURN;
    }

    private TurnStates WinGame()
    {
        // Envia para o _playerWin todos os dados dos jogadores
        return TurnStates.PLAYER_WIN;
    }
}
