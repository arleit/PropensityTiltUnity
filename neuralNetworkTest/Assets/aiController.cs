using UnityEngine;
using System.Collections;


/* aiController is represented by your base panel, it controls spawning
 * aiController is extended by PlayerController
 * it sets up listeners, spawns Units and SquadLeaders, and is itself a cp
 * base health is tracked by the aiController as well as the enemy controller
 * 
 * 
 */

public class aiController : MonoBehaviour {

	aiController opponent;
	int cpA, cpB, cpC, cpBase, score, health;
	bool capA, hasA, capB, hasB, capC, hasC, capBase, baseVuln;
	Vector3 spawnPosition;
	Vector3[] capAVectors, capBVectors, capCVectors, capBaseVectors;
	IList SquadList;
	IList FieldUnitList, BaseUnitList;



	// Use this for initialization
	void Start () {
		if (this.name.Equals ("PlayerBase")) {
						spawnPosition = new Vector3 (-6, 0, -6);
				} else {
						spawnPosition = new Vector3 (6, 0, 6);
				}
		cpA = 0; //refers to how long it will take to cap the point
		cpB = 0;
		cpC = 0;
		cpBase = 0; //basically opponentBaseHealth
		health = 10000;
		capA = false; //are we capping cpA
		capB = false;
		capC = false;
		capBase = false;
		baseVuln = false;
		//initializeCapVectors ();

		StartCoroutine (CaptureListener (this)); //gets all the listners started for each point

		spawnSquad (new Unit());

	
	}
	
	// Update is called once per frame
	void Update () {
//		cpBase = opponent.health;


	}

	IEnumerator CaptureListener(aiController me){
				while (true) {
						while (capA == true && hasA == false) {
								while (cpA < 100)
										cpA++;
								if (cpA == 100) {
										me.opponent.cpA = 0;
										hasA = true;
										me.opponent.hasA = false;
								}
						}

						while (capB == true && hasB == false) {
								while (cpB < 100)
										cpB++;
								if (cpB == 100) {
										me.opponent.cpB = 0;
										hasB = true;
										me.opponent.hasB = false;
								}
						}

						while (capC == true && hasC == false) {
								while (cpC < 100)
										cpC++;
								if (cpC == 100) {
										me.opponent.cpC = 0;
										hasA = true;
										me.opponent.hasC = false;
								}
						}
						yield return new WaitForEndOfFrame ();
						yield return new WaitForSeconds (1);

				}
		}

	IEnumerator flagListener (aiController me){

				while (true) {
						foreach (Unit x in SquadList) {
						}
						
				}
		}


	void spawnSquad(Unit sl){ //this is going to spawn the sl at the 
		//Spawing shit: Instantiate (gameObject name, Vector3 position, Quaternion.identity);
		GameObject tempunit = (GameObject) Instantiate (Resources.Load("unit_basic"), this.spawnPosition, Quaternion.identity);
		tempunit.AddComponent ("Unit");
	}

	void initializeCapVectors(){
		capAVectors [0] = new Vector3 (4, 0, -3);
		capAVectors [1] = new Vector3 (4, 0, -4);
		capAVectors [2] = new Vector3 (4, 0, -5);
		capAVectors [3] = new Vector3 (3, 0, -3);
		capAVectors [4] = new Vector3 (3, 0, -3);
		capAVectors [5] = new Vector3 (3, 0, -3);
		capAVectors [6] = new Vector3 (5, 0, -3);
		capAVectors [7] = new Vector3 (5, 0, -4);
		capAVectors [8] = new Vector3 (5, 0, -5);




		}
}
