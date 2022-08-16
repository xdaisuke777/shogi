using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject[] boads1;
    public GameObject[] boads2;
    public GameObject[] boads3;
    public GameObject[] boads4;
    public GameObject[] boads5;
    public GameObject[] boads6;
    public GameObject[] boads7;
    public GameObject[] boads8;
    public GameObject[] boads9;

    public GameObject[][] boads;

    public GameObject[] komas;
    public List<GameObject> komas2;


    public GameObject hu;
    public GameObject yari;
    public GameObject uma;
    public GameObject gin;
    public GameObject kin;
    public GameObject kaku;
    public GameObject hisha;

    public GameObject PlayerTurnText;
    public GameObject Panel;
    public GameObject NariButton;
    public GameObject NoNariButton;

    public bool MouseFlg = false;

    public AudioSource taisenBGM;
    public AudioSource outeBGM;

    public AudioSource op;
    public AudioSource ed;

    private bool bgmCange = true;



    public bool OuteFlg = false;


    public GameObject Main1;
    public GameObject Main2;

    public bool Tumi = false;

    private bool end = false;
    // Start is called before the first frame update
    void Start()
    {
        boads = new GameObject[][] {boads1,boads2,boads3,boads4,boads5,boads6,boads7,boads8,boads9 };
        Panel.SetActive(false);
;    }

    // Update is called once per frame
    void Update()
    {
        if (end)
        {
            return;
        }
        if (PlayerContrlloer.PlayerTurn == "red")
        {
            PlayerTurnText.GetComponent<Text>().text = "赤プレイヤー";
            PlayerTurnText.GetComponent<Text>().color = new Color32(233, 76, 76, 255);
 
        }
        else
        {
            PlayerTurnText.GetComponent<Text>().text = "青プレイヤー";
            PlayerTurnText.GetComponent<Text>().color = new Color32(106, 229, 241, 255);
        }

    }

    public void PlayMusic()
    {
        if (taisenBGM != null && outeBGM != null && bgmCange)
        {
            taisenBGM.Stop();
            outeBGM.Play();
            bgmCange = false;
        }
        else
        {
            Debug.Log("オーディオが設定されていません");
        }
    }
    public void PlayMusic2(string PlayerTurn)
    {
        end = true;
        if (ed != null)
        {
            outeBGM.Stop();
            ed.Play();
            if (PlayerTurn == "red")
            {
                PlayerTurnText.GetComponent<Text>().text = "赤プレイヤーの勝利";
            }
            else
            {
                PlayerTurnText.GetComponent<Text>().text = "青プレイヤーの勝利";
            }
        }
        else
        {
            Debug.Log("オーディオが設定されていません");
        }
    }

}
