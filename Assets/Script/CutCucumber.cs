using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutCucumber : MonoBehaviour
{
    private Rigidbody rb;

    //start画面の時
    void Strat()
    {
        rb = GetComponent<Rigidbody>();
    }

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
    
    //一緒に動くプログラムらしいけど解読ができてない
    //「空のオブジェクト」の小p部へくととなって、床と同一の動きを保つ（落下時の変形を防ぐため）
    void OnCollisionEnter(Collision col) {
      if (transform.parent == null && col.gameObject.name == "DishCube") {
            var emptyObject = new GameObject();
            emptyObject.transform.parent = col.gameObject.transform;
             transform.parent = emptyObject.transform;
        }
      }
 
      void OnCollisionExit(Collision col) {
      if (transform.parent != null && col.gameObject.name == "DishCube") {
          transform.parent = null;
        }
      }
}
