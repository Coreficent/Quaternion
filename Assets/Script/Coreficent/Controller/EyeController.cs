namespace Coreficent.Controller
{
    using Coreficent.Utility;
    using UnityEngine;

    public class EyeController : MonoBehaviour
    {
        [SerializeField] private GameObject _target;

        private void Start()
        {
            SanityCheck.Check(this, _target);
        }

        private void Update()
        {

        }

        private void LookAt()
        {
            DebugLogger.ToDo("implement look at");
        }
    }
}