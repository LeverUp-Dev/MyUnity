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
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(h, 0, v);

        rigid.AddForce(vec, ForceMode.Impulse);

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

        rigid.AddForce(vec, ForceMode.Impulse);*/

        //3.ȸ����
        //rigid.AddTorque(Vector3.down);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "Cube")
            rigid.AddForce(Vector3.up * 6, ForceMode.Impulse);
    }

    //�ݶ��̴� �浹 �̺�Ʈ �Լ�
    void OnTriggerEnter() { }
    void OnTriggerStay() { }
    void OnTriggerExit() { }

    //������ �浹�� �߻��ϴ� �̺�Ʈ �Լ�
    void OnCollisionEnter() { }
    void OnCollisionStay() { }
    void OnCollisionExit() { }
}
