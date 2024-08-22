using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public string sceneToLoad; // Nome da cena para carregar qaundo o jogador entar 
    private void  OnTriggerenter2D(Collider2D other)
    {
      if (other.CompareTag("Player"))  //Verifica se o objeto Colidiu ao jogador
      {
        SceneManager.LoadScene(sceneToLoad);// Carrega a cena especifica 
      } 
    }
}
