using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public const float moveSpped = 5.0f; // �����̴� �ӵ� ����


    void Start()
    {
      
    }

    void Update()
    {
        moveControl(); //�����̴� �Լ� �����Ӹ��� ȣ��
    }

    void moveControl()
    {


        //Axes�� ���� Ű�� ���� �Ǵ��ϰ� �ӵ��� ������ ������ ���� �̵����� ����
        float distanceX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpped;

        float distanceZ = Input.GetAxis("Vertical") * Time.deltaTime;

        //�̵��� ��ŭ ���� �̵��� �ݿ�
        this.gameObject.transform.Translate(distanceX, 0, distanceZ);
    }


}