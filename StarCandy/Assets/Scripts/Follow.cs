using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject target;
    private Vector3 startPosition;
    private Quaternion startRotation;
    private Vector2 mousePosPrevious;

    // Start is called before the first frame update
    void Start()
    {
        mousePosPrevious = Input.mousePosition;
        startPosition =  this.transform.position - target.transform.position;
        startRotation = this.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            Vector2 mousePosCurrent = Input.mousePosition;
            startRotation = Quaternion.Euler(startRotation.x, mousePosPrevious.x - mousePosCurrent.x, startRotation.z);
        }
        this.transform.position = target.transform.position + startPosition;
        this.transform.rotation = startRotation;
    }
}
