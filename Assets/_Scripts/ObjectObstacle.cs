using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ObjectType {
    Telur,
    Bom
}

public class ObjectObstacle : MonoBehaviour {

    public ObjectType type;
    public int amountEffect = 1;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "Player") {
            if (type == ObjectType.Telur) {
                GamesManager.instance.addScore(amountEffect);
            }
            if (type == ObjectType.Bom) {
                GamesManager.instance.decreaseLives(amountEffect);
            }
        }
    }

}
