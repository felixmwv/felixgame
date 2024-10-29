using UnityEngine;

public class keepScore : MonoBehaviour { 

    public static int Score = 0;

  
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnGUI()
    {
        GUI.Box(new Rect(100, 100, 100, 100), Score.ToString());
    }
}
