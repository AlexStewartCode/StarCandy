using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 300; 
    private Rigidbody playerBox;
    // Start is called before the first frame update
    void Start()
    {
        playerBox = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            playerBox.velocity += Time.deltaTime * new Vector3(0, 0, speed);
        if (Input.GetKey(KeyCode.DownArrow))
            playerBox.velocity += Time.deltaTime * new Vector3(0, 0, -speed);
        if (Input.GetKey(KeyCode.LeftArrow))
            playerBox.velocity += Time.deltaTime * new Vector3(-speed, 0, 0);
        if (Input.GetKey(KeyCode.RightArrow))
            playerBox.velocity += Time.deltaTime * new Vector3(speed, 0,0); 
        
    }
}
