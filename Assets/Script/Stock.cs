using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stock : MonoBehaviour
{
    // Start is called before the first frame update
    int stock = 3;
    public GameObject stock_object = null;

    void Start()
    {
        PlayerPrefs.SetInt("Stock",3);
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        stock = PlayerPrefs.GetInt("Stock",3);
        Text stock_text = stock_object.GetComponent<Text> ();
        stock_text.text = "ストック：" + stock;
    }
}
