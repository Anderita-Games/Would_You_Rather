using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Generator : MonoBehaviour {
	public UnityEngine.UI.Text Line;
	public GameObject Instructions;
	public TextAsset Lines;

	void Start () {
		Instructions.SetActive(true);
	}

	public void Generation () {
		if (Instructions.activeSelf) {
			Instructions.SetActive(false);
		}
		StreamReader SR = new StreamReader(new MemoryStream(Lines.bytes));
		int Random_Number = Random.Range(1,224);
		for (int i = 1; i <= Random_Number; i++) {
			Line.text = SR.ReadLine();
		}
		SR.Close();
	}
}
