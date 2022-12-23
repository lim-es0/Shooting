using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class damage : MonoBehaviour
{
    public static int currenthp = 100;
    Text Health;

    public GameObject effect;

    // Start is called before the first frame update
    void Start()
    {
        Health = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Health.text = "HP   " + currenthp;
    }

 
}
