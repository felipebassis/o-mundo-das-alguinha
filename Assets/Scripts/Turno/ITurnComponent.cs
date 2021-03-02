using System;
using UnityEngine;

namespace Turno
{
    public abstract class TurnComponent : MonoBehaviour
    {
        private Action _finalizeMethod;

        private void Awake()
        {
            _finalizeMethod = FindObjectOfType<Turn>().ExecuteTurn;
            HideComponent();
        }

        public abstract void ShowElements();
    
        public void FinishComponent()
        {
            HideComponent();
            _finalizeMethod.Invoke();
        }

        protected abstract void HideComponent();
    }
}