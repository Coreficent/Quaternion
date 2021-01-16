namespace Fang.UserInterface
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class RotateBody : MonoBehaviour
    {
        public float speed = 10f;


        // Update is called once per frame
        void Update()
        {
            transform.Rotate(0, 0, speed * Time.deltaTime); // Hahaha, Tumbler

        }

        public void ChangeSpeed(float newSpeed)
        {
            speed = newSpeed;
        }
    }
}
