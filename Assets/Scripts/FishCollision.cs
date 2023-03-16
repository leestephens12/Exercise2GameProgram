using UnityEngine;
using TMPro;

public class FishCollision : MonoBehaviour
{
    private Vector2 screenBounds; // vector to hold camera dimensions
    public int score; //variable for the score

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other) {
        Destroy(this.gameObject); //destroy the fish on colission
        score += 100; //increase the score by 100 if caugt
        Debug.Log("Score: " + score); //output score
    }

    void Start() {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        //set camera dimensions 
    }

    void Update() {
        //destroy object if it goes outside camera view
        if(transform.position.y < -screenBounds.y) {
            Destroy(this.gameObject);
        }
    }
}