using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mammal : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Eat();
        Sleep();
	}
	
	void Eat ()
    {
        print(this.name + " Eats");
    }

    void Sleep ()
    {
        print(this.name + " Sleeps");
    }
}
