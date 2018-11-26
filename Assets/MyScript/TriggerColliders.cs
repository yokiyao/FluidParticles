using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerColliders : MonoBehaviour {

    public bool isShow;
	// Use this for initialization
	void Start () {
        isShow = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.D)) isShow = !isShow;
    }
}
