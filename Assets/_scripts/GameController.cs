using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

public char p1,p2,p3,p4,p5,p6,p7,p8,p9;
	public Text w;
	private bool win;
	private double czas;

public char kto;


	void Start() {
		p1 = 'n';
		p2 = 'n';
		p3 = 'n';
		p4 = 'n';
		p5 = 'n';
		p6 = 'n';
		p7 = 'n';
		p8 = 'n';
		p9 = 'n';
		win = false;
	}

	void Update(){
		if (win == true) {
			czas += Time.deltaTime;
			Debug.Log (czas);
			if (czas > 3.0) {
				Application.LoadLevel (0);
			}
		}
	}



public void sprawdz()
{
		if (kto == 'x')
			w.text = "Tura gracza: x";
		else w.text = "Tura gracza: o";

  if((p1==p2 && p2==p3 && p1!='n') ||
  (p4==p5 && p5==p6 && p4!='n') ||
  (p7==p8 && p8==p9 && p7!='n') ||
  (p1==p4 && p4==p7 && p1!='n') ||
  (p2==p5 && p5==p8 && p2!='n') ||
  (p3==p6 && p6==p9 && p3!='n') ||
  (p1==p5 && p5==p9 && p1!='n') ||
  (p3==p5 && p5==p7 && p3!='n'))
  {
			win = true;
			if(kto=='x') w.text="Wygrywa kółko!";
			else  w.text="Wygrywa krzyżyk!";
}
	
		if (p1 != 'n' && p2 != 'n' && p3 != 'n' &&
		    p4 != 'n' && p5 != 'n' && p6 != 'n' &&
		    p7 != 'n' && p8 != 'n' && p9 != 'n') {
			win = true;
			w.text = "REMIS";
		}
	}
}