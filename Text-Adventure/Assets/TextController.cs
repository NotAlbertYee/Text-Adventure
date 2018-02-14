using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom};
	// Use this for initialization
	private States myState;
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		if (myState == States.cell) {
			state_cell ();
		} else if (myState == States.sheets_0) {
			state_sheets_0 ();
		}
	}
	void state_cell () {
		text.text = "Wow your actually going to read this. "+
			"You should stop while you can, please stop it's not worth the time. "
			+"Seems like your really might  to read this, don't blame me for"+
			"wasting your time. Please stop when you can.\n"+
			"Input Choices: [S] to stop the story, [C] to continue the story, [L] to change the story";
	if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.sheets_0;
	}
}
			void state_sheets_0 () {
				text.text = "Wow, you're really smart! "+
					"Sadly this is the end of your story though. "
					+"We really hope you've enjoyed your play session! "+
					"Please leave a good rating and review!.\n"+
					"Input Choices: [R] to restart the story, [Cmd or Ctrl + Q] to end your journey!";
				if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.sheets_0;
				}
			}
}
