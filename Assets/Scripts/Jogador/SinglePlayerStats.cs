using UnityEngine;
using UnityEngine.UI;

namespace Jogador
{
	public class SinglePlayerStats : MonoBehaviour
	{
		[SerializeField] private Player[] players;
		[SerializeField] private Text playersDisplayedName;
		[SerializeField] private Image playersSpriteImage;
		[SerializeField] private Color playerColor;
	
		private int _currentPlayerIndex;

		public void GetPlayerStats()
		{

		}
		
	}
}