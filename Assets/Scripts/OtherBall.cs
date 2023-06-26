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
    
    private void OnCollisionEnter(Collision collision)//물리적인 충돌을 했을 때 호출, Collision는 충돌 정보 클래스
    {
        if(collision.gameObject.name == "My Ball")
            mat.color = new Color(0,0,0);
    }

    //private void OnCollisionStay(Collision collision)//물리적인 충돌이 일어나고 있을 때 호출
    //{

    //}

    private void OnCollisionExit(Collision collision)//물리적인 충돌이 끝났을 때 호출
    {
        if (collision.gameObject.name == "My Ball")
            mat.color = new Color(1, 1, 1);
    }
}
