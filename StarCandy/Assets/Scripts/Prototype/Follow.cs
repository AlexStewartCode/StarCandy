using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject target;
    private Vector3 startPosition;
    private Vector3 startRotation;
    private Vector2 mousePosPrevious;

    // Start is called before the first frame update
    void Start()
    {
        mousePosPrevious = Input.mousePosition;
        startPosition =  this.transform.position - target.transform.position;
        startRotation = this.transform.rotation.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            Vector2 mousePosCurrent = Input.mousePosition;
            startRotation.y = (mousePosPrevious.x - mousePosCurrent.x)/10;
        }
        this.transform.position = target.transform.position + startPosition;
        this.transform.rotation = Quaternion.Euler(startRotation);
    }
}
