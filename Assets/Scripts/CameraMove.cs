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
    //ī�޶�� LateUpdate�� ���� ���� ����(�÷��̾� ����ٴ� �ļ� �����̱� ����)
    void LateUpdate()
    {
        transform.position = playerTransform.position + offSet;
    }
}
