namespace Fang.UserInterface
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;
    using Coreficent.Utility;
    using Coreficent.Controller;

    public class EquationValueDisplayer : MonoBehaviour
    {
        public EyeController EyeController;

        [SerializeField] private InputField inputfieldQ1a;
        [SerializeField] private InputField inputfieldQ1b;
        [SerializeField] private InputField inputfieldQ1c;
        [SerializeField] private InputField inputfieldQ1d;

        [SerializeField] private InputField inputfieldQ1a1, inputfieldQ1a2, inputfieldQ1a3, inputfieldQ1a4;
        [SerializeField] private InputField inputfieldQ1b1, inputfieldQ1b2, inputfieldQ1b3, inputfieldQ1b4;
        [SerializeField] private InputField inputfieldQ1c1, inputfieldQ1c2, inputfieldQ1c3, inputfieldQ1c4;
        [SerializeField] private InputField inputfieldQ1d1, inputfieldQ1d2, inputfieldQ1d3, inputfieldQ1d4;

        [SerializeField] private InputField inputfieldQ2e;
        [SerializeField] private InputField inputfieldQ2f;
        [SerializeField] private InputField inputfieldQ2g;
        [SerializeField] private InputField inputfieldQ2h;

        [SerializeField] private InputField inputfieldQ2e1, inputfieldQ2e2, inputfieldQ2e3, inputfieldQ2e4;
        [SerializeField] private InputField inputfieldQ2f1, inputfieldQ2f2, inputfieldQ2f3, inputfieldQ2f4;
        [SerializeField] private InputField inputfieldQ2g1, inputfieldQ2g2, inputfieldQ2g3, inputfieldQ2g4;
        [SerializeField] private InputField inputfieldQ2h1, inputfieldQ2h2, inputfieldQ2h3, inputfieldQ2h4;

        [SerializeField] private InputField inputfieldQ3w;
        [SerializeField] private InputField inputfieldQ3x;
        [SerializeField] private InputField inputfieldQ3y;
        [SerializeField] private InputField inputfieldQ3z;

        // Start is called before the first frame update
        void Start()
        {            

        }

        // Update is called once per frame
        void Update()
        {
            inputfieldQ1a.text = EyeController.QuaternionCurrent.w.ToString();
            inputfieldQ1b.text = EyeController.QuaternionCurrent.x.ToString();
            inputfieldQ1c.text = EyeController.QuaternionCurrent.y.ToString();
            inputfieldQ1d.text = EyeController.QuaternionCurrent.z.ToString();

            inputfieldQ1a1.text = inputfieldQ1a2.text = inputfieldQ1a3.text = inputfieldQ1a4.text = EyeController.QuaternionCurrent.w.ToString();
            inputfieldQ1b1.text = inputfieldQ1b2.text = inputfieldQ1b3.text = inputfieldQ1b4.text = EyeController.QuaternionCurrent.x.ToString();
            inputfieldQ1c1.text = inputfieldQ1c2.text = inputfieldQ1c3.text = inputfieldQ1c4.text = EyeController.QuaternionCurrent.y.ToString();
            inputfieldQ1d1.text = inputfieldQ1d2.text = inputfieldQ1d3.text = inputfieldQ1d4.text = EyeController.QuaternionCurrent.z.ToString();

            inputfieldQ2e.text = EyeController.QuaternionTransform.w.ToString();
            inputfieldQ2f.text = EyeController.QuaternionTransform.x.ToString();
            inputfieldQ2g.text = EyeController.QuaternionTransform.y.ToString();
            inputfieldQ2h.text = EyeController.QuaternionTransform.z.ToString();

            inputfieldQ2e1.text = inputfieldQ2e2.text = inputfieldQ2e3.text = inputfieldQ2e4.text = EyeController.QuaternionTransform.w.ToString();
            inputfieldQ2f1.text = inputfieldQ2f2.text = inputfieldQ2f3.text = inputfieldQ2f4.text = EyeController.QuaternionTransform.x.ToString();
            inputfieldQ2g1.text = inputfieldQ2g2.text = inputfieldQ2g3.text = inputfieldQ2g4.text = EyeController.QuaternionTransform.y.ToString();
            inputfieldQ2h1.text = inputfieldQ2h2.text = inputfieldQ2h3.text = inputfieldQ2h4.text = EyeController.QuaternionTransform.z.ToString();

            inputfieldQ3w.text = EyeController.QuaternionFinal.w.ToString();
            inputfieldQ3x.text = EyeController.QuaternionFinal.x.ToString();
            inputfieldQ3y.text = EyeController.QuaternionFinal.y.ToString();
            inputfieldQ3z.text = EyeController.QuaternionFinal.z.ToString();

        }
    }
}
