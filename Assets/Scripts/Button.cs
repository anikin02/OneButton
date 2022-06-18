using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject Aim;

    private void OnMouseDown()
    {   
        Aim.GetComponent<AimScript>().Shot();
    }

    private void OnMouseUp()
    {   
        Aim.GetComponent<AimScript>().DontShot();
        gameObject.GetComponent<Animator>().SetTrigger("Trigger");
    }
}
