using System.Collections;
using UnityEngine;

public class TaskManager : MonoBehaviour {

    private float slowMo = 0.2f;
    private float normTime = 1.5f;
    private bool doSlow = false;

    [SerializeField]
    private CharacterController player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            if(doSlow)
            {
                Time.timeScale = normTime;
                doSlow = false;
            }
        }
        else
        {
            if(!doSlow)
            {
                Time.timeScale = slowMo;
                doSlow = true;
            }
        }
	}
}
