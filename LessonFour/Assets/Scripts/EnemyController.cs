using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public float speed = 3.0f;
    private Rigidbody enemyRb;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {

        enemyRb.AddForce(enemyRb.transform.forward*speed);
        enemyRb.transform.LookAt(player.transform.position);

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
