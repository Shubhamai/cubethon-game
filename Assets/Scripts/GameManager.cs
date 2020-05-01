using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

  bool gameHasEnded = false;
  public float restartDelay = 2f;
  public GameObject completeLevelUI;
    
    
  public void CompleteLevel (){
      completeLevelUI.SetActive(true);
      Invoke("LoadCredits", 2);
  }  
    
    
  public void EndGame() {
      
      if (gameHasEnded == false){
      
      gameHasEnded = true;
      Debug.Log("Game Over");
      Invoke("Restart", restartDelay);
      
      }

  }
  
  void Restart (){
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }
  
  void LoadCredits (){
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }
}
