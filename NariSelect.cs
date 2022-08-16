using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NariSelect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Nari()
    {
        GameObject go = GameObject.Find("GameObject");
        GameManager gm = go.GetComponent<GameManager>();
        gm.MouseFlg = false;
        PlayerContrlloer.komaSelect.GetComponent<komaManager>().nari = true;
        PlayerContrlloer.komaSelect.transform.Rotate(new Vector3(0,0,180));
        PlayerContrlloer.UpdateKoma(gm);
        PlayerContrlloer.OuteCheak(gm);
        PlayerContrlloer.naricheck = true;
        GameObject panel = GameObject.Find("Panel");
        panel.SetActive(false);
        
        

    }

    public void NoNari()
    {
        GameObject go = GameObject.Find("GameObject");
        GameManager gm = go.GetComponent<GameManager>();
        gm.MouseFlg = false;
        PlayerContrlloer.UpdateKoma(gm);
        PlayerContrlloer.OuteCheak(gm);
        PlayerContrlloer.naricheck = true;
        GameObject panel = GameObject.Find("Panel");
        panel.SetActive(false);
    }
}
