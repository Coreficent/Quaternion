namespace Coreficent.Controller
{
    using Coreficent.Utility;
    using UnityEngine;

    public class BodyController : MonoBehaviour
    {
        [SerializeField] private GameObject _target;
        [SerializeField] private float _cullingAngle = 60.0f;
        [SerializeField] private float _rotationSpeed = 45.0f;

        protected void Start()
        {
            SanityCheck.Check(this, _target);
        }

        protected void Update()
        {
            Vector3 from = _target.transform.position;
            from.y = 0.0f;
            Vector3 to = transform.position;
            to.y = 0.0f;

            DebugRender.Draw(from, to, Color.green);

            Vector3 direction = to - from;

            float angle = Vector3.Angle(direction, transform.forward);

            DebugLogger.Log(angle);

            if (angle > _cullingAngle)
            {
                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(direction), _rotationSpeed * Time.deltaTime);
            }
        }
    }
}
