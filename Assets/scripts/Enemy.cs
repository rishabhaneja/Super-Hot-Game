using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float health = 50f;

    float movespeed = 4.0f;
    private GameObject character;
    public GameObject player;

	// Use this for initialization
	void Start ()
    {
        character = this.gameObject;
        player = GameObject.Find("player");

	}
	
	// Update is called once per frame
	void Update ()
    {
        character.transform.rotation = Quaternion.Slerp(character.transform.rotation, Quaternion.LookRotation(player.transform.position - character.transform.position), 3 * Time.deltaTime);

        character.transform.position += character.transform.forward * movespeed * Time.deltaTime;
	}

    public void Edamage(float amount)
    {
        health -= amount;

        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}