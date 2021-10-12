using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutCucumber : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //下に落ちる
        //transform.Translate (0, -0.1f, 0);
        
        //画面外になったら消すようにする。
        if (transform.position.y < -5) {
            Destroy (gameObject);
        }        
    }
}
