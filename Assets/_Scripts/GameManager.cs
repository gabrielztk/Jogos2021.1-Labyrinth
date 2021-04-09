using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{
   private static GameManager _instance;

   public enum GameState { MENU, GAME, PAUSE, ENDGAME };
   public GameState gameState { get; private set; }


   public int gems;
   public int points;

   public int highScore;

    public static GameManager GetInstance()
    {
        
        if(_instance == null)
        {
            _instance = new GameManager();
        }

        return _instance;
    }

    private GameManager()
    {

        gameState = GameState.MENU;
        gems = 0;
        points = 0;
        highScore = 0;


        if (PlayerPrefs.HasKey("SavedHighScore"))
        {
            highScore = PlayerPrefs.GetInt("SavedHighScore");
        }
    }

    public delegate void ChangeStateDelegate();
    public static ChangeStateDelegate changeStateDelegate;

    public void ChangeState(GameState nextState)
    {
        if (nextState == GameState.GAME) Reset();
        gameState = nextState;
        changeStateDelegate();
    }

    private void Reset()
    {
        gems = 0;
        points = 0;
    }
}
