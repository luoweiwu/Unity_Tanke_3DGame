using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed = 10;
    public float angularSpeed = 5;

    public string player = "1";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //获得玩家的键盘输入
        float v = Input.GetAxis("Vertical"+player);
        float h = Input.GetAxis("Horizontal"+ player);
       
        //让坦克前后移动
        GetComponent<Rigidbody>().velocity = transform.forward * v * speed;
        GetComponent<Rigidbody>().angularVelocity = transform.up * h * angularSpeed;

    }
}
