using UnityEngine;

public class Character : ScriptableObject, ICharacter
{
    private Sprite _sprite;

    private string _name;

    private Color _color;

    public Sprite getSprite()
    {
        return _sprite;
    }

    public string getName()
    {
        return _name;
    }

    public Color getColor()
    {
        return _color;
    }
}