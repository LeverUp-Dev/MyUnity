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
    //Time.deltaTime은 pc마다 프레임 출력이 다르기 때문에
    //주로 온라인 게임에서 초당 플레임 조절을 해서 각자 동일한 시간의 게임을 할 수 있도록
    //하기위한 내장함수이다.
}
