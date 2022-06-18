
using UnityEngine;

public class AimScript : MonoBehaviour
{   
    public Vector2 AimInitialForce;
    private Rigidbody2D rigidBody;
    private bool isf = false;

    [SerializeField]
    private GameObject damagePref;
    [SerializeField]
    private GameObject UIManager;
    
    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.AddForce(AimInitialForce);
    }

    public void Shot()
    {   
        isf = true;
    }

    public void DontShot()
    {
        isf = false;
    }

    private void OnTriggerStay2D(Collider2D other)
    {   
        if (isf)
        {   
            if (other.gameObject.tag == "target")
            {   
                Instantiate(damagePref, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
                DontShot();

                UIManager.GetComponent<ManagerScript>().AddPoint(1);
            }
        }

    }
}
