using System.Collections;

using UnityEngine;

public class SpawnBombs : MonoBehaviour
{
    public GameObject bombPrefab;//Create game objec that holds bomb object to spawn multiple times
    private Vector2 screenBounds; // vector that holds dimensions of camera
    // Start is called before the first frame update
    void Start()
    {
        //SEt camera dimension
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        //Start coroutine to spawn bombs
        StartCoroutine(bombWave());
    }

    //Spawn bombs function instantiates a game object bomb to spanw after destroyed
    private void spawnBombs() {
        GameObject b = Instantiate(bombPrefab) as GameObject;
        b.transform.position = new Vector2(Random.Range(-screenBounds.x/2, screenBounds.x/2), screenBounds.y);
    }

    IEnumerator bombWave() {
        //wait a random interval between 1 and 6 seconds to call function
        while(true) {
            yield return new WaitForSeconds(Random.Range(1f, 6f));//Random.Range(3, 6));
            spawnBombs();
        }
    }
}
