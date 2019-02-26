using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}


public class Player : MonoBehaviour
{

    public float speed;
    public Boundary boundary;
    private Rigidbody rb;
	int nb=0;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

	void OnCollisionEnter (Collision other) {
		nb++;
		if(nb==2) {
			rb.isKinematic = true;	
		}
	}

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);

		/*
        rb.position = new Vector3
        (
            Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
            rb.position.y,
            Mathf.Clamp(rb.position.z, boundary.zMin, boundary.zMax)
        );

       */



    }
}