using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour
{
    // 회전 속도 변수
    public float rotSpeed = 200f;

    // Update is called once per frame
    void Update()
    {
        // 사용자의 마우스 입력을 받아 물체를 회전시키고 싶다.
        // 1. 마우스 입력을 받는다.
        float mouse_X = Input.GetAxis("Mouse X");
        float mouse_Y = Input.GetAxis("Mouse Y");

        // 2. 마우스 입력 값을 이용해 회전 방향을 결정한다.
        Vector3 dir = new Vector3(-mouse_Y, mouse_X, 0);

        // 3. 회전 방향으로 물체를 회전시킨다.
        // r = r0 + vt
        transform.eulerAngles += dir * rotSpeed * Time.deltaTime;

        // 4. x축 회전(상하 회전) 값을 -90도 ~ 90도 사이로 제한한다.
        Vector3 rot = transform.eulerAngles;
        rot.x = Mathf.Clamp(rot.x, -90f, 90f);
        transform.eulerAngles = rot;
    }
}
