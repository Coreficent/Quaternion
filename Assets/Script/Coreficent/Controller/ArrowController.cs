namespace Coreficent.Controller
{
    using Coreficent.Utility;
    using UnityEngine;

    public class ArrowController : MonoBehaviour
    {
        public EyeController RightEyeController;
        public EyeController LeftEyeController;

        public int Index = 0;

        private EyeController _currentEye;

        protected void Start()
        {
            SanityCheck.Check(this, RightEyeController, LeftEyeController, Index >= 1 && Index <= 3);

            switch (Index)
            {
                case 1:
                    transform.Find("Display").GetComponent<MeshRenderer>().material.color = Color.black;
                    break;
                case 2:
                    transform.Find("Display").GetComponent<MeshRenderer>().material.color = Color.gray; 
                    break;
                case 3:
                    transform.Find("Display").GetComponent<MeshRenderer>().material.color = Color.white;
                    break;
                default:
                    DebugLogger.Warn("unexpected index in arrow controller start");
                    break;
            }

        }

        protected void Update()
        {
            _currentEye = EyeController.RightEyeOn ? RightEyeController : LeftEyeController;

            switch (Index)
            {
                case 1:
                    transform.localRotation = _currentEye.QuaternionCurrent;
                    break;
                case 2:
                    transform.localRotation = _currentEye.QuaternionTransform;
                    break;
                case 3:
                    transform.localRotation = _currentEye.QuaternionFinal;
                    break;
                default:
                    DebugLogger.Warn("unexpected index in arrow controller");
                    break;
            }
        }
    }
}
