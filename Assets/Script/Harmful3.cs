using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harmful3 : MonoBehaviour
{
    private Vector2 targetpos;

    //スピードの変数
    private float spead;

    // Start is called before the first frame update
    void Start()
    {
        targetpos = transform.position;
        spead = -2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(Mathf.Cos(2*Time.time)*spead + targetpos.x, Mathf.Sin(Time.time)*spead + targetpos.y);
        
    }
}
