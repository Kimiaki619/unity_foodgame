using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
//ScoreManagerにセットした
{
    // Start is called before the first frame update
    int score = 0;
    //Textをぶち込むためのオブジェクト。インスペクターで設定する
    public GameObject score_object = null;

    void Start()
    {
        PlayerPrefs.SetInt("Score",0);
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        //CutCucumberの方で保存されたスコアを取り出して画面に表示
        //そのスコアがベストスコアと比べて大きければベストスコアを更新
        score = PlayerPrefs.GetInt("Score",0);
        if (score > PlayerPrefs.GetInt("BestScore",0)) {
            PlayerPrefs.SetInt("BestScore",score);
        }
        //Debug.Log(score);
        Text score_text = score_object.GetComponent<Text> ();
        score_text.text = "スコア：" + score;
    }
}
