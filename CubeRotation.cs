using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour {

    public float Speed;


	void OnMouseOver () {
        transform.Rotate(Vector3.right * Time.deltaTime * Speed);

	}
}
