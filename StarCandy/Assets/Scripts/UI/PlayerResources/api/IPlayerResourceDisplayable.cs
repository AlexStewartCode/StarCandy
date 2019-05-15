using UnityEngine;
using System.Numerics;


namespace StarCandy.UI
{ 
    public interface IUIResourceDisplayable
    {
        string Name { get; }      // Name of the resource
        BigInteger Value { get; } // Whole number value of the resource
        Sprite Icon { get; }      // Resource icon - if null, none is displayed.

        // This is to be called when changes to above fields need to be propogated.
        System.Action OnValueChanged { get; set; }
    }
}