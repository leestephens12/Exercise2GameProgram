using System.Collections;
using UnityEngine;

public class SpawnFish : MonoBehaviour
{
    public GameObject fishPrefab;//game object for the respqningin of fish
    private Vector2 screenBounds; //vecotr for camera dimensions
    // Start is called before the first frame update
    void Start()
    {
        //set camera dimensions
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(fishWave());
    }

    private void spawnFish() {
        //create a new game object wehn destroyed
        GameObject f = Instantiate(fishPrefab) as GameObject;
        f.transform.position = new Vector2(Random.Range(-screenBounds.x/2, screenBounds.x/2), screenBounds.y);
    }

    IEnumerator fishWave() {
        //wait 1-6 seconds to spawn a new object
        while(true) {
            yield return new WaitForSeconds(Random.Range(1f, 6f));//Random.Range(3, 6));
            spawnFish();
        }
    }
}
