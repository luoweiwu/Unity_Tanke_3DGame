using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FollowCamera : MonoBehaviour {

    public GameObject tank1;
    public GameObject tank2;
    public float size= 0.58f;

    Vector3 p;

    // Use this for initialization
    void Start () {
		Vector3 target=(tank1.transform.position + tank2.transform.position) / 2;
        p = target - transform.position;
	 }
	
	// Update is called once per frame
	void Update () {
        if (tank2 != null&&tank1!=null)
        {
            //计算出两个坦克之间的距离
            transform.position = (tank1.transform.position + tank2.transform.position) / 2 - p;

            //找到两个坦克的中点
            //让摄像机对准中心点
            //根据两点之间的距离，调整摄像机的尺寸
            float distance = Vector3.Distance(tank1.transform.position, tank2.transform.position);
            GetComponent<Camera>().orthographicSize = distance * size + 2f;
        }

        if(tank2 == null || tank1 == null)
        {
            SceneManager.LoadScene("SampleScene");
        }

    }
}
