using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum GameModes
{
    Dig = 0,
    Build,
    TotalCount
};

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<GameManager>();
                //DontDestroyOnLoad(_instance.gameObject);
            }

            return _instance;
        }
    }

    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            //DontDestroyOnLoad(this);
        }
        else
        {
            if (this != _instance)
                Destroy(this.gameObject);
        }
    }

    public LevelManager Level;
    public UIManager UI;

    public GameModes GameMode;

    // Start is called before the first frame update
    void Start()
    {
        GameMode = GameModes.Dig;
        Level.GenerateLevel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
