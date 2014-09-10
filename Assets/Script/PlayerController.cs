using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    public float Speed = 10.0f;
    public Vector2 MinMaxX = Vector2.zero;
    public Vector2 MinMaxY = Vector2.zero;

    public int Health = 100;
    public float ReloadDelay = 0.2f;

    public GameObject PrefabAmmo = null;

    private bool WeaponsActivated = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {      
        
        //if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        //{
        //    transform.position = new Vector3(Mathf.Clamp(transform.position.x +  Speed * Time.deltaTime, MinMaxX.x, MinMaxX.y),
        //    transform.position.y, transform.position.z);
        //}

        //if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        //{
        //    transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y + Speed * Time.deltaTime, MinMaxY.x, MinMaxY.y),
        //    transform.position.z);
        //}

        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x - Speed * Time.deltaTime, MinMaxX.x, MinMaxX.y),
            transform.position.y, transform.position.z);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x + Speed * Time.deltaTime, MinMaxX.x, MinMaxX.y),
            transform.position.y, transform.position.z);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y + Speed * Time.deltaTime, MinMaxY.x, MinMaxY.y),
            transform.position.z);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y - Speed * Time.deltaTime, MinMaxY.x, MinMaxY.y),
            transform.position.z);
        }
	}

    void LateUpdate()
    {
        if (Input.GetKey(KeyCode.J) && WeaponsActivated)
        {
            Instantiate(PrefabAmmo, transform.position, PrefabAmmo.transform.rotation);
            WeaponsActivated = false;
            Invoke("ActivateWeapons", ReloadDelay);
        }
    }

    void ActivateWeapons()
    {
        WeaponsActivated = true;
    }
}
