using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour {

    float Z; float X;
    public float speed = 0.0f;
    float i;

    public float accelUp = 1.0f;
    public float accelDown = 1.0f;
    public float speedWalk = 1.0f;
    public float speedRun = 3.0f;

    // Use this for initialization
    void Start() {


    }

    // Update is called once per frame
    void Update() {

        if (Input.GetButton("run") && (Input.GetAxis("Horizontal")!= 0 || Input.GetAxis("Vertical")!=0))
            speed += Time.deltaTime * accelUp;
        else
            speed -= Time.deltaTime * accelDown;

        speed = Mathf.Clamp(speed, speedWalk, speedRun );
              

        
         X = Input.GetAxis("Horizontal");
         Z = Input.GetAxis("Vertical");

         transform.position = transform.position + new Vector3(X, 0, Z) * Time.deltaTime  * speed;
        
    }
}
