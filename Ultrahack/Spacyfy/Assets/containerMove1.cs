using UnityEngine;
using System.Collections;

public class containerMove1 : MonoBehaviour {

    private Vector3 moveVectorX;
    //private float moveLimitX;
    private Vector3 moveVectorY;
    private Vector3 moveVectorMinusY;

    private float timeUse = 0.0f;
    private float timeLimit = 22.5f;


    // Use this for initialization
    void Start()
    {
        moveVectorX = new Vector3(-1.5f, 0.0f, 0.11f); // Move vector: Container move along the track.
        moveVectorY = new Vector3(0.0f, 1.0f, 0.0f);  // Move vector: Container move along the wagon.
        moveVectorMinusY = new Vector3(0.0f, -1.0f, 0.0f);
        //moveLimitX = -196.0f;

        StartCoroutine(containerRoutine());

    }

    public IEnumerator containerRoutine()
    {
        yield return new WaitForSeconds(8.0f); // Waiting time for starting Coroutine function. 

        while (timeUse <= timeLimit)
        {
            if (timeUse <=5.0f)  // Move on the station for 5.0f
            {
                gameObject.transform.Translate(moveVectorMinusY * Time.deltaTime);
                yield return null;
                timeUse += Time.deltaTime;
            }

            else if (timeUse <= 18.5f) //Move on track for 13.5f 
            {
                gameObject.transform.Translate(moveVectorX * Time.deltaTime);
                yield return null;
                timeUse += Time.deltaTime;
            }
            else //Move on the wagon for the rest 3.5f
            {
                gameObject.transform.Translate(moveVectorY * Time.deltaTime);
                yield return null;
                timeUse += Time.deltaTime;
            }
        }



    }

    // Update is called once per frame
    void Update () {
	
	}
}
