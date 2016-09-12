using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class StartMenuClickStart : MonoBehaviour {
    private bool clicked = false;
    public float alpha;
    //public bool loadScene;
    public int sceneId;
    public float delay = 0.75f;
    // Use this for initialization
    void Start () {
	}

	// Update is called once per frame
	void Update () {
        if (clicked) {
            Destroy(GameObject.Find("Press Start"));
            if (alpha <= 1) {
                alpha += (Time.deltaTime * delay);
                GetComponent<Image>().color = new Color(0, 0, 0, alpha);
            } else {
                SceneManager.LoadScene(sceneId, LoadSceneMode.Single);
            }
        } else if (Input.GetMouseButton(0)) {
            clicked = !clicked;
        }  
    }
}
