using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3 (8, 2, 0);

    void Update()
    {
        //// Vector3.MoveTowards(���� ��ġ, ��ǥ ��ġ, �ӵ�):��ü�� ��ǥ ��ġ���� 
        ////�Ű������� �Է��� �ӵ��� �̵������ִ� Vector3 �Լ�
        ////�Է��� �ӵ����̶� ��ü�� �̵� �ӵ��� ���
        //transform.position =
        //    Vector3.MoveTowards(transform.position, target, 2f);

        //Vector3 velo = Vector3.zero;
        ////Vector3.SmoothDamp(���� ��ġ, ��ǥ ��ġ, �����ӵ�, �ӵ�): �ε巯�� �����̵�
        ////�Է��� �ӵ����̶� ��ü�� �̵� �ӵ��� �ݺ��
        //transform.position =
        //    Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);

        ////Lerp:���� ����, SmoothDamp���� ���ӽð��� ��, �Ű������� MoveTowards����
        ////�Ű������� ����Ͽ� �ӵ�����(�� �ִ밪�� 1)
        //transform.position =
        //    Vector3.Lerp(transform.position, target, 0.01f);

        //SLerp:���� ���� ����, ȣ�� �׸��� �̵� 
        transform.position =
            Vector3.Slerp(transform.position, target, 0.1f);
    }
}
