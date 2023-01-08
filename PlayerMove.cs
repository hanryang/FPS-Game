using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // 이동 속도 변수
    public float moveSpeed = 7f;

    // Update is called once per frame
    void Update()
    {
        // w,a,s,d 키를 누르면 입력하면 캐릭터를 그 방향으로 이동시키고 싶다.

        // 1. 사용자의 입력을 받는다.
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // 2. 이동 방향을 설정한다.
        Vector3 dir = new Vector3(h, 0, v);
        dir = dir.normalized;
        
        // 3. 이동 속도에 맞춰 이동한다.
        // p = p0 + vt
        transform.position += dir * moveSpeed * Time.deltaTime;
    }
}
