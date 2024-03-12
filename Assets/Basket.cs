using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    Vector3 v3;
    public GameObject ball;
    GameObject NewBall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        v3 = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 2, gameObject.transform.position.z);
        if (Input.GetButtonDown("Jump"))
        {
            NewBall = Instantiate(ball, v3, Quaternion.identity);
            NewBall.GetComponent<Rigidbody>().velocity = new Vector3(0, 5, 5);
        }
    }
}
