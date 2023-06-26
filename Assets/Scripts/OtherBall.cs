using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{
    MeshRenderer mesh;
    Material mat;

    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }
    
    private void OnCollisionEnter(Collision collision)//�������� �浹�� ���� �� ȣ��, Collision�� �浹 ���� Ŭ����
    {
        if(collision.gameObject.name == "My Ball")
            mat.color = new Color(0,0,0);
    }

    //private void OnCollisionStay(Collision collision)//�������� �浹�� �Ͼ�� ���� �� ȣ��
    //{

    //}

    private void OnCollisionExit(Collision collision)//�������� �浹�� ������ �� ȣ��
    {
        if (collision.gameObject.name == "My Ball")
            mat.color = new Color(1, 1, 1);
    }
}
