using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lion : Feline {

    void Start()
    {
        Roar();
    }

    void Roar()
    {
        print(this.name + " Roars");
    }
}
