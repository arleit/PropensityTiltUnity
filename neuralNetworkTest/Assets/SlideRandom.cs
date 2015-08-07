using UnityEngine;
using System.Collections;

public class SlideRandom : MonoBehaviour {

	// Use this for initialization
	public Vector3 startingPosition;
	const int WAIT = 10;
	public int rand;


	void Start () {
		StartCoroutine (movementManager ());
	}
	
	// Update is called once per frame
	void Update () {

	}

	IEnumerator movementManager(){
				while (true) {
						rand = (int)Random.Range (0, 4);
						switch (rand) {
						case 0:
								moveWest ();
								print ("moving west");
								yield return new WaitForSeconds (WAIT);
								moveEast ();
								break;
						case 1:
								moveEast ();
								print ("moving east");
								yield return new WaitForSeconds (WAIT);
								moveWest ();
								break;
						case 2:
								moveNorth ();
								print ("moving north");
								yield return new WaitForSeconds (WAIT);
								moveSouth ();
								break;
						case 3:
								moveSouth ();
								print ("moving south");
								yield return new WaitForSeconds (WAIT);
								moveNorth ();
								break;
						case 4:
								yield return new WaitForSeconds (WAIT);
								break;
						}

				}
		}

	void moveWest() { //Will move left 1 square
		transform.Translate (+1,0,0);
	}

	void moveEast() { //opposite of moveWest
		transform.Translate (-1,0,0);
	}

	void moveNorth() { //same as moveWest but for up
		transform.Translate (0,0,+1);
	}

	void moveSouth() { //opposite of moveNorth
		transform.Translate (0,0,-1);
	}
}

			