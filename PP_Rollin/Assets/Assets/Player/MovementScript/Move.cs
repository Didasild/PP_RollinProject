using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public int moveSpeed = 5;
    public Vector3 vecteurSaut;
    public int puissanceSaut = 50;
    public float graviteMonde = -1000f;
    Rigidbody rBody;

    // Use this for initialization
    void Start()
    {

        rBody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
            rBody.AddForce(-Vector3.right * moveSpeed);

        if (Input.GetKey(KeyCode.D))
            rBody.AddForce(Vector3.right * moveSpeed);

        if (Input.GetKey(KeyCode.Z))
            rBody.AddForce(Vector3.forward * moveSpeed);

        if (Input.GetKey(KeyCode.S))
            rBody.AddForce(-Vector3.forward * moveSpeed);

        if (Input.GetKeyDown("space"))
            rBody.AddForce(vecteurSaut * puissanceSaut);


    }
}
