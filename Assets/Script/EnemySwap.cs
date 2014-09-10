using UnityEngine;
using System.Collections;

public class EnemySwap : MonoBehaviour {
    public GameObject enemy = null;
    public float delay = 2f;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        delay -= Time.deltaTime;
        if (delay < 0)
        {
            createEnemy();
            delay = 2f;
        }
	}

    public void createEnemy()
    {
        Instantiate(enemy, transform.position, enemy.transform.rotation);
    }
}
