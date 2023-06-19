using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 dir = Vector3.zero;  //�ړ�������ۑ�����ϐ�
    Animator anm; //�A�j���[�^�[�R���|�[�l���g��ۑ�����
    public GameObject MyShot_0;
    GameObject Player;
    float speed = 2f;

    void Start()
    {
        anm = GetComponent<Animator>(); //�R���|�[�l���g���擾

        Player = GameObject.Find("MyShot_0");
    }

    void Update()
    {
        //�ړ��������Z�b�g
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");

        transform.position += dir.normalized * speed * Time.deltaTime;

        //��ʓ��ړ�����
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -9f, 9f);
        pos.y = Mathf.Clamp(pos.y, -5f, 5f);
        transform.position = pos;

        //�A�j���[�V�����ݒ�
        if (dir.y == 0)
        {
            anm.Play("Player");
        }
        else if (dir.y == 1)
        {
            anm.Play("PlayerL");
        }
        else
        {
            anm.Play("PlayerR");
        }

        //�V���b�g
        if (Input.GetKeyDown(KeyCode.Z))
        {
            GameObject MyShot = Instantiate(MyShot_0, transform.position +
                transform.forward * 3 + transform.up * 1, transform.rotation)
                as GameObject;
            MyShot.transform.position = this.transform.position;
        }
    }
}
