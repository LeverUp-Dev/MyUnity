using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    Rigidbody rigid;

    void Start()
    {
        //velocity: ���� �̵� �ӵ�
        //AddForce(new): new�� ���� ����, ForceMode�� ���� �ִ� ���(rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);)
        rigid = GetComponent<Rigidbody>();
    }

    //Rigidbody �����ڵ�� void FixedUpdate()���� �ۼ� ����
    void FixedUpdate()
    {
        //1.�ӷ� �ٲٱ�
        //rigid.velocity = Vector3.forward;

        //2.���� ���ϱ�
        /*
        if (Input.GetButtonDown("Jump")) {
            rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
            Debug.Log(rigid.velocity);
        }

        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal"),
            0, Input.GetAxisRaw("Vertical"));

        rigid.AddForce(vec, ForceMode.Impulse); */

        //3.ȸ����
        //rigid.AddTorque(Vector3.down);
    }
}
