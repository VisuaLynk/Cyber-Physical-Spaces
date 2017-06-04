using UnityEngine;
using System.Collections;

public class ContainerRotate : MonoBehaviour {

    private Vector3 moveVectorX;
    //private float moveLimitX;
    private Vector3 moveVectorY;

    private float timeUse = 0.0f;
    private float timeLimit = 20.0f;


	// Use this for initialization
	void Start () {
        moveVectorX = new Vector3(-1.5f, 0.0f, 0.11f); // Move vector: Container move along the track.
        moveVectorY = new Vector3(0.0f,1f,0.0f);  // Move vector: Container move along the wagon.
        //moveLimitX = -196.0f;

        StartCoroutine(containerRoutine());
	
	}

    public IEnumerator containerRoutine()
    {
        yield return new WaitForSeconds(5.0f); // Waiting time for starting Coroutine function. 

        while (timeUse <= timeLimit)
        {
            if (timeUse <= 13.5f) //Move track for 13.5f 
            {
                gameObject.transform.Translate(moveVectorX *Time.deltaTime);
                yield return null;
                timeUse += Time.deltaTime;
            }
            else //Move on the wagon for the rest 6.5f
            {
                gameObject.transform.Translate(moveVectorY*Time.deltaTime);
                yield return null;
                timeUse += Time.deltaTime;
            }
        }



    }
	
	// Update is called once per frame
	void Update () {

       
 

	
	}
}
