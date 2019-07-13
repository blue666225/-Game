using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour
{
    public Transform target = null;
    public float MoveSpeed;
    public float speed;
    public float attenuation;

    private Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
        //transform.Translate((-Vector3.forward)* MoveSpeed * Time.deltaTime);
        velocity += (target.position - transform.position) * speed;
        velocity *= attenuation;
        transform.position += velocity *= Time.deltaTime;
    }
}
