using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class ReturnToPreviousScene : MonoBehaviour
{
    private bool _hasClicked = false;

    public void OnButtonClick()
    {
        _hasClicked = true;
        StartCoroutine(ReturnAfterDelay());
    }

    private IEnumerator ReturnAfterDelay()
    {
        yield return new WaitForSeconds(15);

        if (_hasClicked)
        {
            int previousSceneIndex = SceneManager.GetActiveScene().buildIndex - 1;
            SceneManager.LoadScene(previousSceneIndex);
        }
    }
}