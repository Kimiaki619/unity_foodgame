using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlicerController : MonoBehaviour
{   
    public GameObject CutCucumberPrefab;
    bool p = false;

     // Update is called once per frame

    void Update()
    {
        if (Input.GetKey (KeyCode.LeftArrow)) {
            transform.Translate (-0.1f, 0, 0);
        }
        if (Input.GetKey (KeyCode.RightArrow)) {
            transform.Translate (0.1f, 0, 0);
        }
        //きゅうり生成
        if (transform.position.x <= -0.1 ) {
                p = true;
        }
        if (transform.position.x >= 0.05 ) {
            if (p == true) {
                Instantiate (CutCucumberPrefab, transform.position, Quaternion.identity);
            p = false;
        }
        }

    }
}
