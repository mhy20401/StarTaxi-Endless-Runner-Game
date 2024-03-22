using UnityEngine;
using UnityEngine.SceneManagement;
public class EndTrigger : MonoBehaviour {

	public GameManager gameManager;

	void OnTriggerEnter ()
	{
		if(SceneManager.GetActiveScene().buildIndex == 2){
			gameManager.ShowQuitGame();
		}
		else{
			gameManager.CompleteLevel();	
		}
	}

}
