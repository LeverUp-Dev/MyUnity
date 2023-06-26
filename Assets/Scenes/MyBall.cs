using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    Rigidbody rigid;

    void Start()
    {
        //velocity: 현재 이동 속도
        //AddForce(new): new는 힘의 방향, ForceMode는 힘을 주는 방식(rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);)
        rigid = GetComponent<Rigidbody>();
    }

    //Rigidbody 관련코드는 void FixedUpdate()에서 작성 권장
    void FixedUpdate()
    {
        //1.속력 바꾸기
        //rigid.velocity = Vector3.forward;

        //2.힘을 가하기
        /*
        if (Input.GetButtonDown("Jump")) {
            rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
            Debug.Log(rigid.velocity);
        }

        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal"),
            0, Input.GetAxisRaw("Vertical"));

        rigid.AddForce(vec, ForceMode.Impulse); */

        //3.회전력
        //rigid.AddTorque(Vector3.down);
    }
}
