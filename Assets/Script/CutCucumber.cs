using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // UnityEngine.SceneManagemntの機能を使用

public class CutCucumber : MonoBehaviour
{
    private Rigidbody rb;
    //ここにライフを入れる
    public GameObject heart;
    int score = 0; 
    int stock = 3;

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
            //ストックを減らして0になったらゲーム終了
            stock = PlayerPrefs.GetInt("Stock",3);
            PlayerPrefs.SetInt("Stock",stock-1);
            PlayerPrefs.Save();
            if (stock == 1) {
              Time.timeScale = 0f;
            }  
        }
    }
    
    //一緒に動くプログラムらしいけど解読ができてない
    //「空のオブジェクト」の小p部へくととなって、床と同一の動きを保つ（落下時の変形を防ぐため）
    //OnCollisionEnterは当たった時に呼ばれる関数
    void OnCollisionEnter(Collision col) {
      if ((transform.parent == null && col.gameObject.name == "DishCube") || (transform.parent == null && col.gameObject.name == "CutCucumber(Clone)")) {
            var emptyObject = new GameObject();
            emptyObject.transform.parent = col.gameObject.transform;
             transform.parent = emptyObject.transform;
              //以下でスコアの更新を行う。とりあえずオブジェクトがぶつかったらスコアが入るようになってる。
             score = PlayerPrefs.GetInt("Score",0);
             PlayerPrefs.SetInt("Score",score+100);
             PlayerPrefs.Save ();
             //ステージ遷移。一瞬で変わってしまう。クリアーや開始画面など何か処理を挟む必要
             SceneManager.LoadScene(Stage.Stage_dict[SceneManager.GetActiveScene().name]);
             
        }

      }
      
 
      void OnCollisionExit(Collision col) {
      if (transform.parent != null && col.gameObject.name == "DishCube") {
          transform.parent = null;
        }
      }
}
