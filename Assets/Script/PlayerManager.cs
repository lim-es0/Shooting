using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager: MonoBehaviour
{
    void Update()
    {

        // ���� hp�� 0�̰ų� �װͺ��� ������ ���ӿ��� ������ ��� ��ȯ
        if(damage.currenthp <= 0)
            SceneManager.LoadScene(1);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")

        SceneManager.LoadScene(1);
    }

}
