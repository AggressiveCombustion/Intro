using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine.SceneManagement;

public class ModifyText : MonoBehaviour
{
    [SerializeField]
    TMP_Text myText;

    [SerializeField, Range(0, 1f)]
    float redAmount = 0;

    // Start is called before the first frame update
    void Start()
    {
        myText.text = "Hello World";

        float r = Random.Range(0, 1f);
        float g = Random.Range(0, 1f);
        float b = Random.Range(0, 1f);

        Color c = new Color(r,g,b);

        myText.color = c;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoThing(int num)
    {
        Debug.Log("Clicked the button " + num);
    }

    public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
