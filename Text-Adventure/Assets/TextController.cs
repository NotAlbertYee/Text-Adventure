using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {
	public Image image; 
	public Sprite warningImage; //Drag your first sprite here in inspector.
	public Sprite introImage; //Drag your second sprite here in inspector.
	public Sprite gameoverImage; //Drag your first sprite here in inspector.
	public Sprite begImage; //Drag your second sprite here in inspector.
	public Sprite windowImage; //Drag your first sprite here in inspector.
	public Sprite trapdoorImage; //Drag your second sprite here in inspector.
	public Sprite lolImage; //Drag your first sprite here in inspector.
	public Sprite freedomImage; //Drag your second sprite here in inspector.
	public Sprite ventImage; //Drag your second sprite here in inspector.
	public Sprite changeImage; //Drag your first sprite here in inspector.
	public Sprite endImage; //Drag your second sprite here in inspector.
	public Text text;
	private enum States {warning, intro, gameover, beg, window, trapdoor, lol, freedom, vent, end, change};
	// Use this for initialization
	private States myState;
	void Start () {
		myState = States.warning;
			}
	
	// Update is called once per frame
	void Update () {
		if (myState == States.warning) {
			state_warning ();
		} else if (myState == States.gameover) {
			state_gameover ();
		} else if (myState == States.intro) {
			state_intro ();
		} else if (myState == States.beg) {
			state_beg ();
		}
		else if (myState == States.vent) {
			state_vent ();
		} else if (myState == States.trapdoor) {
			state_trapdoor ();
		} else if (myState == States.lol) {
			state_lol ();
		} else if (myState == States.end) {
			state_end ();
		} else if (myState == States.change) {
			state_change ();
		} else if (myState == States.freedom) {
			state_freedom ();
		} else if (myState == States.window) {
			state_window ();
		}
	}
	void state_warning () {
		image.sprite = warningImage;
		text.text = "Wow your actually going to read this. "+
			"You should stop while you can, please stop it's not worth the time. "
			+"Seems like your really might  to read this, don't blame me for "+
			"wasting your time. Please stop when you can. \n"+
			"Input Choices: [S] to stop the story, [C] to continue the story, [L] to change the story";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.gameover;
		} else if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.change;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.intro;
		}
}
			void state_gameover () {
		image.sprite = gameoverImage;
				text.text = "Wow, you're really smart! "+
					"Sadly this is the end of your story though. "
					+"We really hope you've enjoyed your play session! "+
					"Please leave a good rating and review!.\n"+
					"Input Choices: [R] to restart the story, [Cmd or Ctrl + Q] to end your journey!";
				if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.warning;
				}
			}
	void state_intro () {
		image.sprite = introImage;
		text.text = "Wow your actually going to read this. "+
			"You should stop while you can, please stop it's not worth the time. "
			+"Seems like your really might  to read this, don't blame me for"+
			"wasting your time. Please stop when you can.\n"+
			"Input Choices: [C] to continue the story";
		if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.beg;
		}
}
	void state_change () {
		image.sprite = changeImage;
		text.text = "There once was a person who thought there was different storys. "+
			"When they chose to change the story, the screen changed to a different story. "
			+"But little did they know that they were tricked. "+
			"Tricked into ready a story about how they were tricked.\n"+
			"Input Choices: [G] to give up of this abomination";
		if (Input.GetKeyDown(KeyCode.G)) {
			myState = States.gameover;
		}
	}
	void state_beg () {
		image.sprite = begImage;
		text.text = "There once was a person who was arrested for playing a bad game. "+
			"Oh wait, that's who you play as in this game. "
			+"You are trapped in a badly made brick walled cell. High on the wall is a barred window, below the bed is a trap door. "+
			"You have three choices on what to do next. \n"+
			"Input Choices: [G] to give up of this abomination, [U] to try climb the window, [B] to try open and go through the trap door";
		if (Input.GetKeyDown(KeyCode.G)) {
			myState = States.gameover;
		} else if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.window;
		} else if (Input.GetKeyDown(KeyCode.B)) {
			myState = States.trapdoor;
		}
	}
	void state_window () {
		image.sprite = windowImage;
		text.text = "You notice that the wall may be climbable. "+
			"Instincivly you stick out your and grab onto the highest reachable brick. "
			+"Slowly you put one foot on a brick and start the climb. "+
			"On the way your hands start to sweat, you loose your grip and fall to your death. \n"+
			"Input Choices: [G] to give up of this abomination, [R] to restart the story, [F] screw death, I'm still alive";
		if (Input.GetKeyDown(KeyCode.G)) {
			myState = States.gameover;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.beg;
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.lol;
		}
	}
	void state_lol () {
		image.sprite = lolImage;
		text.text = "You Won! Some how cheated death and are still alive! "+
			"Sadly for you though, you broke your spine and is now permamently paralized. "
			+"When the prison guard finds you later, decides to pick you up "+
			"and dump you in the dumpster outside the prison. Congrats you made it out! But is this really the ending you wanted? \n"+
			"Input Choices: [G] to give up of this abomination, [R] to restart the story, [Cmd or Ctrl + Q] to rage this quit this game";
		if (Input.GetKeyDown(KeyCode.G)) {
			myState = States.gameover;
		} else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.beg;
		} else if (Input.GetKeyDown(KeyCode.F)) {
			myState = States.lol;
		}
	}
	void state_trapdoor () {
		image.sprite = trapdoorImage;
		text.text = "You notice a trap door lies below your bed. "+
			"Instincivly you stick foot and push the bed aside with it. "
			+"You bend over and grab the handle of the trapdoor. "+
			"With a quick yank the cover is off, and down you climb into it. \n"+
			"Input Choices: [U] to go back up, [D] to continue going down,";
		if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.beg;
		} else if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.vent;
		}
	}
	void state_vent () {
		image.sprite = ventImage;
		text.text = "As you continue descending through the passageway. "+
			"You start to feel very cold and decide that you are in a vent. "
			+"With a sense of urgency you rush to wear the cold is coming from. "+
			"It's a dead end. The blocking wall looks kind of loose though. \n"+
			"Input Choices: [U] to go back up, [D] to ram into the blocking wall,";
		if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.beg;
		} else if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.freedom;
		}
	}
	void state_freedom () {
		image.sprite = freedomImage;
		text.text = "You charge at the wall with all of your might. "+
			"The wall starts to shake so you try again. "
			+"BOOM! The wall breaks open and you go rolling into cold snow! "+
			"You made it out of the prison! Now your in the cold snow though. \n"+
			"Input Choices: [U] to go back up, [C] to die of hypothermia in the snow,";
		if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.beg;
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.end;
		}
	}
	void state_end () {
		image.sprite = endImage;
		text.text = "You Won! "+
			"Sadly for you though, you broke you died of hypothermia in the snow. "
			+"At least you made it out of the prison though! "+
			"Congrats you made it out! But is this really the ending you wanted? \n"+
			"Input Choices: [G] to give up of this abomination, [R] to restart the story, [Cmd or Ctrl + Q] to rage this quit this game";
		if (Input.GetKeyDown(KeyCode.G)) {
			myState = States.gameover;
		} 
		 else if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.warning;
		}
	}
}
