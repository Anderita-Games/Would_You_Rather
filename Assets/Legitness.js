#pragma strict
import System.IO;

var Hate_Text : UnityEngine.UI.Text;
var Instructions : GameObject;
var Phrases : TextAsset;

function Start () {
	Instructions.SetActive(true);
}

function Generation () {
	Instructions.SetActive(false);
	var SR : StreamReader = new StreamReader(new MemoryStream(Phrases.bytes));
	var Number_Random : int = Random.Range(1, 271);
	while (Number_Random > 0) {
		Hate_Text.text = SR.ReadLine();
		Number_Random--;
	}
	Hate_Text.text = SR.ReadLine();
	SR.Close();
}