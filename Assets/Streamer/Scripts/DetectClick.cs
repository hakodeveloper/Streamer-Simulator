using UnityEngine;
using System.Collections;

public class DetectClick : MonoBehaviour {
    
    private SpriteRenderer spriteRenderer;

    void Start() {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    void Update() {
        if (isTouched()) {
        }
    }

    public bool isTouched() {
        bool result = false;
        if (Input.touchCount == 1) {
            if (Input.touches[0].phase == TouchPhase.Ended) {
                Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                Vector2 touchPos = new Vector2(wp.x, wp.y);
                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos)) {
                    result = true;
                }
            }
        }
        if (Input.GetMouseButtonUp(0)) {
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos = new Vector2(wp.x, wp.y);
            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(mousePos)) {
                Debug.Log(Input.mousePosition);
                result = true;
            }
        }
        return result;
    }
}