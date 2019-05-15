using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Don't destroy the gameobject this is on by moving it to the DontDestroyOnLoad scene
namespace StarCandy
{
    public class DontDestroyOnLoad : MonoBehaviour
    {
        void Awake()
        {
            DontDestroyOnLoad(this);
        }
    }
}