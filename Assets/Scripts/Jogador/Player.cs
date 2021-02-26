using Tabuleiro;
using UnityEngine;

namespace Jogador
{
	public class Player : ScriptableObject, IPlayerDetails
	{
		private Character _character;

		private int _position;

		private ICard[] _drawnCards;
	
		public Character GetCharacter()
		{
			return _character;
		}

		public void SetCharacter(Character selectedChar)
		{
			_character = selectedChar;
		}
		public void SetPosition(int playerCell)
		{
			_position = playerCell;
		}

		public int GetPosition()
		{
			return _position;
		}
	}
}