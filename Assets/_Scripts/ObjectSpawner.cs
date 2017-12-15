using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour {

    public GameObject[] objects;
    public int[] timer;

	// Use this for initialization
	void Start () {
        Invoke("spawnObject", timer[Random.Range(0, timer.Length)]);
	}

    public void spawnObject() {
        int rand = Random.Range(0, objects.Length);
        Instantiate(objects[rand], 
                    new Vector3(this.transform.position.x, this.transform.position.y,this.transform.position.z),
                    Quaternion.identity);
        Invoke("spawnObject", timer[Random.Range(0, timer.Length)]);
    }
}
