using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager: MonoBehaviour
{
    void Update()
    {

        // 현재 hp가 0이거나 그것보다 작으면 게임오버 씬으로 장면 전환
        if(damage.currenthp <= 0)
            SceneManager.LoadScene(1);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")

        SceneManager.LoadScene(1);
    }

}
