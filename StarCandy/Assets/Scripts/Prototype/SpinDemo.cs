using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpinDemo
{
    [System.Serializable]
    public struct RotationInfo
    {
        public float XSpin;
        public float YSpin;
    }

    public class SpinDemo : MonoBehaviour
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
            this.gameObject.transform.Rotate(Vector3.up, Time.deltaTime * rotationInfo.YSpin);
            this.gameObject.transform.Rotate(Vector3.right, Time.deltaTime * rotationInfo.XSpin);
        }
    }
}