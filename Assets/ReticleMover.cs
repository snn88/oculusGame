using UnityEngine;
using System.Collections;

public class ReticleMover : MonoBehaviour {

	public Camera cameraFacing;
	private Vector3 scale;
	private GameObject target;
	// Use this for initialization
	void Start () {
		scale = transform.localScale;
		target = null;
	}

	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		float distance;
		if (Physics.Raycast (new Ray (cameraFacing.transform.position, cameraFacing.transform.rotation * Vector3.forward), out hit)) {
			distance = hit.distance;

			if (hit.collider != null) 
			{ 
				if ((hit.collider.tag == "Highlightable") && (distance < 10)) 
				{
					if (target != hit.collider.gameObject) 
					{
						if (target != null) {
							target.GetComponent<HighlightObjects> ().Invoke ("unhighlight", 0.0f);
						}
						target = hit.collider.gameObject;
						target.GetComponent<HighlightObjects> ().Invoke ("highlight", 0.0f);
					}

				}
				else 
				{
					if (target != null)
					{
						target.GetComponent<HighlightObjects> ().Invoke ("unhighlight", 0.0f);
						target = null;
					}
				}
			}
			//					HighlightObjects script = hit.collider.gameObject.GetComponent<HighlightObjects> ();
			//					if 
			//					script.Invoke ("highlight", 0.0f);
			//					Renderer.FindObjectOfType<"Sha
			//					hit.collider.GetComponent(Script.GetComponent ..highlight ();
			//renderer.material.shader = Shader.Find("Self-Illumin/Outlined Diffuse");
			//				hit.collider.enabled = false; */
		} else
			distance = cameraFacing.farClipPlane * 0.95f;


		transform.position = cameraFacing.transform.position + cameraFacing.transform.rotation * Vector3.forward * distance;//cameraFacing.ScreenToWorldPoint(new Vector3(cameraFacing.pixelWidth/2, cameraFacing.pixelHeight/2, 2.0f));
		transform.LookAt (cameraFacing.transform.position);
		transform.Rotate (0f, 180f, 0f);
		if (distance < 10) {
			distance *= 1 + 5 * Mathf.Exp (-distance);
		}
		transform.localScale = scale * distance;

		//if (Physics.Raycast(new Ray(cameraFacing.transform.position, cameraFacing.transform.rotation * Vector3.forward)
	}
}
