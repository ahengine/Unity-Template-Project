using System.Collections.Generic;
using UnityEngine;

namespace UStylers
{
    public abstract class UStylerBase : MonoBehaviour
    {
        [SerializeField] private bool parent;
        private List<UStylerBase> childs = new List<UStylerBase>();

        protected virtual void Awake()
        {
            if (!parent)
                return;

            var items = GetComponentsInChildren<UStylerBase>();

            for (int i = 0; i < items.Length; i++)
                if(items[i] != this)
                    childs.Add(items[i]);
        }

        public virtual void SetState(StateCard state)
        {
            ApplyState(state);

            if (parent)
            {
                for (int i = 0; i < childs.Count; i++)
                    childs[i].ApplyState(state);
            }        
        }

        public virtual void ApplyState(StateCard state)
        {

        }
    }
}