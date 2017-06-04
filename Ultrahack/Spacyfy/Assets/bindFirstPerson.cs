using UnityEngine;
using System.Collections;

public class bindFirstPerson : MonoBehaviour {

    private float limitX;  //X trigger for bind person to the container
    private Vector3 offset;
    private GameObject unit2Container;

	// Use this for initialization
	void Start () {
        limitX = -212.0f;
        unit2Container = GameObject.FindGameObjectWithTag("unit2Container");

        if (gameObject.transform.position.x >= limitX)
        {
            offset = gameObject.transform.position - unit2Container.transform.position;
        }





    }

    // Update is called once per frame
    void Update()
    {

        if (offset != new Vector3(0,0,0))
        {
            gameObject.transform.position = unit2Container.transform.position + offset;
        }
       
       
	
	}
}
