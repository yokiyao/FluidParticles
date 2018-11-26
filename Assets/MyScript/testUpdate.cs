using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testUpdate : MonoBehaviour {
    //public TriggerColliders tc;

    private void Awake()
    {
        //tc = GameObject.Find("depthdata").GetComponent<TriggerColliders>();
    }
    // Use this for initialization
    void Start () {
        //isShow = tc.isShow;
        //if (!isShow)
        //Destroy(this.gameObject);
    }
    bool isShow;
    // Update is called once per frame
    void FixedUpdate() {
        //isShow = tc.isShow;
        // print("d");
        //if (Input.GetKeyDown(KeyCode.D)) isShow = !isShow;
        //if (isShow) 
        Destroy(this.gameObject);
    }
}
