using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Start_Stock : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        PlayerPrefs.SetInt("Stock",3);
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {

    }
}