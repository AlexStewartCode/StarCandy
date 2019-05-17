using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceCandy
{
    [RequireComponent(typeof(RectTransform))]
    public class UIOscillate : MonoBehaviour
    {
        public float distance = 10;
        public float speed = 1;

        private Vector3 pos;

        private void Start()
        {
            pos = (transform as RectTransform).position;
        }

        private void Update()
        {
            RectTransform rt = this.transform as RectTransform;
            rt.position = pos + new Vector3(0, Mathf.Sin(Time.realtimeSinceStartup * speed) * distance, 0);
        }
    }
}