using UnityEngine;
using System.Collections;

public class CarMove : MonoBehaviour {

    private Vector3 moveVector;
    private float timeUse=0.0f;
    private float timeLimit = 12.0f;
    private Vector3 trainLocation;

	// Use this for initialization
	void Start () {
        trainLocation = gameObject.transform.position;
        moveVector = new Vector3(5, 0, 10);
        StartCoroutine(moveTrain());




    }

    public IEnumerator moveTrain()
    {
        yield return new WaitForSeconds(1.0f);

  
        while (timeUse <= timeLimit)
        {
            gameObject.transform.Translate(moveVector * Time.deltaTime);
            yield return null;

            if (timeUse < 10.0f)
            {
                timeUse += Time.deltaTime;

            }
            else
            {
                timeUse = 0.0f;
                gameObject.transform.position = trainLocation;
            }

        }
   
        
      

    }

	
	// Update is called once per frame
	void Update () {
       

    }
}
