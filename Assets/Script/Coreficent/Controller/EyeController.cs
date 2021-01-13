namespace Coreficent.Controller
{
    using Coreficent.Utility;
    using UnityEngine;

    public class EyeController : MonoBehaviour
    {
        [SerializeField] private GameObject _target;

        protected void Start()
        {
            SanityCheck.Check(this, _target);
        }

        protected void Update()
        {
            DebugRender.Draw(transform.position, _target.transform.position, Color.red);

            transform.rotation = Quaternion.LookRotation(_target.transform.position - transform.position);
        }
    }
}