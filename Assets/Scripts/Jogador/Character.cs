using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Character", order = 1)]
public class Character : ScriptableObject, ICharacter
{
    [SerializeField] private Sprite sprite;

    [SerializeField] private string name;

    [SerializeField] private Color color;
    
    public Sprite GetSprite()
    {
        return sprite;
    }

    public void SetSprite(Sprite sprite)
    {
        this.sprite = sprite;
    }

    public string GetName()
    {
        return name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public Color GetColor()
    {
        return color;
    }

    public void SetColor(Color color)
    {
        this.color = color;
    }
}