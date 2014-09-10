using UnityEngine;
using System.Collections;

public class PlayerCtr : MonoBehaviour {
    public GameObject player;
    public float moveSpeed = 2f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.S))
        {
            if (transform.localPosition.x >= -390)
            {
                transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
            }       
        }

        if (Input.GetKey (KeyCode.F))
        {
            if (transform.localPosition.x <= 390)
            {
                transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
            }          
        }

        if (Input.GetKey(KeyCode.E))
        {
            if (transform.localPosition.y <= 250)
            {
                transform.Translate(Vector3.up * Time.deltaTime * moveSpeed);
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (transform.localPosition.y >= -250)
            {
                transform.Translate(Vector3.down * Time.deltaTime * moveSpeed);
            }           
        }
	}
}
