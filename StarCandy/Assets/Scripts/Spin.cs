using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct RotationInfo
{
    public float XSpin;
    public float YSpin;
}

public class Spin : MonoBehaviour
{
    public RotationInfo rotationInfo;

    private void Awake()
    {
        Debug.Log("Awake!");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start!");
    }

    // Update is called once per frame
    void Update()
    {
        //var rotation = this.gameObject.transform.rotation;
        this.gameObject.transform.Rotate(Vector3.up, rotationInfo.YSpin);
        this.gameObject.transform.Rotate(Vector3.right, rotationInfo.XSpin);
    }
}
