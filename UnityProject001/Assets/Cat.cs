using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Feline {

    void Start()
    {
        Meow();
    }

    void Meow ()
    {
        print(this.name + " Meows");
    }
}
