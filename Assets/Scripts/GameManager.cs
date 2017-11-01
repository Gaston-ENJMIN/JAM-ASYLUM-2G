using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public float restartDelay = 1f;

    public ParticleSystem blood;

    // Quand EndGame est activé, j'écris GAME OVER dans la console
	public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            Debug.Log("GAME OVER");
            blood.Play();
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
