using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void Start(){

	}

	void Update(){
	
		transform.Translate(Input.GetAxis("Horizontal")*Time.deltaTime * 3,0f,Input.GetAxis("Vertical")* Time.deltaTime * 3);
	}
}
