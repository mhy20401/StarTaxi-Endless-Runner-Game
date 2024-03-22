using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {

	public void LoadNextLevel ()
	{
		if(SceneManager.GetActiveScene().buildIndex==2){
			return;
		}
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

}
