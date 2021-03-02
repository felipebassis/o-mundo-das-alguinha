using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Jogador
{
	public class SinglePlayerStats : MonoBehaviour
	{
		private Player player;
		[SerializeField] private TMP_Text playerPosition;
		[SerializeField] private TMP_Text playersDisplayedName;
		[SerializeField] private Image playersSpriteImage;
		[SerializeField] private Image playerColor;

		[SerializeField] private GameObject display;
		private bool active;

		public void UpdatePlayerPosition()
		{
			playerPosition.text = player.GetPosition().ToString();
		}
		
		//TODO "Setar" esse loco no turno.
		public void SetPlayer(Player player)
		{
			active = true;
			display.SetActive(true);
			this.player = player;
			playerColor.color = player.GetCharacter().GetColor();
			playersDisplayedName.text = player.GetCharacter().GetName();
		}

		private void Update()
		{
			if (active)
			{
				UpdatePlayerPosition();
			}
		}

		private void Awake()
		{
			display.SetActive(false);
			active = false;
		}
	}
}