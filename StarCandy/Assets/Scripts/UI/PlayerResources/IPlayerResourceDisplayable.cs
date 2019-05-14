using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Numerics;

public interface IUIResourceDisplayable
{
    string Name { get; }
    BigInteger Value { get; }

    System.Action OnValueChanged { get; set; }
}
