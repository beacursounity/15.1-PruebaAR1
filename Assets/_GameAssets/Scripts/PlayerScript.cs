using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {

    [SerializeField] Text derecha;
    int speed = 100;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MoverDerecha() {
        gameObject.transform.Translate(new Vector3( speed  ,0 ,0));
    }

    public void MoverIzquierda() {
        gameObject.transform.Translate(new Vector3(  speed * -1, 0, 0));
    }
}
