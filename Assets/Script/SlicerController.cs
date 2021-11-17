using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlicerController : MonoBehaviour
{   
    public GameObject CutCucumberPrefab;

     // Update is called once per frame

    void Update()
    {
        if (Input.GetKey (KeyCode.LeftArrow)) {
            transform.Translate (-0.1f, 0, 0);
        }
        if (Input.GetKey (KeyCode.RightArrow)) {
            transform.Translate (0.1f, 0, 0);
        }
        if (transform.position.x <= 0.045 & transform.position.x >= -0.045) {
            Instantiate (CutCucumberPrefab, transform.position, Quaternion.identity);
        }
    }
}
