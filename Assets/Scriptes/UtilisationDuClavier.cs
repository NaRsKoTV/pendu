using UnityEngine;
using UnityEngine.UI;

public class ClavierVirtuel : MonoBehaviour
{
    private Text texte;
    public string lettre;
    private void Start(){
        texte = GetComponentInChildren<Text>();
        texte.text=lettre;
    }
    public void AppuyerSurTouche()
    {
        GameManager.Instance.TestLetter(lettre[0]);
        AudioManager.Instance.PlayButtonSfx();
        GetComponent<Button>().interactable=false;
    }
}