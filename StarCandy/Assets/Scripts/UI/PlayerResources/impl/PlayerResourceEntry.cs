using System;
using System.Numerics;
using UnityEngine;


namespace StarCandy.UI.impl
{
    [System.Serializable]
    public class PlayerResourceEntry : IUIResourceDisplayable
    {
        // Variables
        public string name;
        public long value;
        public Sprite icon;

        // Iterface implementation
        public string Name => name;
        public BigInteger Value => value;
        public Sprite Icon => icon;

        public Action OnValueChanged { get; set; }

    }
}