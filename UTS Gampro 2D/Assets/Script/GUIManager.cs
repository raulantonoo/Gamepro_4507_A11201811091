﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{
    public void OnPlay(){
        SceneManager.LoadScene("SampleScene");
    }
    public void OnCredit(){
        SceneManager.LoadScene("Credit");
    }
    public void OnHelp(){
        SceneManager.LoadScene("Help");
    }
    public void OnMenu(){
        SceneManager.LoadScene("Menu");
    }
    public void OnAgain(){
        SceneManager.LoadScene("Playagain");
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
