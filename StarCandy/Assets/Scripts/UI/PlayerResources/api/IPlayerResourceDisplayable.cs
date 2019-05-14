using UnityEngine;
using System.Numerics;


namespace StarCandy.UI
{ 
    public interface IUIResourceDisplayable
    {
        string Name { get; }      // Name of the resource
        BigInteger Value { get; } // Whole number value of the resource
        Sprite Icon { get; }      // Resource icon - if null, none is displayed.

        // Is called when one of the fields above changes
        System.Action OnValueChanged { get; set; }
    }
}