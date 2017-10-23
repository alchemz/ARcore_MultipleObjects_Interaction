//reference: https://docs.unity3d.com/ScriptReference/Vector3.Lerp.html
//move from one endpoint  to anther endpoint
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectToMove : MonoBehaviour {
    public Transform startMarker;
    public Vector3 endMarker;
    public float speed = 0.1F;
    private float startTime;
    private float journeyLength;

	// Use this for initialization
	void Start () {
        journeyLength =0;
	}

    void Update()
    {
        if (journeyLength > 0)
        {
            float distCovered = (Time.time - startTime) * speed;
            float fracJourney = distCovered / journeyLength;
            transform.position = Vector3.Lerp(startMarker.position, endMarker, fracJourney);
        }
    }
	
    public void HitToMove(Vector3 endPos)
    {
        startMarker = this.transform;
        endMarker = endPos;
        startTime = Time.time;
        journeyLength = Vector3.Distance(startMarker.position, endMarker);
       
    }
}
