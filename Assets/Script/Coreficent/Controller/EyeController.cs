namespace Coreficent.Controller
{
    using Coreficent.Utility;
    using UnityEngine;

    public class EyeController : MonoBehaviour
    {
        [SerializeField] private GameObject _target;
        [SerializeField] private float _rotationSpeed = 45.0f;

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

            DebugLogger.Log("QuaternionCurrent", QuaternionCurrent.w, QuaternionCurrent.x, QuaternionCurrent.y, QuaternionCurrent.z);
            DebugLogger.Log("QuaternionTransform", QuaternionTransform.w, QuaternionTransform.x, QuaternionTransform.y, QuaternionTransform.z);
            DebugLogger.Log("QuaternionFinal", QuaternionFinal.w, QuaternionFinal.x, QuaternionFinal.y, QuaternionFinal.z);

            DebugLogger.Log("Angles", QuaternionCurrent.eulerAngles);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, QuaternionFinal, _rotationSpeed * Time.deltaTime);
        }
    }
}
