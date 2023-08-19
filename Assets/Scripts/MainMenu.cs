using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

 public void ExitButton(){
    Application.Quit();
    Debug.Log("Game Closed");
 }
 public void StartGame(){
    SceneManager.LoadScene("Game");
 }
  public void Game1(){
    SceneManager.LoadScene("Game");
 }
  public void Game2(){
    SceneManager.LoadScene("Game2");
 }
  public void Game3(){
    SceneManager.LoadScene("Game3");
 }
}



