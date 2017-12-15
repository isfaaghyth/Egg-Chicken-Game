using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

    public float speed = 5f;

    public float batasKiri = -3;
    public float batasKanan = 3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D)) {
            jalanKanan();
        } else if (Input.GetKey(KeyCode.A)) {
            jalanKiri();
        }
	}

    void jalanKiri() {
        if (transform.position.x > batasKiri) {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
    }

    void jalanKanan() {
        if (transform.position.x < batasKanan) {
			transform.Translate(Vector2.right * speed * Time.deltaTime);
		}
    }
}
