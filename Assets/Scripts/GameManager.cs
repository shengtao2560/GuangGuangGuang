﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/// <summary>
/// 游戏UI初始化 & 流程控制
/// </summary>
public class GameManager : MonoBehaviour {
    public static GameManager gm;
    private enum GameState {Playing, Win, Faild };
    private static GameState gamestate = GameState.Playing;
    public int StartRoom = 1;
    public int MinRoom = 1;
    public int MaxRoom = 7;
	// Use this for initialization
	void Start () {
        if(gm == null)
            gm = this.GetComponent<GameManager>();
        SceneManager.LoadScene("PlayingMenu", LoadSceneMode.Additive);
        gamestate = GameState.Playing;

    }
	public void GameWin()
    {
        gamestate = GameState.Win;
    }
    public void GameFaild()
    {
        gamestate = GameState.Faild;
    }
	// Update is called once per frame
	void Update () {
        if (gamestate == GameState.Faild)
            UIFun.ui.ShowFaildMenu();
        else if (gamestate == GameState.Win)
            UIFun.ui.ShowWinMenu();

	}
}