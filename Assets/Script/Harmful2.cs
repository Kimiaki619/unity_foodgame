using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harmful2 : MonoBehaviour
{
    private Vector2 targetpos;

    //スピードの変数
    public float spead;
    public int pulsmai = -1;

    // Start is called before the first frame update
    void Start()
    {
        targetpos = transform.position;
        //spead = -2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(pulsmai*Mathf.Cos(spead*Time.time)*3.0f + targetpos.x,targetpos.y);
        
    }
}
