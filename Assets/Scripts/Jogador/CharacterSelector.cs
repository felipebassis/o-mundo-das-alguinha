using System.Collections.Generic;
using Turno;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Jogador
{
	public class CharacterSelector : PlayerSelection
	{
		[SerializeField] private GameObject confirmedPlayers;
		[SerializeField] private SingleCharacterSelector[] singleCharacterSelector;

		public override void ShowElements()
		{
			confirmedPlayers.SetActive(true);
		}

		protected override void HideComponent()
		{
			confirmedPlayers.SetActive(false);
		}

		public override IPlayerDetails[] GetPlayers()
		{
			var players = new List<IPlayerDetails>();

			foreach (var characterSelector in singleCharacterSelector)
			{
				if (characterSelector.IsSelected())
				{
					players.Add(characterSelector.GetPlayerCharacter());
				}
			}

			return players.ToArray();
		}
	}


}