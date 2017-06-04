using UnityEngine;
using System.Collections;

public class FirstPersonController : MonoBehaviour {

    private float speed=0.0f;
    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        speed = 5.0f;
        rb = GetComponent<Rigidbody>();

	
	}
	
	// Update is called once per frame
	void Update () {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");
        Vector3 moment = new Vector3(moveH, 0.0f, moveV);
        rb.AddForce(moment * speed);
	
	}
}
