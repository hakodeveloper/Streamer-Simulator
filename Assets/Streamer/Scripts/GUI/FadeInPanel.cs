using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeInPanel : MonoBehaviour {
    public float alpha = 1;
    public float delay = 0.75f;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (alpha >= 0) {
            alpha -= (Time.deltaTime * delay);
            GetComponent<Image>().color = new Color(0, 0, 0, alpha);
        } else {
            Destroy(gameObject);
        }
    }
}
