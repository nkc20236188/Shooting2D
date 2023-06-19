using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Vector3 dir = Vector3.zero;  //移動方向
    float speed = 5;  //移動速度
    Animator anim;
    

    void Start()
    {
        //寿命4秒
        Destroy(gameObject, 4f);

        //アニメーターコンポーネントの情報を保存
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
            //制限時間を10秒減らす
            GameDrector.lastTime -= 10;

            //距離を減らす
            GameDrector.distance -= 1000f;


            //プレイヤーと重なったら消す
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
