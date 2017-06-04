using UnityEngine;
using System.Collections;

public class ContainerMove3 : MonoBehaviour {

    private Vector3 moveVectorX;
    private Vector3 moveVectorX2; //For moving vector for unit2Container
    //private float moveLimitX;
    private Vector3 moveVectorY;
    private Vector3 moveVectorMinusY;
    //private Vector3 personPosition;
    private Vector3 trainVector;

    private float timeUse = 0.0f;
    private float timeLimit = 21.8f;
    private GameObject firstPerson;
    private GameObject train;
    private GameObject trainWagon;
    private GameObject unitA;
    private GameObject unitB;
    




    private Vector3 originPosition;
    private Vector3 wrongPosition;
    private Vector3 offset;

    // tag name : unitA, unitB, unit2Container(self) --> for container.   tag name: train, trainWagon --> for train part. 

    // Use this for initialization
    void Start()
    {
        moveVectorX = new Vector3(-1.5f, 0.0f, 0.11f); // Move vector: Container move along the track.
        moveVectorX2 = new Vector3(-1.5f, 0.0f, 0.1f);

        moveVectorY = new Vector3(0.0f, 1.0f, 0.0f);  // Move vector: Container move along the wagon.
        moveVectorMinusY = new Vector3(0.0f, -1.0f, 0.0f);
        firstPerson = GameObject.FindGameObjectWithTag("firstPerson");
        train = GameObject.FindGameObjectWithTag("train");
        trainWagon = GameObject.FindGameObjectWithTag("trainWagon");
        unitA = GameObject.FindGameObjectWithTag("unitA");
        unitB = GameObject.FindGameObjectWithTag("unitB");


        originPosition = new Vector3(-211.36f, 7.814f, -317.76f);
        wrongPosition = new Vector3(-218.324f, 6.876f, -312.251f);
        offset = wrongPosition - originPosition - new Vector3(-3f,0.0f,7.5f);



        trainVector = new Vector3(10f,5.0f,0.0f); 

        //firstPerson = GameObject.FindGameObjectWithTag("MainCamera"); //Get MainCamera object.
  

        StartCoroutine(containerRoutine());

    }

    public IEnumerator containerRoutine()
    {
        yield return new WaitForSeconds(20.0f); // Waiting time for starting Coroutine function. 

        while (timeUse <= timeLimit)
        {
            if (timeUse <= 8.5f)  // Move on the station for 5.0f
            {
                gameObject.transform.Translate(moveVectorMinusY * Time.deltaTime);
                yield return null;
                timeUse += Time.deltaTime;
            }

       

            else if (timeUse <= 21.8f) //Move on track for 13.5f 
            {
                gameObject.transform.Translate(moveVectorX * Time.deltaTime);
                
                //unit2Container.transform.position = gameObject.transform.position;
                //firstPerson.transform.Translate(moveVectorX * Time.deltaTime);
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
        if (timeUse >= 8.5f)
        {
            firstPerson.transform.position = gameObject.transform.position - offset;
        }

        //else if (timeUse >=20.0f)
        //{
        //    trainWagon.transform.parent = train.transform;
        //    unitA.transform.parent = train.transform;
        //    unitB.transform.parent = train.transform;
        //    gameObject.transform.parent = train.transform;


        //    train.transform.Translate(trainVector *Time.deltaTime);

        //    print("move");

        //}



    }
}
