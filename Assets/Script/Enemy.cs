using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //  private 변수를 인스펙터에서 접근가능하게 [SerializeFiled]를 사용
    
    [SerializeField]
    private float _speed;

    void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime, Space.Self);

        if(transform.position.z <= -10)
        {
            float RNG = Random.Range(-2, 2); 
            transform.position = new Vector3(RNG, 3, 3); 
        }
    }
}
