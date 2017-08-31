using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feline : Mammal {

    void Start()
    {
        Scratch();
    }

    void Scratch()
    {
        print(this.name + " Scratches");
    }
}
