using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Vector3 dir = Vector3.zero;  //�ړ�����
    float speed = 5;  //�ړ����x
    Animator anim;
    

    void Start()
    {
        //����4�b
        Destroy(gameObject, 4f);

        //�A�j���[�^�[�R���|�[�l���g�̏���ۑ�
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        dir = Vector3.left;
        transform.position += dir.normalized * speed * Time.deltaTime;
        //for (int i = 0; i <1; i++)
        //{
        //    int random = 0;
        //    random = UnityEngine.Random.Range(0, 10);

        //    if (random < 8)
        //    {
        //        dir = Vector3.left;
        //        transform.position += dir.normalized * speed * Time.deltaTime;
        //    }
        //    else
        //    {
        //        dir = Vector3.left;
        //        dir.y = 5f * Mathf.Sin(Time.time * 5f);
        //        transform.position += dir.normalized * speed * Time.deltaTime;
        //    }
        //}
    }

    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.name == "Player")
        {
            //�������Ԃ�10�b���炷
            GameDrector.lastTime -= 10;

            //���������炷
            GameDrector.distance -= 1000f;


            //�v���C���[�Əd�Ȃ��������
            Destroy(gameObject);
        }
        if (c.gameObject.name == "MyShot_0(Clone)")
        {
            GameDrector.distance += 200f;

            Destroy(gameObject);

            Destroy(c.gameObject);
        }
    }
}
