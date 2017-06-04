using UnityEngine;
using System.Collections;

public class Unit2DoorCollidar : MonoBehaviour {

	// Use this for initialization
	void Start () {
     
	
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "firstPerson")
        {
            print("collidar detected, trigger enter");
            //gameObject.SetActive(false);
            Destroy(gameObject);
        };
        //other.gameObject.SetActive(false);
        
    }

    private void OnTriggerExit(Collider other2)
    {
        if (other2.tag == "firstPerson")
        {
            print("collidar detected, trigger exit");
            gameObject.SetActive(true);
        };
        //other.gameObject.SetActive(false);

    }



    // Update is called once per frame
    void Update () {

   
	
	}
}
