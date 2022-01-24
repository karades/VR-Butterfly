using System.Collections;
using UnityEngine;

public class RandomMoveInSphere : MonoBehaviour
{
    GameObject objectToMove;
    Transform objectToMoveTransform;
    [SerializeField]
    float radius;
    [SerializeField]
    int points;

    float step;
    int iterator;

    Vector3 middlePoint;
    Vector3[] listOfPoints;
    Vector3 randomPoint;

    Vector3 rayRange;
    void Start()
    {
        objectToMove = this.gameObject;
        middlePoint = objectToMove.GetComponent<Transform>().position;
        objectToMoveTransform = objectToMove.GetComponent<Transform>();
        listOfPoints = new Vector3[points];
        for (int i = 0; i < points; i++)
        {
            randomPoint = new Vector3(UnityEngine.Random.Range(-radius, radius), UnityEngine.Random.Range(-radius, radius), UnityEngine.Random.Range(-radius, radius));
            listOfPoints[i] = middlePoint + randomPoint;
        }
        iterator = 0;
    }

    // Update is called once per frame
    void Update()
    {

        step = LevelControl.instance.GetScriptable().speed * Time.deltaTime;
        // Determine which direction to rotate towards
        Vector3 targetDirection = objectToMoveTransform.position - listOfPoints[iterator];

        // Rotate the forward vector towards the target direction by one step
        Vector3 newDirection = Vector3.RotateTowards(objectToMoveTransform.forward, targetDirection, step, 0.0f);

        // Draw a ray pointing at our target in
        if (LevelControl.instance.getGlass() == true) { rayRange = -targetDirection.normalized * 0.1f; }
        else { rayRange = -targetDirection.normalized * 0.1f; }
        if (Physics.Raycast(transform.position, rayRange))
        {

            Debug.Log("Not this way");
            iterator = UnityEngine.Random.Range(0, points);
        }
        else
        {
            Debug.DrawRay(objectToMoveTransform.position, rayRange, Color.blue);
        }

        // Calculate a rotation a step closer to the target and applies rotation to this object
        objectToMoveTransform.rotation = Quaternion.LookRotation(newDirection);

        
        objectToMoveTransform.position = Vector3.MoveTowards(objectToMove.GetComponent<Transform>().position, listOfPoints[iterator], step);
        if (Vector3.Distance(objectToMove.GetComponent<Transform>().position, listOfPoints[iterator]) < 0.001f)
        {
            iterator = UnityEngine.Random.Range(0, points);

        }

    }
}
