using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Start_score : MonoBehaviour
{
    // Start is called before the first frame update
    int bestscore = 0;
    //Textをぶち込むためのオブジェクト。インスペクターで設定する
    public GameObject score_object = null;

    void Start()
    {
        PlayerPrefs.SetInt("Score",0);
        PlayerPrefs.Save();
        bestscore = PlayerPrefs.GetInt("BestScore",0);
        Text score_text = score_object.GetComponent<Text> ();
        score_text.text = "ベストスコア：" + bestscore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
