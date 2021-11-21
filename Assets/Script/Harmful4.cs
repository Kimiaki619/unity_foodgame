using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harmful4 : MonoBehaviour
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
        transform.position = new Vector2(Mathf.Cos(spead*Time.time)*2.0f + targetpos.x,Mathf.Sin(spead*Time.time)*0.8f +targetpos.y);
        
    }
}