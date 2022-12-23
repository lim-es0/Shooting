using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class action : MonoBehaviour
{

    public GameObject bullet;   //������ ���
    public List<GameObject> bulletPooling;  //������ ����� �־���� ������Ʈ Ǯ
    int maxPoolingSize = 10;  //Ǯ�� �ִ� ������
    int currentPoolingSize = 0;  //���� Ǯ�� ������
    GameObject tempBullet;  //�ӽ� ��ü

    AudioSource audio;

    void Awake() // Ŭ������ �ʱ�ȭ �� �� ȣ��Ǵ� �̺�Ʈ �Լ�
    {
        audio = GetComponent<AudioSource>();
    }


    void Start()
    {
        bulletPooling = new List<GameObject>();

        // pool �ʱ�ȭ
        for(int i = 0; i < maxPoolingSize; i++)
        {
            tempBullet = Instantiate(bullet);  //���
            tempBullet.SetActive(false);  // ��Ȱ��ȭ
            bulletPooling.Add(tempBullet);  //pool�� �ֱ�
        }
    }


    void Update()
    {
        PoolingOut();  
    }

    void PoolingOut()
    {
        if (Input.GetButtonUp("Fire1"))  //"Fire1" ��ư�� ������ ��
        {

            audio.Play(); // ���� ���

            if (bulletPooling[currentPoolingSize].activeSelf) // �߻�Ǿ���ϴ� ������ �Ѿ��� ������ �߻��� �� ��� ���ư��� ���̶��, �߻�X
            {
                return;
            }

            bulletPooling[currentPoolingSize].transform.position = this.transform.position; //�߻� �Ѿ� ��ġ �÷��̾�� �����ϰ�

            bulletPooling[currentPoolingSize].SetActive(true);  //Ȱ��ȭ
            currentPoolingSize++;  //���� pool ������ ����
            if (currentPoolingSize >= maxPoolingSize) currentPoolingSize = 0;  //���� pool�� ����� pool�� �ִ� ����� �Ѿ�� ���� Ǯ������ 0���� �ʱ�ȭ


        }
    }
}
