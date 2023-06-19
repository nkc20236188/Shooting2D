using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotCon : MonoBehaviour
{
    Vector3 dir = Vector3.zero;

    float speed = 6f;

    void Start()
    {
        Destroy(gameObject, 4f);
    }

    void Update()
    {
        dir = Vector3.right;

        transform.position += dir.normalized * speed * Time.deltaTime;
    }
}
