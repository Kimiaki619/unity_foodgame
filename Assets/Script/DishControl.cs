using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DishControl : MonoBehaviour
{
    private Vector2 targetpos;

    // Start is called before the first frame update
    void Start()
    {
        targetpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(Mathf.Sin(Time.time)*3.0f + targetpos.x,targetpos.y);
    }
}
