using UnityEngine;

public class Button : MonoBehaviour
{   
    public AudioSource Shot;
    public GameObject Aim;

    private void OnMouseDown()
    {   
        Aim.GetComponent<AimScript>().Shot();
    }

    private void OnMouseUp()
    {   
        Aim.GetComponent<AimScript>().DontShot();
        gameObject.GetComponent<Animator>().SetTrigger("Trigger");

        if (!Shot.isPlaying)
            {
                Shot.Play();
            }
    }
}
