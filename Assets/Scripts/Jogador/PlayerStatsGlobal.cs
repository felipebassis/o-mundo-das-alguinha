using UnityEngine;

namespace Jogador
{
	public class PlayerStatsGlobal : MonoBehaviour
	{
		[SerializeField] private GameObject playerStats;
		[SerializeField] private SinglePlayerStats[] singlePlayerStats;

	// 	public void ShowElements()
	// 	{
	// 		playerStats.SetActive(true);
	// 	}
	// 	
	// 	protected override void HideComponent()
	// 	{
	// 	
	// 			playerStats[i].(true);
	// 		}
	// 	}
	// 	
	// 	public override IPlayerDetails[] GetPlayers()
	// 	{
	// 		var players = new IPlayerDetails[5];
	// 	
	// 		for (var i = 0; i < 5; i++)
	// 		{
	// 			players[i] = singlePlayerStats[i].();
	// 		}
	// 	
	// 		return players;
	// 	}
	 }
}