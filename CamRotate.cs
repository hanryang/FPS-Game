using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        // 사용자의 마우스 입력을 받아 물체를 회전시키고 싶다.
        // 1. 마우스 입력을 받는다.
        float mouse_X = Input.GetAxis("Mouse X");
        float mouse_Y = Input.GetAxis("Mouse Y");
    }
}
