using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal") * Time.deltaTime ,
            Input.GetAxisRaw("vertical") * Time.deltaTime);
        transform.position = vec;
    }
    //Time.deltaTime�� pc���� ������ ����� �ٸ��� ������
    //�ַ� �¶��� ���ӿ��� �ʴ� �÷��� ������ �ؼ� ���� ������ �ð��� ������ �� �� �ֵ���
    //�ϱ����� �����Լ��̴�.
}
