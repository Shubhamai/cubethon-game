using UnityEngine;
using UnityEngine.UI;


public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public GameManager gameManager;
    
    public Text lifeLeft;
    public float collisonNumber= 0;
    
    
    void OnCollisionEnter(Collision collisionInfo){
        if (collisionInfo.collider.tag == "Obstacle"){
            
            
            
            collisonNumber = collisonNumber + 1;
            float collisonText =  3 - collisonNumber;
            lifeLeft.text = collisonText.ToString();
            
            Debug.Log(collisonNumber);
            
            if (collisonNumber == 3) {
                movement.enabled = false;
                FindObjectOfType<GameManager>().EndGame();
                collisonNumber = 0; 
                
            }
          
            
            
            
        }
    }
}
