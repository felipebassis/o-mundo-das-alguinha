using UnityEngine;

public interface ICharacter
{
	Sprite GetSprite();
	void SetSprite(Sprite sprite);

	string GetName();
	void SetName(string name);

	Color GetColor();
	void SetColor(Color color);
}