using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class action : MonoBehaviour
{

    public GameObject bullet;   //복제할 대상
    public List<GameObject> bulletPooling;  //복제할 대상을 넣어놓을 오브젝트 풀
    int maxPoolingSize = 10;  //풀의 최대 사이즈
    int currentPoolingSize = 0;  //현재 풀의 사이즈
    GameObject tempBullet;  //임시 객체

    AudioSource audio;

    void Awake() // 클래스가 초기화 될 때 호출되는 이벤트 함수
    {
        audio = GetComponent<AudioSource>();
    }


    void Start()
    {
        bulletPooling = new List<GameObject>();

        // pool 초기화
        for(int i = 0; i < maxPoolingSize; i++)
        {
            tempBullet = Instantiate(bullet);  //담기
            tempBullet.SetActive(false);  // 비활성화
            bulletPooling.Add(tempBullet);  //pool에 넣기
        }
    }


    void Update()
    {
        PoolingOut();  
    }

    void PoolingOut()
    {
        if (Input.GetButtonUp("Fire1"))  //"Fire1" 버튼을 눌렀을 때
        {

            audio.Play(); // 사운드 출력

            if (bulletPooling[currentPoolingSize].activeSelf) // 발사되어야하는 순번의 총알이 이전에 발사한 후 계속 날아가는 중이라면, 발사X
            {
                return;
            }

            bulletPooling[currentPoolingSize].transform.position = this.transform.position; //발사 총알 위치 플레이어와 동일하게

            bulletPooling[currentPoolingSize].SetActive(true);  //활성화
            currentPoolingSize++;  //현재 pool 사이즈 증가
            if (currentPoolingSize >= maxPoolingSize) currentPoolingSize = 0;  //현재 pool의 사이즈가 pool의 최대 사이즈를 넘어가면 현재 풀사이즈 0으로 초기화


        }
    }
}
