using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    Transform playerTransform;
    Vector3 offSet;

    void Awake()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        offSet = transform.position - playerTransform.position;
    }
    //카메라는 LateUpdate를 쓰는 것이 좋음(플레이어 따라붙는 후속 실행이기 때문)
    void LateUpdate()
    {
        transform.position = playerTransform.position + offSet;
    }
}
