using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{ 
    public static GameManager Instance { get; private set;}
    private List < string > wordList = new List < string > {"banane","poulet","pate","tomate","football","trampoline","anticonstitutionnellement","mouton","papillon","sommeil","enfant","estomac"};
    private string hiddenWord;
    private char[] shownWord;
    [SerializeField]private TextMeshProUGUI shownWordTMP;
    private int erreur; 
    private PenduController penduController;
    public GameOverUI gameOverUI;
    private void Awake(){
        Instance = this;
    }
    
    private void Start (){
        penduController = GetComponent<PenduController>();
        penduController.IncrementerErreur(erreur);
        ChooseWord();
        Debug.Log(hiddenWord);
        SetWord();
        DisplayWord();
        //choisis un mots definis le et affiche le 
    }
    private void ChooseWord(){
        int rand = Random.Range(0,wordList.Count);
        hiddenWord=wordList[rand];
        //Choisis un mots que seul le jeu peu voir 
    }
    private void SetWord(){
        shownWord= new char[hiddenWord.Length];
        for (int i = 0;i<shownWord.Length;i++){
            shownWord[i]='_';
        }
            //definit le mots 
    }
    private void DisplayWord(){
        string word ="";
        foreach(char c in shownWord ){
            word+=(char)c;  
        }
        Debug.Log(word);
        shownWordTMP.text=word;     
    }

    public void TestLetter(char letter){
        char l=char.ToLower(letter);
        if(hiddenWord.Contains(l)){
            for (int i = 0;i<shownWord.Length;i++){
                if(hiddenWord[i] == l){
                    shownWord[i]=l;
                }  
            }
           DisplayWord();
           TesteVictory();
        }
        else{
            erreur++ ;
            penduController.IncrementerErreur(erreur);
        }
    }

    private void TesteVictory(){
        string word ="";
        foreach(char c in shownWord ){
            word+=(char)c;  
        }
        if (hiddenWord== word){
            Debug.Log("le joueur a gagné");
             gameOverUI.SetGoUI ("victoire");
        }    
    }
}