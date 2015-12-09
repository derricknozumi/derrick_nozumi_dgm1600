using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DuckUI : MonoBehaviour {

	public int duckCount = 0;
	public Image[] ducks;

	public void UpdateDucks (){
		ChangeTexture (duckCount);
	}

	void ChangeTexture (int duckNum){
		ducks [duckNum - 1].color = new Color (1, 0, 0);

	}
}
