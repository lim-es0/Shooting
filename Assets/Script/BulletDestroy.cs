using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletDestroy : MonoBehaviour
{
   
    float speed = 10f;
    public GameObject effect;


    AudioSource audio;


    void Awake()
    {
        audio = GetComponent<AudioSource>();
    }


    private void OnEnable()  //활성화 될 때마다 호출되는 함수
    {
        StartCoroutine(Destroy());
    }

    //IEnumerator(코루틴의 반환 타입), 배열의 Length를 체크하고 다음 데이터가 있는지의 여부와 Current 값을 저장

    IEnumerator Destroy()  // IEnumerator(열거자)와 yield(양보)의 관계
    {
        yield return new WaitForSeconds(1);  //한 프레임워크가 완전히 종료될 때 호출
        gameObject.SetActive(false);
    }

    private void Update()
    {
        float amount = speed * Time.deltaTime;  
        transform.Translate(Vector3.forward * amount);  
    }

    void OnTriggerEnter(Collider other)   // 
    {
        if(other.tag == "Enemy")  // 충돌했을 때 tag가 Enemy인 경우
        {

            Score.scoreValue += 10;
            audio.Play();   //사운드 출력
            other.gameObject.SetActive(false);  // 비활성화  
            Instantiate(effect, transform.position, transform.rotation);

        }

        
    }

}
