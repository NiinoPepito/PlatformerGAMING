using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void Accueil () {
        SceneManager.LoadScene("Accueil");
    }
    
    public void Didacticiel () {
        SceneManager.LoadScene("Didacticiel");
    }
    
    public void Niveau1 () {
        SceneManager.LoadScene("Niveau 1");
    }
    
    public void Niveau2 () {
        SceneManager.LoadScene("Niveau 2");
    }
    
    public void Niveau3 () {
        SceneManager.LoadScene("Niveau 3");
    }
    
    public void Niveau4 () {
        SceneManager.LoadScene("Niveau 4");
    }
}
