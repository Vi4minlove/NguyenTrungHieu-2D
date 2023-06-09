using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{

    public Transform mCamera;
    public Transform middleBG;
    public Transform sideBG;

    public float length = 216f;

    void Update()
    {
        if (mCamera.position.x > middleBG.position.x)
            sideBG.position = middleBG.position + Vector3.right * length;
        if (mCamera.position.x > sideBG.position.x)
        {
            Transform a = middleBG;
            middleBG = sideBG;
            sideBG = a;
        }

    }
}
