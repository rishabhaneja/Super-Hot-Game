using UnityEngine;

public class manmove : MonoBehaviour {

    [SerializeField]
    private float speed = 3f;

    private CharacterController rb;

	// Use this for initialization
	void Awake ()
    {
        rb = GetComponent<CharacterController>();
	}

    void Update()
    {

        float xMove = Input.GetAxis("Horizontal");
        float zMove = Input.GetAxis("Vertical");

        Vector3 MoveSide = transform.right * xMove * speed;
        Vector3 MoveForward = transform.forward * zMove * speed;

        rb.SimpleMove(MoveSide);
        rb.SimpleMove(MoveForward);

    }
}
