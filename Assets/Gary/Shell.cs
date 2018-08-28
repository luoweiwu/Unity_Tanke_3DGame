using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour {

    public GameObject ex;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        GameObject go = Instantiate(ex,transform.position,transform.rotation);
        //判断是否打中坦克
        if(collision.gameObject.tag == "Tank")
        {
            collision.gameObject.GetComponent<TankHealth>().TakeDamage();
        }
        //扣除坦克的血量

    }
}
