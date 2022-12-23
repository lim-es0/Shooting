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


    private void OnEnable()  //Ȱ��ȭ �� ������ ȣ��Ǵ� �Լ�
    {
        StartCoroutine(Destroy());
    }

    //IEnumerator(�ڷ�ƾ�� ��ȯ Ÿ��), �迭�� Length�� üũ�ϰ� ���� �����Ͱ� �ִ����� ���ο� Current ���� ����

    IEnumerator Destroy()  // IEnumerator(������)�� yield(�纸)�� ����
    {
        yield return new WaitForSeconds(1);  //�� �����ӿ�ũ�� ������ ����� �� ȣ��
        gameObject.SetActive(false);
    }

    private void Update()
    {
        float amount = speed * Time.deltaTime;  
        transform.Translate(Vector3.forward * amount);  
    }

    void OnTriggerEnter(Collider other)   // 
    {
        if(other.tag == "Enemy")  // �浹���� �� tag�� Enemy�� ���
        {

            Score.scoreValue += 10;
            audio.Play();   //���� ���
            other.gameObject.SetActive(false);  // ��Ȱ��ȭ  
            Instantiate(effect, transform.position, transform.rotation);

        }

        
    }

}
