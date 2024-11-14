using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
     void OnTriggerEnter(Collider other)
    {
        //увеличивает силу прыжка
        other.GetComponent<Jump>().jumpStrength = 10;
    }
    //меняет силу прыжка на обычную
     void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = 2;
    }
}
