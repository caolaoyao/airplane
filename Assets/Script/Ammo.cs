using UnityEngine;
using System.Collections;

public class Ammo : MonoBehaviour {
    public Vector3 Direction = Vector3.up;
    public float Speed = 10.0f;
    public float Lifetime = 10.0f;
	// Use this for initialization
	void Start () {
        Invoke("DestroyMe", Lifetime);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += Direction * Speed * Time.deltaTime;
	}

    void DestroyMe()
    {
        Destroy(gameObject);
    }
}
