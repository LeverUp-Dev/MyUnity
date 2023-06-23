using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3 (8, 2, 0);

    void Update()
    {
        //// Vector3.MoveTowards(현재 위치, 목표 위치, 속도):객체를 목표 위치까지 
        ////매개변수로 입력한 속도로 이동시켜주는 Vector3 함수
        ////입력한 속도값이랑 물체의 이동 속도가 비례
        //transform.position =
        //    Vector3.MoveTowards(transform.position, target, 2f);

        //Vector3 velo = Vector3.zero;
        ////Vector3.SmoothDamp(현재 위치, 목표 위치, 참조속도, 속도): 부드러운 감속이동
        ////입력한 속도값이랑 물체의 이동 속도가 반비례
        //transform.position =
        //    Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);

        ////Lerp:선형 보간, SmoothDamp보다 감속시간이 김, 매개변수는 MoveTowards동일
        ////매개변수에 비례하여 속도증가(단 최대값이 1)
        //transform.position =
        //    Vector3.Lerp(transform.position, target, 0.01f);

        //SLerp:구면 선형 보간, 호를 그리며 이동 
        transform.position =
            Vector3.Slerp(transform.position, target, 0.1f);
    }
}
