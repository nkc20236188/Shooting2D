using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject EnemyPre; //“G‚ÌƒvƒŒƒnƒu‚ð•Û‘¶‚·‚é•Ï”

    float delta;  //Œo‰ßŽžŠÔŒvŽZ—p

    float span;  //“G‚ðo‚·ŠÔŠu(•b)‚ð•Û‘¶‚·‚é

    void Start()
    {
        delta = 0;
        span = 1;
    }

    void Update()
    {
        //Œo‰ßŽžŠÔ‚ð‰ÁŽZ
        delta += Time.deltaTime;

        if (delta > span)
        {
            //“G‚ð¶¬‚·‚é
            GameObject go = Instantiate(EnemyPre);
            float py = Random.Range(-4.5f, 4.5f);
            go.transform.position = new Vector3(10, py, 0);

            //ŽžŠÔŒo‰ß‚ð•Û‘¶‚µ‚Ä‚¢‚é•Ï”‚ð0ƒNƒŠƒA‚·‚é
            delta = 0;

            //“G‚ðo‚·ŠÔŠu‚ð™X‚É’Z‚­‚·‚é
            span -= (span > 0.3f)? 0.03f : 0f;
        }
    }
}
