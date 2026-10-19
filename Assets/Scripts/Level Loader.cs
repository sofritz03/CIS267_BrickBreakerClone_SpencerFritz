using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public string[] levels;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LoadRandomLevel(); 
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void LoadRandomLevel()
    {
        int index = Random.Range(0, levels.Length);  
        SceneManager.LoadScene(levels[index]);        
    }
}
