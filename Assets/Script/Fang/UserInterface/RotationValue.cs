using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationValue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI()
    {
        GUIStyle style = new GUIStyle();
        style.fontSize = 24;
        //GUI.Label(new Rect(10, 0, 0, 0), "Rotating on X:" + x + " Y:" + y + " Z:" + z, style);

        GUI.Label(new Rect(10, 25, 0, 0), "Transform.eulerAngle: " + transform.eulerAngles, style);
    }
}
