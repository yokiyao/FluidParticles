using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testUpdate : MonoBehaviour {

	// Use this for initialization
	void Start () {
        isShow = true;
        if (!isShow) Destroy(this.gameObject);
    }
    bool isShow;
    // Update is called once per frame
    void FixedUpdate() {
        // print("d");
        if (Input.GetKeyDown(KeyCode.D)) isShow = !isShow;
        if (isShow) Destroy(this.gameObject);
    }
}
