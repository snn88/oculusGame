using UnityEngine;
using System.Collections;

public class HighlightObjects : MonoBehaviour {

	private MeshRenderer renderer;
	private Color startColor;

	void Start () 
	{
		renderer = GetComponent<MeshRenderer> ();
		startColor = renderer.material.color;
	}

	void highlight()
	{
		renderer.material.color = Color.blue;
	}

	void unhighlight()
	{
		renderer.material.color = startColor;
	}
}
