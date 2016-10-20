using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour 
{
	public int speed;
	//	private float horizontal;
	private float vertical;
	//
	void Update () 
	{
		//		horizontal = Input.GetAxis("Mouse X") * speed;
		vertical = Input.GetAxis("Mouse Y") * speed;
	}
	//
	void LateUpdate()
	{
		//		transform.parent.Rotate (0f, horizontal, 0f, Space.World);
		transform.Rotate (-vertical, 0f, 0f, Space.Self);
	}
//	public Texture2D crosshairTex; //crosshair images go here
//
//	public Rect position; //position of the crosshair image
//
//	public bool OriginalOn = true;
//
//	public int zoom = 20; //determines amount of zoom capable. Larger number means further zoomed in
//
//	private float normal;  //determines the default view of the camera when not zoomed in
//
//	public float smooth = 5; //smooth determines speed of transition between zoomed in and default state
//
//	private bool zoomedIn = false; //boolean that determines whether we are in zoomed in state or not
//
//	void Start()
//	{
//		normal = Camera.main.fieldOfView;
//	}
//
//	void Update () 
//	{
//		position = new Rect((Screen.width - crosshairTex.width) / 2, (Screen.height - crosshairTex.height) /2, crosshairTex.width, crosshairTex.height); //determines width/height of our crosshair GUI texture
//
//		if(Input.GetKeyDown("z")){        //This function toggles zoom capabilities with the Z key. If it's zoomed in, it will zoom out
//
//			zoomedIn = !zoomedIn;
//
//		}
//
//		if(zoomedIn == true){    //If "zoomedIn" is true, then it will not zoom in, but if it's false (not zoomed in) then it will zoom in.
//
//			Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, zoom, Time.deltaTime*smooth);
//
//		}
//
//		else {
//			if (Camera.main.fieldOfView != 60) {
//				//Camera.main.ResetFieldOfView ();
//				Camera.main.fieldOfView = Mathf.Lerp (Camera.main.fieldOfView, normal, Time.deltaTime * smooth);
//			}
//		}
//
//	}
//
//	void OnGUI()
//	{
//		if(OriginalOn)
//
//		{
//			GUI.DrawTexture(position, crosshairTex); //"draws" crosshair texture
//		}
//
//	}
		
}
