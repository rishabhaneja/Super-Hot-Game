
using UnityEngine;

public class manlook : MonoBehaviour {

    public Transform PlayerBody;

	// Use this for initialization
	void Awake ()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
	
	// Update is called once per frame
	void Update ()
    {
        float Mouse_x = Input.GetAxis("Mouse X");
        float Mouse_y = Input.GetAxis("Mouse Y");

        float RotationX = Mouse_x * 2f;
        float RotationY = Mouse_y * 2f;

        Vector3 RotateMancam = transform.rotation.eulerAngles;
        Vector3 RotateManbody = PlayerBody.rotation.eulerAngles;

        RotateMancam.x -= RotationY;
        RotateMancam.z = 0;
        RotateManbody.y += RotationX;

        transform.rotation = Quaternion.Euler(RotateMancam);
        PlayerBody.rotation = Quaternion.Euler(RotateManbody);    }
}
