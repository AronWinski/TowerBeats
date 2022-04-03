using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BezAnim : MonoBehaviour{
    public Vector3 orientation;
    public BezierCurve path;
    public int time;
    void Start() {
        transform.position = new Vector3(3.0f,1.0f,0.0f);
        Vector3[] definement = {transform.position,new Vector3(0.0f,1.0f,3.0f)};
        path = new BezierCurve(definement, new Vector3(0.0f,1.0f,0.0f));
        time = 0;
    }

    // Update is called once per frame
    void Update() {
        float t = (((float)time)/1000.0f)%1;
        //Debug.Log(t);
        transform.position = path.fetchPosition(t);
        time++;

    }
}
