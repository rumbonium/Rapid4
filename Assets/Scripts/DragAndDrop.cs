using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    bool moveAllowed;
    Collider2D collider;
    public ParticleSystem water;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<Collider2D>();
        water.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
		{
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase)
			{
                case TouchPhase.Began:
                    Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);
                    if (collider == touchedCollider)
                        moveAllowed = true; 
                    break;
                
                case TouchPhase.Moved:
                    if (moveAllowed)
                        transform.position = new Vector2(touchPosition.x, touchPosition.y);
                        water.Play();
                    break;
                
                case TouchPhase.Ended:
                    moveAllowed = false; water.Stop();
                    break;
			}
		}
    }
}
