using System.Collections;
using UnityEngine;

public class Gun : MonoBehaviour {

    public Camera lookcam;

    public float damage = 5f;
    public float range = 50;

	// Use this for initialization
	void Start ()
    {
    }
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetButtonDown("Fire1"))
        {
            Shooting();
        }
	}

    void Shooting()
    {
        RaycastHit HitInfo;
       if (Physics.Raycast(lookcam.transform.position ,lookcam.transform.forward ,out HitInfo ,range))
        {
            Enemy target = HitInfo.transform.GetComponent<Enemy>();

            if(target!= null)
            {
                target.Edamage(damage);
            }
        }
    }

}
