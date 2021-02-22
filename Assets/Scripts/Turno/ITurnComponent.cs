using System;
using UnityEngine;

public abstract class ITurnComponent : MonoBehaviour
{
    private Action finalizeMethod;

    private void Awake()
    {
        finalizeMethod = FindObjectOfType<Turn>().ExecuteTurn;
        HideComponent();
    }

    public abstract void ShowElements();
    
    public void FinishComponent()
    {
        HideComponent();
        finalizeMethod.Invoke();
    }

    protected abstract void HideComponent();
}