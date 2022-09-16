using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform[] enemy;
    public float speed = 3f;
    private Rigidbody enemyRb;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        int number = Random.Range(0,enemy.Length);
        Debug.Log(number);
        Vector3 lookAfter = enemy[number].transform.position - transform.position;
        enemyRb.AddForce(lookAfter*speed);
    }
}
