using UnityEngine;
using UnityEngine.SceneManagement;

namespace Jogador
{
	public class CharacterSelector : IPlayerSelection
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
			var players = new IPlayerDetails[5];

			for (var i = 0; i < 5; i++)
			{
				players[i] = singleCharacterSelector[i].GetPlayerCharacter();
			}

			return players;
		}

		public void ConfirmPlayers()
		{
			HideComponent();
		}
	}


}