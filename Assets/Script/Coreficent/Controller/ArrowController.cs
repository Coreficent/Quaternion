namespace Coreficent.Controller
{
    using Coreficent.Utility;
    using UnityEngine;

    public class ArrowController : MonoBehaviour
    {
        public int Index = 0;

        public EyeController CurrentEye;

        protected void Start()
        {
            SanityCheck.Check(this, CurrentEye, Index >= 1 && Index <= 3);

            //switch (Index)
            //{
            //    case 1:
            //        transform.Find("Display").GetComponent<MeshRenderer>().material.color = Color.black;
            //        break;
            //    case 2:
            //        transform.Find("Display").GetComponent<MeshRenderer>().material.color = Color.gray;
            //        break;
            //    case 3:
            //        transform.Find("Display").GetComponent<MeshRenderer>().material.color = Color.white;
            //        break;
            //    default:
            //        DebugLogger.Warn("unexpected index in arrow controller start");
            //        break;
            //}

        }

        protected void Update()
        {
            switch (Index)
            {
                case 1:
                    transform.localRotation = CurrentEye.QuaternionCurrent;
                    break;
                case 2:
                    transform.localRotation = CurrentEye.QuaternionTransform;
                    break;
                case 3:
                    transform.localRotation = CurrentEye.QuaternionFinal;
                    break;
                default:
                    DebugLogger.Warn("unexpected index in arrow controller");
                    break;
            }
        }
    }
}
