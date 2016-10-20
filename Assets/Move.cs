using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
    public float speed = 3.0F;
    public float rotateSpeed = 3.0F;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        CharacterController controller = GetComponent<CharacterController>();
        float sideMotion = Input.GetAxis("Mouse X");
        transform.Rotate(0, sideMotion, 0);
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = speed * Input.GetAxis("Vertical");
        float sideSpeed = speed * Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(sideSpeed, 0, curSpeed);
        //movement = movement * transform.rotation;
        controller.SimpleMove(movement);
    }
}
