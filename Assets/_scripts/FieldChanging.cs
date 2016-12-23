using UnityEngine;
using System.Collections;

public class FieldChanging : MonoBehaviour {

	private char who;
	private char pole;
	private GameController gm;
	public int nrPola;
	public GameObject krzyzyk;
	public GameObject kolko;


	void Start()
	{
		GameObject managerObject = GameObject.FindGameObjectWithTag ("Game Manager");
		if (managerObject != null)
		{
			gm = managerObject.GetComponent<GameController> ();
		}

	}


	void zmianaPola(){

		switch (nrPola) {
		case 1:
			gm.p1 = pole;
			break;
		case 2:
			gm.p2 = pole;
			break;
		case 3:
			gm.p3 = pole;
			break;
		case 4:
			gm.p4 = pole;
			break;
		case 5:
			gm.p5 = pole;
			break;
		case 6:
			gm.p6 = pole;
			break;
		case 7:
			gm.p7 = pole;
			break;
		case 8:
			gm.p8 = pole;
			break;
		case 9:
			gm.p9 = pole;
			break;
		default:
			Debug.Log ("Blad panie");
			break;
		}
	}

	void OnMouseUp() {
		Debug.Log ("Field Click");

			if(gm.kto=='o'){
				pole='o';
				gm.kto='x';
				zmianaPola ();
				Instantiate (kolko, transform.position, transform.rotation);
				Destroy (gameObject);

			}
			else  {
				pole='x';
				gm.kto='o';
				zmianaPola ();
				Instantiate (krzyzyk, transform.position, transform.rotation);
				Destroy (gameObject);

			}
			gm.GetComponent<GameController>().sprawdz();


	}
}


