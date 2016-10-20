using UnityEngine;
using System.Collections;

public class Flicker : MonoBehaviour {
    Light go;
    float flickerTime;
    bool flicker;
	// Use this for initialization
	void Start () {
        go = GetComponent<Light>();
        flickerTime = Random.Range(0.5f, 2.0f);
        flicker = true;
	}

    // Update is called once per frame
    void Update() {
        if (flicker)
            go.intensity = Random.Range(0.5f, 1.0f);
	}

    void FixedUpdate()
    {
        flickerTime -= Time.deltaTime;
        if (flickerTime < 0.0f)
        {
            if (flicker) {
                flickerTime = Random.Range(5.0f, 10.0f);
                flicker = false;
            }
            else {
                flickerTime = Random.Range(0.5f, 2.0f);
                flicker = true;
            }
        }
    }
}
