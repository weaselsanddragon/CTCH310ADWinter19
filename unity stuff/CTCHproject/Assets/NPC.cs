using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int intel = 5;
    //public bool headBlow = true;

    void Greet()
    {
        switch(intel)
        {
            case 1:
                print("I am a chair");
                break;
            case 2:
                print("ooga wooga. food...");
                break;
            case 3:
                print("what's it to ya?");
                break;
            case 4:
                print("Ello, human.");
                break;
            case 5:
                print("Hello, fellow Human. Do you like physics?");
                break;
            default:
                print("...");
                break;
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        Greet();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            intel--;
            if (intel < 1)
                intel = 0;
            Greet();
        }
        if (Input.GetKeyDown("r"))
        {
            intel++;
            if (intel > 5)
                intel = 5;
            Greet();
        }
    }
}
