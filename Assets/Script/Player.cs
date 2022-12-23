using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public const float moveSpped = 5.0f; // 움직이는 속도 정의


    void Start()
    {
      
    }

    void Update()
    {
        moveControl(); //움직이는 함수 프레임마다 호출
    }

    void moveControl()
    {


        //Axes를 통해 키의 방향 판단하고 속도와 프레임 판정을 곱해 이동량을 정함
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpped;

        float distanceZ = Input.GetAxis("Vertical") * Time.deltaTime;

        //이동량 만큼 실제 이동에 반영
        this.gameObject.transform.Translate(distanceX, 0, distanceZ);
    }


}