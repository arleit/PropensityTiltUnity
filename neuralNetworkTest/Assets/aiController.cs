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
	int cp1, cp2, cp3, cpBase, score, health;
	//List<SquadLeader> SquadList;
	//ArrayList<Unit> FieldUnitList, BaseUnitList;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
