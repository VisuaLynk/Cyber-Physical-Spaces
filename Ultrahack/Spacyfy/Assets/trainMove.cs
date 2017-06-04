using UnityEngine;
using System.Collections;

public class trainMove : MonoBehaviour {

    private float timeUse = 0.0f;
    private float timeLimit = 10.0f;
    private Vector3 trainVector;

    private GameObject firstPerson;
    private GameObject train;
    private GameObject trainWagon;
    private GameObject unitA;
    private GameObject unitB;
    private GameObject unit2Container;


    // Use this for initialization
    void Start () {
        trainVector = new Vector3(2.0f,0.0f, 5.0f);
        StartCoroutine(trainRun());

        firstPerson = GameObject.FindGameObjectWithTag("firstPerson");
        trainWagon = GameObject.FindGameObjectWithTag("trainWagon");
        unitA = GameObject.FindGameObjectWithTag("unitA");
        unitB = GameObject.FindGameObjectWithTag("unitB");
        unit2Container = GameObject.FindGameObjectWithTag("unit2Container");


    }

    public IEnumerator trainRun()
    {
        yield return new WaitForSeconds(42.0f); // Waiting time for starting Coroutine function. 

        while (timeUse <= timeLimit)
        {
            gameObject.transform.Translate(trainVector*Time.deltaTime);
            trainWagon.transform.parent = gameObject.transform;
            unitA.transform.parent = gameObject.transform;
            unitB.transform.parent = gameObject.transform;
            unit2Container.transform.parent = gameObject.transform;


            timeUse += Time.deltaTime;
            yield return null;

        }
    }
	// Update is called once per frame
	void Update () {
	
	}
}
