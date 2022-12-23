using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public void SceneChange()
    { 
        SceneManager.LoadScene("SampleScene");

        Score.scoreValue = 0;
        damage.currenthp = 100;
    }
}