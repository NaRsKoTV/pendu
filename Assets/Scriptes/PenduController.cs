using UnityEngine;
using UnityEngine.UI;
public class PenduController : MonoBehaviour
{
    public Sprite[] imagesPendu;
    public Image  imagePendu;
    public GameOverUI gameOverUI;
    public void IncrementerErreur(int erreur)
    {
        if (erreur <7)
        {
            imagePendu.sprite = imagesPendu[erreur];
        }
        else
        {
            gameOverUI.SetGoUI ("TU A PERDU TU EST NUL ESSAYE ENCORE");
            Debug.Log("Le joueur a perdu !");
        }
    }
}