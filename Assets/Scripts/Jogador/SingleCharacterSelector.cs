using System.Collections.Generic;
using Jogador;
using UnityEngine;
using UnityEngine.UI;

public class SingleCharacterSelector : MonoBehaviour
{
	[SerializeField] private Character[] characters;

	[SerializeField] private Text characterDisplayedName;

	[SerializeField] private Image characterSpriteImage;

	private bool _selected;

	private int _currentCharacterIndex;

	public Player GetPlayerCharacter()
	{
		var selectedCharacter = characters[_currentCharacterIndex];
		if (_selected)
		{
			var player = ScriptableObject.CreateInstance<Player>();  
			player.SetCharacter(selectedCharacter);
			return player;
		}

		return null;

	}

	public void NextCharacter()
	{
		if (_currentCharacterIndex + 1 > characters.Length - 1)
		{
			_currentCharacterIndex = 0;
		}
		else
		{
			_currentCharacterIndex++;
		}

		ShowCharacter();
	}

	public void PreviousCharacter()
	{
		if (_currentCharacterIndex - 1 < 0)
		{
			_currentCharacterIndex = characters.Length - 1;
		}
		else
		{
			_currentCharacterIndex--;
		}

		ShowCharacter();
	}

	private void ShowCharacter()
	{
		var currentCharacter = characters[_currentCharacterIndex];
		characterDisplayedName.text = currentCharacter.GetName();
		characterSpriteImage.sprite = currentCharacter.GetSprite();
	}

	public void ConfirmSelection()
	{
		_selected = true;
	}

	public void CancelSelection()
	{
		_selected = false;
	}

	public bool IsSelected()
	{
		return _selected;
	}
}