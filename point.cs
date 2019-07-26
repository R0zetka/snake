using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point : MonoBehaviour {

    public GameObject foodPrefab;
    public Vector3 curPos;
    public GameObject curFood;

	
    void AddNewFood(){
        RandomPos();
        curFood = GameObject.Instantiate(foodPrefab, curPos, Quaternion.identity) as GameObject;
    
    }

    void RandomPos(){
        curPos = new Vector3(Random.Range(-9, 9), 1f, Random.Range(-7, 7));
    }
    void Update()
    {
        if(!curFood){
            AddNewFood();
        }
        else{
            return;
        }
    }
}
