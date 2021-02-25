using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Character", order = 1)]
public class Character : ScriptableObject, ICharacter
{
    [SerializeField] private Sprite _sprite;

    [SerializeField] private string _name;

    [SerializeField] private Color _color;
    
    public Sprite GetSprite()
    {
        return _sprite;
    }

    public void SetSprite(Sprite sprite)
    {
        _sprite = sprite;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public Color GetColor()
    {
        return _color;
    }

    public void SetColor(Color color)
    {
        _color = color;
    }
}