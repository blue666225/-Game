﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTama : MonoBehaviour
{
    public GameObject TamaPrefab;
    public int TamaDeadth;
    public int CastleWallDestoy;
    public GameObject CastlePrefab;
    public GameObject JetTamaPrefab;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        TamaDeadth = 0;
        CastleWallDestoy = 0;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.magnitude != 0)
        {
            transform.rotation = Quaternion.LookRotation(rb.velocity.normalized);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")
            || collision.gameObject.CompareTag("Tama") || collision.gameObject.CompareTag("Bomb"))
        {
            Destroy(collision.gameObject);
            Destroy(TamaPrefab);

        }
        else if (collision.gameObject.CompareTag("wall"))
        {
            TamaDeadth += 1;

            if (TamaDeadth == 2)
            {
                Destroy(TamaPrefab);

            }
        }
        else if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(TamaPrefab);
        }
        //else if (collision.gameObject.CompareTag("CastleWall"))
        //{
        //    CastleWallDestoy += 1;
        //    if (CastleWallDestoy == 3)
        //    {
        //        Destroy(CastlePrefab);
        //    }
        //}
    }
}
