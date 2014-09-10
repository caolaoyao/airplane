using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {
    public int Health = 100;
    public float Speed = 0.5f;
    public Vector2 MinMaxX = Vector2.zero;
    public GameManager gameManager;
    public float delay = 0;
    public int randNum = 1;
	// Use this for initialization
	void Start () {
        gameManager = GameObject.FindGameObjectWithTag("GamePlayerManger").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
        //transform.position = new Vector3(MinMaxX.x + Mathf.PingPong(Time.time * Speed, 1.0f) * 
        //(MinMaxX.y - MinMaxX.x), transform.position.y-0.01f , transform.position.z);
        delay -= Time.deltaTime;
        if (delay < 0)
        {
            randNum = Random.Range(1,5);
            delay = 2f;
        }

        switch (randNum)
        {
            case 1:
            case 2:
                transform.position = new Vector3(Mathf.Clamp(transform.position.x - Speed * Time.deltaTime, MinMaxX.x, MinMaxX.y),
            transform.position.y - 0.01f, transform.position.z);
                break;

            case 3:
            case 4:
                transform.position = new Vector3(Mathf.Clamp(transform.position.x + Speed * Time.deltaTime, MinMaxX.x, MinMaxX.y),
            transform.position.y - 0.01f, transform.position.z);
                break;
        }

	}

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            gameManager.Damage();
        }

        if (collisionInfo.gameObject.tag == "PlayerBullet")
        {
            Destroy(gameObject);
        }
    }
}
