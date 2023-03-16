using UnityEngine;

public class BombCollision : MonoBehaviour
{
    private Vector2 screenBounds; // vector for screen dimesions
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other) {
        Destroy(this.gameObject); //destoy bomb if caught
        Debug.Log(this.gameObject.tag);
    }

    void Start() {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

        //set screen dimensions
    }

    void Update() {
        //if it falls outside camera view destroy it
        if(transform.position.y < -screenBounds.y) {
            Destroy(this.gameObject);
        }
    }
}