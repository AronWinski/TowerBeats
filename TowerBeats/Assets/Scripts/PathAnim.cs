using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathAnim: MonoBehaviour {
    // Start is called before the first frame update
    public FullPathScript path;
    public int time;
    void Start(){
        path = new FullPathScript();
        transform.position = GameObject.Find("StartPoint").transform.position;
    }

    // Update is called once per frame
    void Update(){
        float t = (((float)time)/1000.0f)%3.0f;
        //Debug.Log(t);
        transform.position =
         path.Location(t);
        time++;
        
    }
}
