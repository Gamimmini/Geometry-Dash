using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameWin : MonoBehaviour
{
public void RestartButton(){
    SceneManager.LoadScene("Game");
 }
 public void Restart2Button(){
    SceneManager.LoadScene("Game2");
 }
 public void Restart3Button(){
    SceneManager.LoadScene("Game3");
 }
 public void NextButton(){
    SceneManager.LoadScene("Game2");
 }
 public void NextButton3(){
    SceneManager.LoadScene("Game3");
 }
 public void MenuButton(){
    SceneManager.LoadScene("MainMenu");
 }
}
