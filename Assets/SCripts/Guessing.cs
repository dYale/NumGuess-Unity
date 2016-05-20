using UnityEngine;
using System.Collections;

public class Guessing : MonoBehaviour {

	
	int maxNum;
	int minNum;
	int guess;

	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.UpArrow)){
		
			minNum = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)){
			maxNum = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.Return)){
			print ("WIN!!!");
			StartGame();
		}
	}
	
	void StartGame (){
		maxNum = 1000;
		minNum = 1;
		guess = 500;
		print ("====================");
		print ("Welcome");
		print ("Pick a number, any number and don't tell anyone!");
		
		print ("The largest number you may choose is: " + maxNum);
		print ("The smallest number you may choose is: " + minNum);
		
		print("Is the number above or below " + guess + "?");
		print("Up arrow for above, down for below, return for equal");
		maxNum = maxNum + 1;
	}
	
	void NextGuess () {
		guess = (maxNum + minNum) / 2;
		print ("Higher or lower than " + guess);
		print("Up arrow for above, down for below, return for equal");
	}
}
