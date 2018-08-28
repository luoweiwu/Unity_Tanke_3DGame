using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankHealth : MonoBehaviour {

    public int hp = 100;
    public GameObject ex;
    public Slider slider;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TakeDamage()
    {
        hp -= 30;
        if (hp < 0)
        {
            Destroy(gameObject);
            GameObject go = Instantiate(ex, transform.position, transform.rotation);
        }
        slider.value = hp;

    }

}
