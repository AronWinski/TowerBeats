using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullPathScript{
    public Vector3[] throughPoints;
    public Vector3[] ControlPoints;
    public BezierCurve[] path;
    
    public FullPathScript(){
        throughPoints = new Vector3[]{
            GameObject.Find("StartPoint").transform.position,
            GameObject.Find("MidPoint1").transform.position,
            GameObject.Find("MidPoint2").transform.position,
            GameObject.Find("EndPoint").transform.position
        };

        ControlPoints = new Vector3[]{
            GameObject.Find("ControlPoint1").transform.position,
            GameObject.Find("ControlPoint2").transform.position,
            GameObject.Find("ControlPoint3").transform.position
        };

        path = new BezierCurve[]{
            new BezierCurve(throughPoints[0..2],ControlPoints[0]),
            new BezierCurve(throughPoints[1..3],ControlPoints[1]),
            new BezierCurve(throughPoints[2..4],ControlPoints[2]),
        };
    }

    public Vector3 Location(float t){
        int alpha = ((int)t);
        //Debug.Log(alpha);
        return path[alpha].fetchPosition((t-alpha));
    }
}
