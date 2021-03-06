﻿namespace Coreficent.Controller
{
    using Coreficent.Utility;
    using UnityEngine;

    public class EyeController : MonoBehaviour
    {
        public static bool Tracking = true;
        public static bool LeftEyeOn = false;
        public static bool RightEyeOn = true;

        [SerializeField] private GameObject _target;
        [SerializeField] private float _rotationSpeed = 45.0f;

        public AudioSource audioSource;
        public AudioClip impact;

        public Quaternion QuaternionCurrent
        {
            get => transform.rotation;
        }

        public Quaternion QuaternionTransform
        {
            get => Quaternion.FromToRotation(transform.InverseTransformDirection(transform.forward), transform.InverseTransformDirection(_target.transform.position - transform.position));
        }

        public Quaternion QuaternionFinal
        {
            get => QuaternionCurrent * QuaternionTransform;
        }

        protected void Start()
        {
            SanityCheck.Check(this, _target);
        }

        protected void Update()
        {
            DebugRender.Draw(transform.position, _target.transform.position, Color.red);

            //DebugRender.Draw(Vector3.zero, transform.InverseTransformDirection(transform.forward) * 45.0f, Color.black);
            //DebugRender.Draw(Vector3.zero, transform.InverseTransformDirection(_target.transform.position - transform.position), Color.white);

            //transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(_target.transform.position - transform.position), _rotationSpeed * Time.deltaTime);

            //DebugLogger.Log("QuaternionCurrent", QuaternionCurrent.x, QuaternionCurrent.y, QuaternionCurrent.z, QuaternionCurrent.w);
            //DebugLogger.Log("QuaternionTransform", QuaternionTransform.x, QuaternionTransform.y, QuaternionTransform.z, QuaternionTransform.w);
            //DebugLogger.Log("QuaternionFinal", QuaternionFinal.x, QuaternionFinal.y, QuaternionFinal.z, QuaternionFinal.w);

            //DebugLogger.Log("Angles", QuaternionCurrent.eulerAngles);
            if (Tracking)
            {
                transform.rotation = Quaternion.RotateTowards(transform.rotation, QuaternionFinal, _rotationSpeed * Time.deltaTime);
            }
        }

        public void OnToggle()
        {
            audioSource.PlayOneShot(impact, 0.5F);
            Tracking = !Tracking;
        }

        public void ActivateLeft()
        {
            LeftEyeOn = true;
            RightEyeOn = false;
        }

        public void ActivateRight()
        {
            RightEyeOn = true;
            LeftEyeOn = false;
        }
    }
}
