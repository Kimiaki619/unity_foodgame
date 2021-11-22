using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour
{
    // Start is called before the first frame update
    public static Dictionary<string, string> Stage_dict;

    void Start()
    {
    //ステージ遷移のための辞書["現在のステージ","遷移するステージ"]
    //CutCucumber.csでつかう
    Stage_dict = new Dictionary<string, string> ();
    Stage_dict ["SampleScene"] = "TwoLebel";
    Stage_dict ["TwoLebel"] = "ThreeLebel";
    Stage_dict ["ThreeLebel"] = "ForthLebel";
    Stage_dict ["ForthLebel"] = "FiveLebel";
    Stage_dict ["FiveLebel"] = "SixLebel";
    Stage_dict ["SixLebel"] = "SampleScene";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
