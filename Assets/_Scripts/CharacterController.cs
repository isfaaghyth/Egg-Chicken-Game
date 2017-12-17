using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {

    private float screenCenterX;

    public float speed = 5f;

    public float batasKiri = -3;
    public float batasKanan = 3;

	// Use this for initialization
	void Start () {
		screenCenterX = Screen.width * 0.5f;
	}
	
	// Update is called once per frame
	void Update () {
		//if (Input.GetKey(KeyCode.D)) {
		//    jalanKanan();
		//} else if (Input.GetKey(KeyCode.A)) {
		//    jalanKiri();
		//}
		// if there are any touches currently
		if (Input.touchCount > 0)
		{
			// get the first one
			Touch firstTouch = Input.GetTouch(0);

			// if it began this frame
			if (firstTouch.phase == TouchPhase.Began)
			{
				if (firstTouch.position.x > screenCenterX)
				{
                    jalanKanan();
				}
				else if (firstTouch.position.x < screenCenterX)
				{
                    jalanKiri();
				}
			}
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
