using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConPre : MonoBehaviour
{
    Vector3 dir = Vector3.zero;
    float speed = 7f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");

        transform.position += dir.normalized * speed * Time.deltaTime;
    }
}
