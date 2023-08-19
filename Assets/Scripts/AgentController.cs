using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentController : MonoBehaviour
{
    [SerializeField] AgentState currentState = AgentState.ground;
    [SerializeField] GameObject groundState;
    [SerializeField] GameObject flyingState;
    [SerializeField] GameObject gravityState;
    [SerializeField] GameObject reverseState;
    [SerializeField] GameObject spinState;
    [SerializeField] GameObject birdState;
    [SerializeField] GameObject troState;
    //[SerializeField] GameObject ZigzagState;
    [SerializeField] GameObject gameOverObj;
    [SerializeField] GameObject gameWinObj;
    [SerializeField] GameObject gameFinish;
    [SerializeField] GameObject cam;
    private object cameraScript;

    public AgentState CurrentState { 
        get => currentState;
        set
        {
            currentState = value;
            if (currentState == AgentState.ground)
            {
                groundState.SetActive(true);
                flyingState.SetActive(false);
                gravityState.SetActive(false);
                reverseState.SetActive(false);
                spinState.SetActive(false);
                birdState.SetActive(false);
                troState.SetActive(false);
                
            }
            else if (currentState == AgentState.flying)
            {
                groundState.SetActive(false);
                flyingState.SetActive(true);
                gravityState.SetActive(false);
                reverseState.SetActive(false);
                spinState.SetActive(false);
                birdState.SetActive(false);
                troState.SetActive(false);
                
            }
            else if (currentState == AgentState.gravity)
            {
                groundState.SetActive(false);
                flyingState.SetActive(false);
                gravityState.SetActive(true);
                reverseState.SetActive(false);
                spinState.SetActive(false);
                birdState.SetActive(false);
                troState.SetActive(false);
                
            }
            else if (currentState == AgentState.reverse)
            {
                groundState.SetActive(false);
                flyingState.SetActive(false);
                gravityState.SetActive(false);
                reverseState.SetActive(true);
                spinState.SetActive(false);
                birdState.SetActive(false);
                troState.SetActive(false);
               
            }
             else if (currentState == AgentState.spin)
            {
                groundState.SetActive(false);
                flyingState.SetActive(false);
                gravityState.SetActive(false);
                reverseState.SetActive(false);
                spinState.SetActive(true);
                birdState.SetActive(false);
                troState.SetActive(false);
                
            }
             else if (currentState == AgentState.bird)
            {
                groundState.SetActive(false);
                flyingState.SetActive(false);
                gravityState.SetActive(false);
                reverseState.SetActive(false);
                spinState.SetActive(false);
                birdState.SetActive(true);
                troState.SetActive(false);
                
            }
            else if (currentState == AgentState.tro)
            {
                groundState.SetActive(false);
                flyingState.SetActive(false);
                gravityState.SetActive(false);
                reverseState.SetActive(false);
                spinState.SetActive(false);
                birdState.SetActive(false);
                troState.SetActive(true);
                
            }
            else if (currentState == AgentState.Zigzag)
            {
                groundState.SetActive(false);
                flyingState.SetActive(false);
                gravityState.SetActive(false);
                reverseState.SetActive(false);
                spinState.SetActive(false);
                birdState.SetActive(false);
                troState.SetActive(false);
              
            }
        }
    }
  
    private void Awake()
    {
        CurrentState = currentState;
    
    }
    void GameOver()
    {      
        gameOverObj.SetActive(true);
    }
    void GameWin()
    {
    gameWinObj.SetActive(true);
    }
    void Finish()
    {
        gameFinish.SetActive(true);
    }    
    void CameraScript()
    {
        cam.SetActive(false);
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Obstacle")){
        Destroy(gameObject);
        CameraScript();
        GameOver();
        }
        if (collision.gameObject.layer == LayerMask.NameToLayer("ObstacleEnd")){
        Destroy(gameObject);
        CameraScript();
        GameWin();
        }
        if (collision.gameObject.layer == LayerMask.NameToLayer("ObstacleFinish"))
        {
            Destroy(gameObject);
            CameraScript();
            Finish();
        }
    }
   
}
