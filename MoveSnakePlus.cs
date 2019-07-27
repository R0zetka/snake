using UnityEngine;
using System.Collections;

public class MoveSnakePlus : MonoBehaviour
{

    public float Speed;
    public Vector3 tailTarget;
    public int indx;
    public GameObject tailTargetObj;
    public moveSnake mainSnake;
    void Start()
    {

        mainSnake = GameObject.FindGameObjectWithTag("SnakeMain").GetComponent<moveSnake>();
        Speed = mainSnake.Speed + 2.5f;
        tailTargetObj = mainSnake.tailObjects[mainSnake.tailObjects.Count - 2];
        indx = mainSnake.tailObjects.IndexOf(gameObject);
    }
    void Update()
    {
        tailTarget = tailTargetObj.transform.position;
        transform.LookAt(tailTarget);
        transform.position = Vector3.Lerp(transform.position, tailTarget, Time.deltaTime * Speed);
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("SnakeMain"))
        {
            if (indx > 2)
            {

                Application.LoadLevel("main");

            }
        }

    }

}
