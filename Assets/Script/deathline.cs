using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deathline : MonoBehaviour
{

    public GameObject effect;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            Debug.Log("µ¥¹ÌÁö -10 ");
            Score.scoreValue -= 10;
            damage.currenthp -= 10;
            Instantiate(effect, transform.position, transform.rotation);
        }


    }
}
