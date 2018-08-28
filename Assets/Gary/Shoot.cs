using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject shell;
    Transform pos;

    public KeyCode key = KeyCode.Space;

    public float speed = 180;

	// Use this for initialization
	void Start () {
        //找到子对象
        pos = transform.Find("FirstPosition");
	}
	
	// Update is called once per frame
	void Update () {
        //按下一个按键
        if (Input.GetKeyDown(key))
        {
            GameObject go = Instantiate(shell,pos.position,pos.rotation);
            go.GetComponent<Rigidbody>().velocity = go.transform.forward * speed;
            //go.GetComponent<Rigidbody>().velocity = Vector3.forward * speed;
        }
	}
}
