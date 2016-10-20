using UnityEngine;
using System.Collections;

public class PlayerController: MonoBehaviour {

	public float walkSpeed;
	public float rotationClamp;
	public float mouseSensitivity;

	private Rigidbody rb;
	private AudioSource audio;
	private CharacterController cc;

	private float rotLeftRight;
	private float rotUpDown = 0f;

	private bool locked;

	void Start()
	{
		locked = false;
		cc = GetComponent<CharacterController> ();
		audio = GetComponent<AudioSource> ();
		Cursor.visible = false;
	}

	void Update () 
	{
		rotLeftRight = Input.GetAxis ("Mouse X") * mouseSensitivity;
		rotUpDown -= Input.GetAxis ("Mouse Y") * mouseSensitivity;
		rotUpDown = Mathf.Clamp (rotUpDown, -rotationClamp, rotationClamp);

		if (!locked) {
			float horizontal = Input.GetAxis ("Horizontal");
			float vertical = Input.GetAxis ("Vertical");
			if (vertical > 0)
				vertical = walkSpeed;
			if (vertical < 0)
				vertical = -walkSpeed;
			if (horizontal > 0)
				horizontal = walkSpeed;
			if (horizontal < 0)
				horizontal = -walkSpeed;
			Vector3 speed = new Vector3 (horizontal, 0, vertical);
			speed = transform.rotation * speed;
			cc.SimpleMove(speed);
		} 
	}

	public void changeState(int i)
	{
		if (i == 0)
			locked = false;
		else
			locked = true;
	}

	void LateUpdate()
	{
		transform.Rotate (0f, rotLeftRight, 0f);
		//fCamera.main.transform.localRotation = Quaternion.Euler (rotUpDown, 0f, 0f);
	}

}
