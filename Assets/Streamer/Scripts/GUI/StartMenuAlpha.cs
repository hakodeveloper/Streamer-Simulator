using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StartMenuAlpha : MonoBehaviour {
    public Text text;
    public float alpha;
    public float delay = 0.75f;
    private float flipflop = -1f;

	// Use this for initialization
	void Start () {
        LocalizationString local = new LocalizationString();
        alpha = 1f;
        text = GetComponent<Text>();
        text.text = LocalizationString.PressStart;
        if (Application.isMobilePlatform) {
            text.text = LocalizationString.PressStart_mobile;
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (alpha >= 1f) {
            flipflop = -1f;
        }
        if (alpha <= 0.2f) {
            flipflop = 1f;
        }
        alpha += (Time.deltaTime*delay)*flipflop;
        text.color = new Color(1,1,1,alpha);
	}
}
