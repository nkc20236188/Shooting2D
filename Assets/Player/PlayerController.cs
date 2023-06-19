using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 dir = Vector3.zero;  //移動方向を保存する変数
    Animator anm; //アニメーターコンポーネントを保存する
    public GameObject MyShot_0;
    GameObject Player;
    float speed = 2f;

    void Start()
    {
        anm = GetComponent<Animator>(); //コンポーネントを取得

        Player = GameObject.Find("MyShot_0");
    }

    void Update()
    {
        //移動方向をセット
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");

        transform.position += dir.normalized * speed * Time.deltaTime;

        //画面内移動制限
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -9f, 9f);
        pos.y = Mathf.Clamp(pos.y, -5f, 5f);
        transform.position = pos;

        //アニメーション設定
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

        //ショット
        if (Input.GetKeyDown(KeyCode.Z))
        {
            GameObject MyShot = Instantiate(MyShot_0, transform.position +
                transform.forward * 3 + transform.up * 1, transform.rotation)
                as GameObject;
            MyShot.transform.position = this.transform.position;
        }
    }
}
