using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPolygonCollider : MonoBehaviour {

    PolygonCollider2D pc;

	// Use this for initialization
	void Awake () {
        pc = GetComponent<PolygonCollider2D>();

	}
	
	// Update is called once per frame
	void Update () {
       
        //print(pc.points[0]);
    }


    public void CreatePolygonShape(List<Vector3> vpos)
    {
        if (vpos.Count != 0)
        {
            for (int i = 0; i < vpos.Count; i++)
            {
                pc.points[i].x = vpos[i].x;
                pc.points[i].y = vpos[i].y;
            }
        }
        
    }
}
