using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    //角色生命值  
    public Texture playersHealthTexture;
    //控制上面那个Teture的屏幕所在位置  
    public float screenPositionX;
    public float screenPositionY;
    //控制桌面图标的大小  
    public int iconSizeX = 25;
    public int iconSizeY = 25;
    //初始生命值  
    public int playersHealth = 3; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        //控制角色生命值的心的显示  
        for (int h = 0; h < playersHealth; h++)
        {
            GUI.DrawTexture(new Rect(screenPositionX + (h * iconSizeX), screenPositionY, iconSizeX, iconSizeY), playersHealthTexture, ScaleMode.ScaleToFit, true, 0);
        }
    }

    public void Damage()
    {
        if (playersHealth < 1)
        {
            Application.LoadLevel(Application.loadedLevel);
        }

        playersHealth -= 1;
    }
}
