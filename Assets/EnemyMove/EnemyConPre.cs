using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyConPre : MonoBehaviour
{
    float speed = 5;

    Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //X•ûŒü‚ÌˆÚ“®
        Vector3 dir = Vector3.left;

        //¶‚ÉŒ©Ø‚ê‚½‚ç‰E‚©‚ç“oê
        if (transform.position.x < -9f)
        {
            Vector3 pos = transform.position;
            pos.x = 9f;
            transform.position = pos;
        }

        //Y•ûŒü‚ÌˆÚ“®
        //-1 <= Mathf.Sin(Time.time * 5f) <= 1
        //‰~‰^“®
        dir.x = 5f * Mathf.Cos(Time.time * 5f);
        //dir.y =2f * Mathf.Sin(Time.time * 5f);

        //“G‚ÌˆÚ“®•ûŒü‚ğƒvƒŒƒCƒ„[‚Ì‚¢‚é•ûŒü‚É‚·‚é
        //dir = player.position - transform.position;

        //transform.position += dir.normalized * speed * Time.deltaTime;
    }
}
