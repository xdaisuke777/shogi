using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerContrlloer : MonoBehaviour
{

    public static string PlayerTurn = "red";
    public static string Phase = "Phase1";

    public static komaManager koma;

    public static GameObject komaSelect;
    public static GameObject boardSelect;

    public static bool firstflg = false;
    public static bool secondflg = false;

    public static bool naricheck = true;

    Vector3 v3;

    GameObject clickedGameObject;


    private static bool PocketSelect = false;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Phase == "GameEnd")
        {
            return;
        }
        //if (PlayerTurn == "red")
        //{
        //    if (Phase == "Phase1")
        //    {
        //        //駒の選択
        //        //移動マスの選択
        //        //駒の移動

        //    }
        //    if (Phase == "Phase2")
        //    {
        //        //成にするかどうか
        //    }
        //}
        //if (PlayerTurn == "blue")
        //{
        //    if (Phase == "Phase1")
        //    {

        //    }
        //    if (Phase == "Phase2")
        //    {

        //    }
        //}

        if (Phase == "PhaseEnd" && naricheck)
        {
            if (PlayerTurn == "red")//ターン切り替え
            {
                PlayerTurn = "blue";
            }
            else
            {
                PlayerTurn = "red";
            }
            Phase = "Phase1";
        }
    }

    private void OnMouseDown()
    {
        GameObject go = GameObject.Find("GameObject");
        GameManager gm = go.GetComponent<GameManager>();
        if (gm.MouseFlg)
        {
            return;
        }
        if (gameObject.tag == "koma" && gameObject.GetComponent<komaManager>().AttackList != null)
        {
            for (int i = 0; i < gameObject.GetComponent<komaManager>().AttackList.Count; i++)
            {
                Debug.Log("X:" + gameObject.GetComponent<komaManager>().AttackList[i].X + ",Y:" + gameObject.GetComponent<komaManager>().AttackList[i].Y + "," + gameObject.GetComponent<komaManager>().komaName);
            }
        }
        else
        {
            Debug.Log("null");
        }

        //駒を選んでいる。自分の駒を選んでいる
        if (gameObject.tag == "koma" && PlayerTurn == gameObject.GetComponent<komaManager>().Player && Phase == "Phase1")
        {
            //駒を選択したら
            koma = gameObject.GetComponent<komaManager>();//選んだ駒の情報
            if (koma.PocketFlg)
            {
                PocketSelect = true;
            }
            komaSelect = gameObject;
            gm.Main1 = gameObject;


            //第一引数：選んだ駒、第二引数：駒とボードの管理データ、第三引数：今のターンプレイヤー
            komaMovePoint kmp = new komaMovePoint(koma, gm, PlayerTurn);//場所を光らせる
            Phase = "Phase2";
        }




        //ボードのオブジェクトを選んでいる。移動範囲内を選んでいる
        else if (Phase == "Phase2")
        {
            if (gameObject.tag == "board" && gameObject.GetComponent<BoardManager>().PaintSelect)//ボードを選択したら
            {
                boardSelect = gameObject;
                //もし相手の駒だったら相手の駒を捕る
                for (int i = 0;i < gm.komas2.Count;i++)
                {
                    if (gm.komas2[i].GetComponent<komaManager>().ListX == boardSelect.GetComponent<BoardManager>().BoardX && gm.komas2[i].GetComponent<komaManager>().ListY == boardSelect.GetComponent<BoardManager>().BoardY)
                    {
                        string komaname = gm.komas2[i].GetComponent<komaManager>().komaName;
                        List<GameObject> Pocket = new List<GameObject> { };
                        for (int f = 0; f < gm.komas2.Count; f++)
                        {
                            if (gm.komas2[f].GetComponent<komaManager>().PocketFlg && gm.komas2[f].GetComponent<komaManager>().Player == PlayerTurn)//そのプレーヤーのポケットの数を調べる
                            {
                                Pocket.Add(gm.komas2[f]);
                            }
                        }
                        float pointX = 0.0f;
                        float pointZ = 0.0f;
                        float count = 0.0f;           
                        if (PlayerTurn == "red")
                        {
                            foreach (var p in Pocket)
                            {
                                if (p.GetComponent<komaManager>().komaName == komaname)//同じ駒があったら
                                {
                                    count++;                          
                                }
                            }
                            switch (komaname)
                            {
                                case "hu":
                                    if (count >= 9)
                                    {
                                        count = count - 9;
                                        pointX = 1;
                                    }
                                    break;
                                case "yari":
                                    pointX = 2;
                                    break;
                                case "uma":
                                    pointX = 3;
                                    break;
                                case "gin":
                                    pointX = 4;
                                    break;
                                case "kin":
                                    pointX = 5;
                                    break;
                                case "kaku":
                                    pointX = 2;
                                    pointZ = -4;
                                    break;
                                case "hisha":
                                    pointX = 3;
                                    pointZ = -4;
                                    break;
                                default:
                                    break;
                            }

                            gm.komas2[i].GetComponent<komaManager>().Player = "red";
                            gm.komas2[i].transform.position =  new Vector3(1.5f + pointX, 0.351f, 7.5f + pointZ - count);
                        }
                        else
                        {
                            foreach (var p in Pocket)
                            {
                                if (p.GetComponent<komaManager>().komaName == komaname)//同じ駒があったら
                                {
                                    count++;                                
                                }
                            }
                            switch (komaname)
                            {
                                case "hu":
                                    if (count >= 9)
                                    {
                                        count = count - 9;
                                        pointX = -1;
                                    }
                                    break;
                                case "yari":
                                    pointX = -2;
                                    break;
                                case "uma":
                                    pointX = -3;
                                    break;
                                case "gin":
                                    pointX = -4;
                                    break;
                                case "kin":
                                    pointX = -4;
                                    break;
                                case "kaku":
                                    pointX = -2;
                                    pointZ = 4;
                                    break;
                                case "hisha":
                                    pointX = -3;
                                    pointZ = 4;
                                    break;
                                default:
                                    break;
                            }
                            gm.komas2[i].GetComponent<komaManager>().Player = "blue";
                            gm.komas2[i].transform.position = new Vector3(-10.0f + pointX, 0.351f, 0.5f + pointZ + count);
                            
                        }
                        gm.komas2[i].transform.Rotate(new Vector3(0, 180, 0));
                        gm.komas2[i].GetComponent<komaManager>().PocketFlg = true;
                        gm.komas2[i].GetComponent<komaManager>().ListX = -1;
                        gm.komas2[i].GetComponent<komaManager>().ListY = -1;
                        gm.komas2[i].GetComponent<komaManager>().AttackList.Clear();
                        if (gm.komas2[i].GetComponent<komaManager>().nari)
                        {
                            gm.komas2[i].GetComponent<komaManager>().nari = false;
                            gm.komas2[i].transform.Rotate(new Vector3(0, 0, 180));
                        }
                        break;
                    }
                }






                
                //移動させる(ボード選択)
                for (int i = 0; i < gm.komas2.Count; i++)
                {
                    if (gm.komas2[i] == komaSelect)
                    {
                        bool flg = true;
                        if (komaSelect.GetComponent<komaManager>().Player == "red")
                        {
                            gm.komas2[i].GetComponent<komaManager>().oldX = gm.komas2[i].GetComponent<komaManager>().ListX;
                            gm.komas2[i].GetComponent<komaManager>().oldY = gm.komas2[i].GetComponent<komaManager>().ListY;
                            gm.komas2[i].GetComponent<komaManager>().ListY = boardSelect.GetComponent<BoardManager>().BoardY;
                            gm.komas2[i].GetComponent<komaManager>().ListX = boardSelect.GetComponent<BoardManager>().BoardX;

                            v3 = new Vector3(boardSelect.transform.position.x, komaSelect.transform.position.y, boardSelect.transform.position.z - 0.15f);


                            

                            //成の確認
                            if ((boardSelect.GetComponent<BoardManager>().BoardY < 3 || gm.komas2[i].GetComponent<komaManager>().oldY < 3 )&& !gm.komas2[i].GetComponent<komaManager>().nari && !gm.komas2[i].GetComponent<komaManager>().PocketFlg)
                            {
                                if (gm.komas2[i].GetComponent<komaManager>().komaName == "hu")
                                {
                                    if (gm.komas2[i].GetComponent<komaManager>().ListY == 0)
                                    {
                                        gm.komas2[i].GetComponent<komaManager>().nari = true;
                                        gm.komas2[i].transform.Rotate(new Vector3(0, 0, 180));
                                    }
                                    else
                                    {
                                        gm.Panel.SetActive(true);
                                        flg = false;
                                        gm.MouseFlg = true;
                                        naricheck = false;
                                    }
                                }
                                else if (gm.komas2[i].GetComponent<komaManager>().komaName == "yari")
                                {
                                    if (gm.komas2[i].GetComponent<komaManager>().ListY == 0)
                                    {
                                        gm.komas2[i].GetComponent<komaManager>().nari = true;
                                        gm.komas2[i].transform.Rotate(new Vector3(0, 0, 180));
                                    }
                                    else
                                    {
                                        gm.Panel.SetActive(true);
                                        flg = false;
                                        gm.MouseFlg = true;
                                        naricheck = false;
                                    }
                                }
                                else if (gm.komas2[i].GetComponent<komaManager>().komaName == "uma")
                                {
                                    if (gm.komas2[i].GetComponent<komaManager>().ListY <= 1)
                                    {
                                        gm.komas2[i].GetComponent<komaManager>().nari = true;
                                        gm.komas2[i].transform.Rotate(new Vector3(0, 0, 180));
                                    }
                                    else
                                    {
                                        gm.Panel.SetActive(true);
                                        flg = false;
                                        gm.MouseFlg = true;
                                        naricheck = false;
                                    }
                                }
                                else
                                {
                                    gm.Panel.SetActive(true);
                                    flg = false;
                                    gm.MouseFlg = true;
                                    naricheck = false;
                                }                  
                            }
                        }
                        else
                        {
                            gm.komas2[i].GetComponent<komaManager>().oldX = gm.komas2[i].GetComponent<komaManager>().ListX;
                            gm.komas2[i].GetComponent<komaManager>().oldY = gm.komas2[i].GetComponent<komaManager>().ListY;
                            gm.komas2[i].GetComponent<komaManager>().ListY = boardSelect.GetComponent<BoardManager>().BoardY;
                            gm.komas2[i].GetComponent<komaManager>().ListX = boardSelect.GetComponent<BoardManager>().BoardX;
                            v3 = new Vector3(boardSelect.transform.position.x, komaSelect.transform.position.y, boardSelect.transform.position.z);
                            if ((gm.komas2[i].GetComponent<komaManager>().ListY > 5 || gm.komas2[i].GetComponent<komaManager>().oldY > 5) && !komaSelect.GetComponent<komaManager>().nari && !gm.komas2[i].GetComponent<komaManager>().PocketFlg)
                            {
                                if (gm.komas2[i].GetComponent<komaManager>().komaName == "hu")
                                {
                                    if (gm.komas2[i].GetComponent<komaManager>().ListY == 8)
                                    {
                                        gm.komas2[i].GetComponent<komaManager>().nari = true;
                                        gm.komas2[i].transform.Rotate(new Vector3(0, 0, 180));
                                    }
                                    else
                                    {
                                        gm.Panel.SetActive(true);
                                        flg = false;
                                        gm.MouseFlg = true;
                                        naricheck = false;
                                    }
                                }
                                else if (gm.komas2[i].GetComponent<komaManager>().komaName == "yari")
                                {
                                    if (gm.komas2[i].GetComponent<komaManager>().ListY == 8)
                                    {
                                        gm.komas2[i].GetComponent<komaManager>().nari = true;
                                        gm.komas2[i].transform.Rotate(new Vector3(0, 0, 180));
                                    }
                                    else
                                    {
                                        gm.Panel.SetActive(true);
                                        flg = false;
                                        gm.MouseFlg = true;
                                        naricheck = false;
                                    }
                                }
                                else if (gm.komas2[i].GetComponent<komaManager>().komaName == "uma")
                                {
                                    if (gm.komas2[i].GetComponent<komaManager>().ListY >= 7)
                                    {
                                        gm.komas2[i].GetComponent<komaManager>().nari = true;
                                        gm.komas2[i].transform.Rotate(new Vector3(0, 0, 180));
                                    }
                                    else
                                    {
                                        gm.Panel.SetActive(true);
                                        flg = false;
                                        gm.MouseFlg = true;
                                        naricheck = false;
                                    }
                                }
                                else
                                {
                                    gm.Panel.SetActive(true);
                                    flg = false;
                                    gm.MouseFlg = true;
                                    naricheck = false;
                                }
                            }
                        }

                        komaSelect.transform.position = v3;
                        
                        gm.komas2[i].GetComponent<komaManager>().PocketFlg = false;//ポケットを解除

                        if (flg)
                        {
                            UpdateKoma(gm);

                            OuteCheak(gm);
                        }


                        

                        Phase = "PhaseEnd";
                        break;
                    }
                }
                if (PocketSelect)
                {
                    PocketReset(gm);
                }


                BoardReset(gm);



            }
            else if(gameObject.tag == "koma" && gameObject.GetComponent<komaManager>().PaintSelect)//駒を選択したら
            {
                
                float X2 = gameObject.GetComponent<komaManager>().ListX;
                float Y2 = gameObject.GetComponent<komaManager>().ListY;
                foreach (var b in gm.boads)
                {
                    foreach (var b2 in b)
                    {
                        if (b2.GetComponent<BoardManager>().BoardX == X2 && b2.GetComponent<BoardManager>().BoardY == Y2)
                        {
                            boardSelect = b2;
                        }
                    }

                }

                //相手の駒を取る
                for (int i = 0; i < gm.komas2.Count; i++)
                {
                    if (gm.komas2[i].GetComponent<komaManager>().ListX == (int)X2 && gm.komas2[i].GetComponent<komaManager>().ListY == (int)Y2 && gm.komas2[i].GetComponent<komaManager>().PocketFlg == false)
                    {
                        //相手の駒
                        string komaname = gm.komas2[i].GetComponent<komaManager>().komaName;
                        List<GameObject> Pocket = new List<GameObject> { };
                        for (int f = 0; f < gm.komas2.Count; f++)
                        {
                            if (gm.komas2[f].GetComponent<komaManager>().PocketFlg && gm.komas2[f].GetComponent<komaManager>().Player == PlayerTurn)//そのプレーヤーのポケットの数を調べる
                            {
                                Pocket.Add(gm.komas2[f]);
                            }
                        }
                        float pointX = 0.0f;
                        float pointZ = 0.0f;
                        float count = 0.0f;
                        if (PlayerTurn == "red")
                        {
                            foreach (var p in Pocket)
                            {
                                if (p.GetComponent<komaManager>().komaName == komaname)//同じ駒があったら
                                {
                                    count++;
                                }
                            }
                            switch (komaname)
                            {
                                case "hu":
                                    if (count >= 9)
                                    {
                                        count = count - 9;
                                        pointX = 1;
                                    }
                                    break;
                                case "yari":
                                    pointX = 2;
                                    break;
                                case "uma":
                                    pointX = 3;
                                    break;
                                case "gin":
                                    pointX = 4;
                                    break;
                                case "kin":
                                    pointX = 5;
                                    break;
                                case "kaku":
                                    pointX = 2;
                                    pointZ = -4;
                                    break;
                                case "hisha":
                                    pointX = 3;
                                    pointZ = -4;
                                    break;
                                default:
                                    break;
                            }

                            gm.komas2[i].GetComponent<komaManager>().Player = "red";
                            gm.komas2[i].transform.position = new Vector3(1.5f + pointX, 0.351f, 7.5f + pointZ - count);
                        }
                        else
                        {
                            foreach (var p in Pocket)
                            {
                                if (p.GetComponent<komaManager>().komaName == komaname)//同じ駒があったら
                                {
                                    count++;
                                }
                            }
                            switch (komaname)
                            {
                                case "hu":
                                    if (count >= 9)
                                    {
                                        count = count - 9;
                                        pointX = -1;
                                    }
                                    break;
                                case "yari":
                                    pointX = -2;
                                    break;
                                case "uma":
                                    pointX = -3;
                                    break;
                                case "gin":
                                    pointX = -4;
                                    break;
                                case "kin":
                                    pointX = -4;
                                    break;
                                case "kaku":
                                    pointX = -2;
                                    pointZ = 4;
                                    break;
                                case "hisha":
                                    pointX = -3;
                                    pointZ = 4;
                                    break;
                                default:
                                    break;
                            }
                            gm.komas2[i].GetComponent<komaManager>().Player = "blue";
                            gm.komas2[i].transform.position = new Vector3(-10.0f + pointX, 0.351f, 0.5f + pointZ + count);

                        }
                        gm.komas2[i].transform.Rotate(new Vector3(0, 180, 0));
                        gm.komas2[i].GetComponent<komaManager>().PocketFlg = true;
                        gm.komas2[i].GetComponent<komaManager>().ListX = -1;
                        gm.komas2[i].GetComponent<komaManager>().ListY = -1;
                        gm.komas2[i].GetComponent<komaManager>().AttackList.Clear();
                        if (gm.komas2[i].GetComponent<komaManager>().nari)
                        {
                            gm.komas2[i].GetComponent<komaManager>().nari = false;
                            gm.komas2[i].transform.Rotate(new Vector3(0, 0, 180));
                        }
                        break;
                    }
                }




                //移動させる(駒を選択)
                for (int i = 0; i < gm.komas2.Count; i++)
                {
                    if (gm.komas2[i] == komaSelect)
                    {
                        if (komaSelect.GetComponent<komaManager>().Player == "red")
                        {
                            gm.komas2[i].GetComponent<komaManager>().oldX = gm.komas2[i].GetComponent<komaManager>().ListX;
                            gm.komas2[i].GetComponent<komaManager>().oldY = gm.komas2[i].GetComponent<komaManager>().ListY;
                            gm.komas2[i].GetComponent<komaManager>().ListY = boardSelect.GetComponent<BoardManager>().BoardY;
                            gm.komas2[i].GetComponent<komaManager>().ListX = boardSelect.GetComponent<BoardManager>().BoardX;

                            v3 = new Vector3(boardSelect.transform.position.x, komaSelect.transform.position.y, boardSelect.transform.position.z - 0.15f);




                            //成の確認
                            if ((boardSelect.GetComponent<BoardManager>().BoardY < 3 || gm.komas2[i].GetComponent<komaManager>().oldY < 3) && !gm.komas2[i].GetComponent<komaManager>().nari && !gm.komas2[i].GetComponent<komaManager>().PocketFlg)
                            {
                                if (gm.komas2[i].GetComponent<komaManager>().komaName == "hu")
                                {
                                    if (gm.komas2[i].GetComponent<komaManager>().ListY == 0)
                                    {
                                        gm.komas2[i].GetComponent<komaManager>().nari = true;
                                        gm.komas2[i].transform.Rotate(new Vector3(0, 0, 180));
                                    }
                                    else
                                    {
                                        gm.Panel.SetActive(true);
                                        gm.MouseFlg = true;
                                        naricheck = false;
                                    }
                                }
                                else if (gm.komas2[i].GetComponent<komaManager>().komaName == "yari")
                                {
                                    if (gm.komas2[i].GetComponent<komaManager>().ListY == 0)
                                    {
                                        gm.komas2[i].GetComponent<komaManager>().nari = true;
                                        gm.komas2[i].transform.Rotate(new Vector3(0, 0, 180));
                                    }
                                    else
                                    {
                                        gm.Panel.SetActive(true);
                                        gm.MouseFlg = true;
                                        naricheck = false;
                                    }
                                }
                                else if (gm.komas2[i].GetComponent<komaManager>().komaName == "uma")
                                {
                                    if (gm.komas2[i].GetComponent<komaManager>().ListY <= 1)
                                    {
                                        gm.komas2[i].GetComponent<komaManager>().nari = true;
                                        gm.komas2[i].transform.Rotate(new Vector3(0, 0, 180));
                                    }
                                    else
                                    {
                                        gm.Panel.SetActive(true);
                                        gm.MouseFlg = true;
                                        naricheck = false;
                                    }
                                }
                                else
                                {
                                    gm.Panel.SetActive(true);
                                    gm.MouseFlg = true;
                                    naricheck = false;
                                }
                            }
                        }
                        else
                        {
                            gm.komas2[i].GetComponent<komaManager>().oldX = gm.komas2[i].GetComponent<komaManager>().ListX;
                            gm.komas2[i].GetComponent<komaManager>().oldY = gm.komas2[i].GetComponent<komaManager>().ListY;
                            gm.komas2[i].GetComponent<komaManager>().ListY = boardSelect.GetComponent<BoardManager>().BoardY;
                            gm.komas2[i].GetComponent<komaManager>().ListX = boardSelect.GetComponent<BoardManager>().BoardX;
                            v3 = new Vector3(boardSelect.transform.position.x, komaSelect.transform.position.y, boardSelect.transform.position.z);
                            if ((gm.komas2[i].GetComponent<komaManager>().ListY > 5 || gm.komas2[i].GetComponent<komaManager>().oldY  > 5 )&& !komaSelect.GetComponent<komaManager>().nari && !gm.komas2[i].GetComponent<komaManager>().PocketFlg)
                            {
                                if (gm.komas2[i].GetComponent<komaManager>().komaName == "hu")
                                {
                                    if (gm.komas2[i].GetComponent<komaManager>().ListY == 8)
                                    {
                                        gm.komas2[i].GetComponent<komaManager>().nari = true;
                                        gm.komas2[i].transform.Rotate(new Vector3(0, 0, 180));
                                    }
                                    else
                                    {
                                        gm.Panel.SetActive(true);
                                        gm.MouseFlg = true;
                                        naricheck = false;
                                    }
                                }
                                else if (gm.komas2[i].GetComponent<komaManager>().komaName == "yari")
                                {
                                    if (gm.komas2[i].GetComponent<komaManager>().ListY == 8)
                                    {
                                        gm.komas2[i].GetComponent<komaManager>().nari = true;
                                        gm.komas2[i].transform.Rotate(new Vector3(0, 0, 180));
                                    }
                                    else
                                    {
                                        gm.Panel.SetActive(true);
                                        gm.MouseFlg = true;
                                        naricheck = false;
                                    }
                                }
                                else if (gm.komas2[i].GetComponent<komaManager>().komaName == "uma")
                                {
                                    if (gm.komas2[i].GetComponent<komaManager>().ListY >= 7)
                                    {
                                        gm.komas2[i].GetComponent<komaManager>().nari = true;
                                        gm.komas2[i].transform.Rotate(new Vector3(0, 0, 180));
                                    }
                                    else
                                    {
                                        gm.Panel.SetActive(true);
                                        gm.MouseFlg = true;
                                        naricheck = false;
                                    }
                                }
                                else
                                {
                                    gm.Panel.SetActive(true);
                                    gm.MouseFlg = true;
                                    naricheck = false;
                                }
                            }
                        }

                        komaSelect.transform.position = v3;

                        gm.komas2[i].GetComponent<komaManager>().PocketFlg = false;//ポケットを解除

                        UpdateKoma(gm);

                        OuteCheak(gm);



                        Phase = "PhaseEnd";
                        break;
                    }
                }
                if (PocketSelect)
                {
                    PocketReset(gm);
                }


                BoardReset(gm);


            }
            else
            {
                Phase = "Phase1";
                BoardReset(gm);
            }
        }

    }

    private void BoardReset(GameManager gm)
    {
        for (int i = 0; i < gm.boads.Length; i++)
        {
            for (int j = 0; j < gm.boads[i].Length; j++)
            {
                if (gm.boads[i][j].GetComponent<BoardManager>().PaintSelect)
                {
                    gm.boads[i][j].GetComponent<Renderer>().material.color = new Color32(217, 141, 56, 255);
                    gm.boads[i][j].GetComponent<BoardManager>().PaintSelect = false;
                }
            }
        }
        for (int i = 0;i < gm.komas2.Count; i++)
        {
            if (gm.komas2[i].GetComponent<komaManager>().PaintSelect)
            {
                gm.komas2[i].GetComponent<komaManager>().PaintSelect = false;
            }
        }
        PocketSelect = false;
    }

    private void PocketReset(GameManager gm)
    {
        float pointX = 0.0f;
        float pointZ = 0.0f;

        float rHu = 0.0f;
        float rYari = 0.0f;
        float rUma = 0.0f;
        float rGin = 0.0f;
        float rKin = 0.0f;
        float rHisha = 0.0f;
        float rKaku = 0.0f;

        float bHu = 0.0f;
        float bYari = 0.0f;
        float bUma = 0.0f;
        float bGin = 0.0f;
        float bKin = 0.0f;
        float bHisha = 0.0f;
        float bKaku = 0.0f;




        for (int i = 0;i < gm.komas2.Count;i++)
        {
            if (gm.komas2[i].GetComponent<komaManager>().PocketFlg)
            {
                if (gm.komas2[i].GetComponent<komaManager>().Player == "red")
                {
                    switch (gm.komas2[i].GetComponent<komaManager>().komaName)
                    {
                        case "hu":
                            if (rHu >= 9)
                            {
                                pointX = 1;
                                gm.komas2[i].transform.position = new Vector3(1.5f + pointX, 0.351f, 7.5f + pointZ - rHu + 9);
                            }
                            else
                            {
                                gm.komas2[i].transform.position = new Vector3(1.5f + pointX, 0.351f, 7.5f + pointZ - rHu);
                            }

                            rHu++;
                            break;
                        case "yari":
                            pointX = 2;
                            gm.komas2[i].transform.position = new Vector3(1.5f + pointX, 0.351f, 7.5f + pointZ - rYari);
                            rYari++;
                            break;
                        case "uma":
                            pointX = 3;
                            gm.komas2[i].transform.position = new Vector3(1.5f + pointX, 0.351f, 7.5f + pointZ - rUma);
                            rUma++;
                            break;
                        case "gin":
                            pointX = 4;
                            gm.komas2[i].transform.position = new Vector3(1.5f + pointX, 0.351f, 7.5f + pointZ - rGin);
                            rGin++;
                            break;
                        case "kin":
                            pointX = 5;
                            gm.komas2[i].transform.position = new Vector3(1.5f + pointX, 0.351f, 7.5f + pointZ - rKin);
                            rKin++;
                            break;
                        case "kaku":
                            pointX = 2;
                            pointZ = -4;
                            gm.komas2[i].transform.position = new Vector3(1.5f + pointX, 0.351f, 7.5f + pointZ - rKaku);
                            rKaku++;
                            break;
                        case "hisha":
                            pointX = 3;
                            pointZ = -4;
                            gm.komas2[i].transform.position = new Vector3(1.5f + pointX, 0.351f, 7.5f + pointZ - rHisha);
                            rHisha++;
                            break;
                        default:
                            break;
                    }


                }
                else
                {
                    switch (gm.komas2[i].GetComponent<komaManager>().komaName)
                    {
                        case "hu":
                            if (bHu >= 9)
                            {
                                pointX = -1;
                                gm.komas2[i].transform.position = new Vector3(-10.0f + pointX, 0.351f, 0.5f + pointZ + bHu - 9);
                            }
                            else
                            {
                                gm.komas2[i].transform.position = new Vector3(-10.0f + pointX, 0.351f, 0.5f + pointZ + bHu);
                            }
                            
                            bHu++;
                            break;
                        case "yari":
                            pointX = -2;
                            gm.komas2[i].transform.position = new Vector3(-10.0f + pointX, 0.351f, 0.5f + pointZ + bYari);
                            bYari++;
                            break;
                        case "uma":
                            pointX = -3;
                            gm.komas2[i].transform.position = new Vector3(-10.0f + pointX, 0.351f, 0.5f + pointZ + bUma);
                            bUma++;
                            break;
                        case "gin":
                            pointX = -4;
                            gm.komas2[i].transform.position = new Vector3(-10.0f + pointX, 0.351f, 0.5f + pointZ + bGin);
                            bGin++;
                            break;
                        case "kin":
                            pointX = -4;
                            gm.komas2[i].transform.position = new Vector3(-10.0f + pointX, 0.351f, 0.5f + pointZ + bKin);
                            bKin++;
                            break;
                        case "kaku":
                            pointX = -2;
                            pointZ = 4;
                            gm.komas2[i].transform.position = new Vector3(-10.0f + pointX, 0.351f, 0.5f + pointZ + bKaku);
                            bKaku++;
                            break;
                        case "hisha":
                            pointX = -3;
                            pointZ = 4;
                            gm.komas2[i].transform.position = new Vector3(-10.0f + pointX, 0.351f, 0.5f + pointZ + bHisha);
                            bHisha++;
                            break;
                        default:
                            break;
                    }
                }
                pointX = 0.0f;
                pointZ = 0.0f;
            }
        }
    }

    public static void OuteCheak(GameManager gm)
    {
        GameObject Ou;
        if (PlayerTurn == "red")
        {
            Ou = GameObject.Find("BlueOu");
        }
        else
        {
            Ou = GameObject.Find("RedOu");
        }
        for (int i = 0;i < gm.komas2.Count; i++)
        {
            if (PlayerTurn == gm.komas2[i].GetComponent<komaManager>().Player)
            {
                for (int j = 0;j < gm.komas2[i].GetComponent<komaManager>().AttackList.Count;j++)
                {
                    if (Ou.GetComponent<komaManager>().ListX == gm.komas2[i].GetComponent<komaManager>().AttackList[j].X && Ou.GetComponent<komaManager>().ListY == gm.komas2[i].GetComponent<komaManager>().AttackList[j].Y)
                    {
                        //積みチェック
                        TumiCheak tumi = new TumiCheak(gm,PlayerTurn);
                        //gm.Tumi = true;
                        gm.PlayMusic();
                        if (tumi.Tumi)
                        {
                            Phase = "GameEnd";
                            Debug.Log("GameEnd");
                            gm.PlayMusic2(PlayerTurn);

                        }
                        break;
                    }
                }

            }

        }
    }
    //
    public static void UpdateKoma(GameManager gm)
    {
        foreach (var koma in gm.komas2)
        {
            koma.GetComponent<komaManager>().AttackPoint(gm);
        }
    }
}
