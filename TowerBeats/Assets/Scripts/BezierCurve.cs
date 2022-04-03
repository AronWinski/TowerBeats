using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BezierCurve
{
    public Vector3[] endpoints;
    public Vector3 controlPoint;
    public BezierCurve(Vector3[] epoints, Vector3 cpoint ){
        endpoints = epoints[0..2];
        controlPoint = cpoint;
    }

    public Vector3 fetchPosition(float i){
        return Vector3.Lerp( Vector3.Lerp( endpoints[0] ,controlPoint ,i ) , Vector3.Lerp( controlPoint,endpoints[1] , i ) , i );
    }
}
