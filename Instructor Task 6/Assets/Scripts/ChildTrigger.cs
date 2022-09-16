using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildTrigger : MonoBehaviour
{
    public static PathFollow pathFollow;
    // Start is called before the first frame update
    void Start()
    {
     pathFollow = GetComponent<PathFollow>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
           // PathFollow.isFollow = true;
            Debug.Log("hello");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //.isFollow = false;
            Debug.Log("bye");
        }
    }
}
