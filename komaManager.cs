using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class komaManager : MonoBehaviour
{
    public string komaName;

    public bool nari = false;

    public string Player;

    public int ListX = -1;
    public int ListY = -1;

    public int oldX;
    public int oldY;

    public bool flg = true;

    public bool PaintSelect = false;

    public bool PocketFlg = false;

    public List<Board> AttackList;

    public static bool Moved = false;
    // Start is called before the first frame update
    void Start()
    {
        AttackList = new List<Board> { }; ;
        GameObject go = GameObject.Find("GameObject");
        GameManager gm = go.GetComponent<GameManager>();
        if (ListX != -1)
        {
            AttackPoint(gm);
        }
        oldX = ListX;
        oldY = ListY;

    }

    // Update is called once per frame
    void Update()
    {
        //if (Moved)
        //{
            
        //    GameObject go = GameObject.Find("GameObject");
        //    GameManager gm = go.GetComponent<GameManager>();
        //    AttackPoint(gm);
        //    Moved = false;
        //}
 
    }
    
    public void AttackPoint(GameManager gm)
    {
        if (PocketFlg)
        {
            return;
        }
        AttackList.Clear();
        //if (komaName == "yari" && Player == "red")
        //{
        //    Debug.Log("");
        //}
        if (Player == "red")
        {
            if (komaName == "hu")
            {
                if (nari)
                {
                    for (int i = -1; i <= 1; i++)
                    {
                        if (komaPosition(ListY - 1, ListX + i, gm, Player))
                        {
                            komaPoint(ListY - 1, ListX + i, gm, Player);
                        }
                    }
                    for (int i = -1; i <= 1; i += 2)
                    {
                        if (komaPosition(ListY, ListX + i, gm, Player))
                        {
                            komaPoint(ListY, ListX + i, gm, Player);
                        }
                    }
                    if (komaPosition(ListY + 1, ListX, gm, Player))
                    {
                        komaPoint(ListY + 1, ListX, gm, Player);
                    }
                }
                else
                {
                    if (komaPosition(ListY - 1, ListX, gm, Player))
                    {
                        komaPoint(ListY - 1, ListX, gm, Player);
                    }
                }

            }
            else if (komaName == "yari")
            {
                if (nari)
                {
                    for (int i = -1; i <= 1; i++)
                    {
                        if (komaPosition(ListY - 1, ListX + i, gm, Player))
                        {
                            komaPoint(ListY - 1, ListX + i, gm, Player);
                        }
                    }
                    for (int i = -1; i <= 1; i += 2)
                    {
                        if (komaPosition(ListY, ListX + i, gm, Player))
                        {
                            komaPoint(ListY, ListX + i, gm, Player);
                        }
                    }
                    if (komaPosition(ListY + 1, ListX, gm, Player))
                    {
                        komaPoint(ListY + 1, ListX, gm, Player);
                    }
                }
                else
                {
                    for (int i = ListY - 1; i >= 0 && komaPosition(i, ListX, gm, Player); i--)
                    {
                        komaPoint(i, ListX, gm, Player);
                    }
                }

            }
            else if (komaName == "uma")
            {
                if (nari)
                {
                    for (int i = -1; i <= 1; i++)
                    {
                        if (komaPosition(ListY - 1, ListX + i, gm, Player))
                        {
                            komaPoint(ListY - 1, ListX + i, gm, Player);
                        }
                    }
                    for (int i = -1; i <= 1; i += 2)
                    {
                        if (komaPosition(ListY, ListX + i, gm, Player))
                        {
                            komaPoint(ListY, ListX + i, gm, Player);
                        }
                    }
                    if (komaPosition(ListY + 1, ListX, gm, Player))
                    {
                        komaPoint(ListY + 1, ListX, gm, Player);
                    }
                }
                else
                {
                    for (int i = -1; i <= 1; i += 2)
                    {
                        if (komaPosition(ListY - 2, ListX + i, gm, Player))
                        {
                            komaPoint(ListY - 2, ListX + i, gm, Player);
                        }
                    }
                }

            }
            else if (komaName == "gin")
            {
                if (nari)
                {
                    for (int i = -1; i <= 1; i++)
                    {
                        if (komaPosition(ListY - 1, ListX + i, gm, Player))
                        {
                            komaPoint(ListY - 1, ListX + i, gm, Player);
                        }
                    }
                    for (int i = -1; i <= 1; i += 2)
                    {
                        if (komaPosition(ListY, ListX + i, gm, Player))
                        {
                            komaPoint(ListY, ListX + i, gm, Player);
                        }
                    }
                    if (komaPosition(ListY + 1, ListX, gm, Player))
                    {
                        komaPoint(ListY + 1, ListX, gm, Player);
                    }
                }
                else
                {
                    for (int i = -1; i <= 1; i += 2)
                    {
                        if (komaPosition(ListY - 1, ListX + i, gm, Player))
                        {
                            komaPoint(ListY - 1, ListX + i, gm, Player);
                        }
                        if (komaPosition(ListY + 1, ListX + i, gm, Player))
                        {
                            komaPoint(ListY + 1, ListX + i, gm, Player);
                        }
                    }
                    if (komaPosition(ListY - 1, ListX, gm, Player))
                    {
                        komaPoint(ListY - 1, ListX, gm, Player);
                    }
                }

            }
            else if (komaName == "kin")
            {
                for (int i = -1; i <= 1; i++)
                {
                    if (komaPosition(ListY - 1, ListX + i, gm, Player))
                    {
                        komaPoint(ListY - 1, ListX + i, gm, Player);
                    }
                }
                for (int i = -1; i <= 1; i += 2)
                {
                    if (komaPosition(ListY, ListX + i, gm, Player))
                    {
                        komaPoint(ListY, ListX + i, gm, Player);
                    }
                }
                if (komaPosition(ListY + 1, ListX, gm, Player))
                {
                    komaPoint(ListY + 1, ListX, gm, Player);
                }
            }
            else if (komaName == "kaku")
            {
                if (nari)
                {
                    for (int i = -1; i <= 1; i += 2)
                    {
                        if (komaPosition(ListY + i, ListX, gm, Player))
                        {
                            komaPoint(ListY + i, ListX, gm, Player);
                        }

                    }
                    for (int j = -1; j <= 1; j += 2)
                    {
                        if (komaPosition(ListY, ListX + j, gm, Player))
                        {
                            komaPoint(ListY, ListX + j, gm, Player);
                        }

                    }
                    for (int i = ListY - 1, j = ListX - 1; i >= 0 && j >= 0 && komaPosition(i, j, gm, Player); i--, j--)
                    {
                        komaPoint(i, j, gm, Player);
                    }
                    for (int i = ListY - 1, j = ListX + 1; i >= 0 && j < 9 && komaPosition(i, j, gm, Player); i--, j++)
                    {
                        komaPoint(i, j, gm, Player);
                    }
                    for (int i = ListY + 1, j = ListX - 1; i < 9 && j >= 0 && komaPosition(i, j, gm, Player); i++, j--)
                    {
                        komaPoint(i, j, gm, Player);
                    }
                    for (int i = ListY + 1, j = ListX + 1; i < 9 && j < 9 && komaPosition(i, j, gm, Player); i++, j++)
                    {
                        komaPoint(i, j, gm, Player);
                    }
                }
                else
                {
                    for (int i = ListY - 1, j = ListX - 1; i >= 0 && j >= 0 && komaPosition(i, j, gm, Player); i--, j--)
                    {
                        komaPoint(i, j, gm, Player);
                    }
                    for (int i = ListY - 1, j = ListX + 1; i >= 0 && j < 9 && komaPosition(i, j, gm, Player); i--, j++)
                    {
                        komaPoint(i, j, gm, Player);
                    }
                    for (int i = ListY + 1, j = ListX - 1; i < 9 && j >= 0 && komaPosition(i, j, gm, Player); i++, j--)
                    {
                        komaPoint(i, j, gm, Player);
                    }
                    for (int i = ListY + 1, j = ListX + 1; i < 9 && j < 9 && komaPosition(i, j, gm, Player); i++, j++)
                    {
                        komaPoint(i, j, gm, Player);
                    }
                }

            }
            else if (komaName == "hisha")
            {
                if (nari)
                {
                    for (int i = -1, j = -1; i <= 1; i += 2)
                    {
                        if (komaPosition(ListY + i, ListX + j, gm, Player))
                        {
                            komaPoint(ListY + i, ListX + j, gm, Player);
                        }

                    }
                    for (int i = -1, j = +1; i <= 1; i += 2)
                    {
                        if (komaPosition(ListY + i, ListX + j, gm, Player))
                        {
                            komaPoint(ListY + i, ListX + j, gm, Player);
                        }

                    }
                    for (int i = ListY + 1; i < 9 && komaPosition(i, ListX, gm, Player); i++)
                    {
                        komaPoint(i, ListX, gm, Player);
                    }
                    for (int i = ListY - 1; i >= 0 && komaPosition(i, ListX, gm, Player); i--)
                    {
                        komaPoint(i, ListX, gm, Player);
                    }
                    for (int j = ListX + 1; j < 9 && komaPosition(ListY, j, gm, Player); j++)
                    {
                        komaPoint(ListY, j, gm, Player);
                    }
                    for (int j = ListX - 1; j >= 0 && komaPosition(ListY, j, gm, Player); j--)
                    {
                        komaPoint(ListY, j, gm, Player);
                    }
                }
                else
                {
                    for (int i = ListY + 1; i < 9 && komaPosition(i, ListX, gm, Player); i++)
                    {
                        komaPoint(i, ListX, gm, Player);
                    }
                    for (int i = ListY - 1; i >= 0 && komaPosition(i, ListX, gm, Player); i--)
                    {
                        komaPoint(i, ListX, gm, Player);
                    }
                    for (int j = ListX + 1; j < 9 && komaPosition(ListY, j, gm, Player); j++)
                    {
                        komaPoint(ListY, j, gm, Player);
                    }
                    for (int j = ListX - 1; j >= 0 && komaPosition(ListY, j, gm, Player); j--)
                    {
                        komaPoint(ListY, j, gm, Player);
                    }
                }

            }
            else if (komaName == "ou")
            {
                for (int i = -1; i <= 1; i++)
                {
                    if (komaPosition(ListY - 1, ListX + i, gm, Player))
                    {
                        komaPoint(ListY - 1, ListX + i, gm, Player);
                    }
                    if (komaPosition(ListY + 1, ListX + i, gm, Player))
                    {
                        komaPoint(ListY + 1, ListX + i, gm, Player);
                    }
                }
                for (int i = -1; i <= 1 && komaPosition(ListY, ListX + i, gm, Player); i += 2)
                {
                    komaPoint(ListY, ListX + i, gm, Player);
                }

            }
        }
        else
        {
            if (komaName == "hu")
            {
                if (nari)
                {
                    for (int i = -1; i <= 1; i++)
                    {
                        if (komaPosition(ListY + 1, ListX + i, gm, Player))
                        {
                            komaPoint(ListY + 1, ListX + i, gm, Player);
                        }
                    }
                    for (int i = -1; i <= 1; i += 2)
                    {
                        if (komaPosition(ListY, ListX + i, gm, Player))
                        {
                            komaPoint(ListY, ListX + i, gm, Player);
                        }
                    }
                    if (komaPosition(ListY - 1, ListX, gm, Player))
                    {
                        komaPoint(ListY - 1, ListX, gm, Player);
                    }
                }
                else
                {
                    if (komaPosition(ListY + 1, ListX, gm, Player))
                    {
                        komaPoint(ListY + 1, ListX, gm, Player);
                    }
                }

            }
            else if (komaName == "yari")
            {
                if (nari)
                {
                    for (int i = -1; i <= 1; i++)
                    {
                        if (komaPosition(ListY + 1, ListX + i, gm, Player))
                        {
                            komaPoint(ListY + 1, ListX + i, gm, Player);
                        }
                    }
                    for (int i = -1; i <= 1; i += 2)
                    {
                        if (komaPosition(ListY, ListX + i, gm, Player))
                        {
                            komaPoint(ListY, ListX + i, gm, Player);
                        }
                    }
                    if (komaPosition(ListY - 1, ListX, gm, Player))
                    {
                        komaPoint(ListY - 1, ListX, gm, Player);
                    }
                }
                else
                {
                    for (int i = ListY + 1; i < 9 && komaPosition(i, ListX, gm, Player); i++)
                    {
                        komaPoint(i, ListX, gm, Player);
                    }
                }

            }
            else if (komaName == "uma")
            {
                if (nari)
                {
                    for (int i = -1; i <= 1; i++)
                    {
                        if (komaPosition(ListY + 1, ListX + i, gm, Player))
                        {
                            komaPoint(ListY + 1, ListX + i, gm, Player);
                        }
                    }
                    for (int i = -1; i <= 1; i += 2)
                    {
                        if (komaPosition(ListY, ListX + i, gm, Player))
                        {
                            komaPoint(ListY, ListX + i, gm, Player);
                        }
                    }
                    if (komaPosition(ListY - 1, ListX, gm, Player))
                    {
                        komaPoint(ListY - 1, ListX, gm, Player);
                    }
                }
                else
                {
                    for (int i = -1; i <= 1; i += 2)
                    {
                        if (komaPosition(ListY + 2, ListX + i, gm, Player))
                        {
                            komaPoint(ListY + 2, ListX + i, gm, Player);
                        }

                    }
                }

            }
            else if (komaName == "gin")
            {
                if (nari)
                {
                    for (int i = -1; i <= 1; i++)
                    {
                        if (komaPosition(ListY + 1, ListX + i, gm, Player))
                        {
                            komaPoint(ListY + 1, ListX + i, gm, Player);
                        }
                    }
                    for (int i = -1; i <= 1; i += 2)
                    {
                        if (komaPosition(ListY, ListX + i, gm, Player))
                        {
                            komaPoint(ListY, ListX + i, gm, Player);
                        }
                    }
                    if (komaPosition(ListY - 1, ListX, gm, Player))
                    {
                        komaPoint(ListY - 1, ListX, gm, Player);
                    }
                }
                else
                {
                    for (int i = -1; i <= 1; i += 2)
                    {
                        if (komaPosition(ListY - 1, ListX + i, gm, Player))
                        {
                            komaPoint(ListY - 1, ListX + i, gm, Player);
                        }
                        if (komaPosition(ListY + 1, ListX + i, gm, Player))
                        {
                            komaPoint(ListY + 1, ListX + i, gm, Player);
                        }
                    }
                    if (komaPosition(ListY + 1, ListX, gm, Player))
                    {
                        komaPoint(ListY + 1, ListX, gm, Player);
                    }
                }

            }
            else if (komaName == "kin")
            {
                for (int i = -1; i <= 1; i++)
                {
                    if (komaPosition(ListY + 1, ListX + i, gm, Player))
                    {
                        komaPoint(ListY + 1, ListX + i, gm, Player);
                    }
                }
                for (int i = -1; i <= 1; i += 2)
                {
                    if (komaPosition(ListY, ListX + i, gm, Player))
                    {
                        komaPoint(ListY, ListX + i, gm, Player);
                    }
                }
                if (komaPosition(ListY - 1, ListX, gm, Player))
                {
                    komaPoint(ListY - 1, ListX, gm, Player);
                }
            }
            else if (komaName == "kaku")
            {
                if (nari)
                {
                    for (int i = -1; i <= 1; i += 2)
                    {
                        if (komaPosition(ListY + i, ListX, gm, Player))
                        {
                            komaPoint(ListY + i, ListX, gm, Player);
                        }
                    }
                    for (int j = -1; j <= 1; j += 2)
                    {
                        if (komaPosition(ListY, ListX + j, gm, Player))
                        {
                            komaPoint(ListY, ListX + j, gm, Player);
                        }

                    }
                    for (int i = ListY - 1, j = ListX - 1; i >= 0 && j >= 0 && komaPosition(i, j, gm, Player); i--, j--)
                    {
                        komaPoint(i, j, gm, Player);
                    }
                    for (int i = ListY - 1, j = ListX + 1; i >= 0 && j < 9 && komaPosition(i, j, gm, Player); i--, j++)
                    {
                        komaPoint(i, j, gm, Player);
                    }
                    for (int i = ListY + 1, j = ListX - 1; i < 9 && j >= 0 && komaPosition(i, j, gm, Player); i++, j--)
                    {
                        komaPoint(i, j, gm, Player);
                    }
                    for (int i = ListY + 1, j = ListX + 1; i < 9 && j < 9 && komaPosition(i, j, gm, Player); i++, j++)
                    {
                        komaPoint(i, j, gm, Player);
                    }
                }
                else
                {
                    for (int i = ListY - 1, j = ListX - 1; i >= 0 && j >= 0 && komaPosition(i, j, gm, Player); i--, j--)
                    {
                        komaPoint(i, j, gm, Player);
                    }
                    for (int i = ListY - 1, j = ListX + 1; i >= 0 && j < 9 && komaPosition(i, j, gm, Player); i--, j++)
                    {
                        komaPoint(i, j, gm, Player);
                    }
                    for (int i = ListY + 1, j = ListX - 1; i < 9 && j >= 0 && komaPosition(i, j, gm, Player); i++, j--)
                    {
                        komaPoint(i, j, gm, Player);
                    }
                    for (int i = ListY + 1, j = ListX + 1; i < 9 && j < 9 && komaPosition(i, j, gm, Player); i++, j++)
                    {
                        komaPoint(i, j, gm, Player);
                    }
                }

            }
            else if (komaName == "hisha")
            {
                if (nari)
                {
                    for (int i = -1, j = -1; i <= 1; i += 2)
                    {
                        if (komaPosition(ListY + i, ListX + j, gm, Player))
                        {
                            komaPoint(ListY + i, ListX + j, gm, Player);
                        }

                    }
                    for (int i = -1, j = 1; i <= 1; i += 2)
                    {
                        if (komaPosition(ListY + i, ListX + j, gm, Player))
                        {
                            komaPoint(ListY + i, ListX + j, gm, Player);
                        }

                    }
                    for (int i = ListY + 1; i < 9 && komaPosition(i, ListX, gm, Player); i++)
                    {
                        komaPoint(i, ListX, gm, Player);
                    }
                    for (int i = ListY - 1; i >= 0 && komaPosition(i, ListX, gm, Player); i--)
                    {
                        komaPoint(i, ListX, gm, Player);
                    }
                    for (int j = ListX + 1; j < 9 && komaPosition(ListY, j, gm, Player); j++)
                    {
                        komaPoint(ListY, j, gm, Player);
                    }
                    for (int j = ListX - 1; j >= 0 && komaPosition(ListY, j, gm, Player); j--)
                    {
                        komaPoint(ListY, j, gm, Player);
                    }
                }
                else
                {
                    for (int i = ListY + 1; i < 9 && komaPosition(i, ListX, gm, Player); i++)
                    {
                        komaPoint(i, ListX, gm, Player);
                    }
                    for (int i = ListY - 1; i >= 0 && komaPosition(i, ListX, gm, Player); i--)
                    {
                        komaPoint(i, ListX, gm, Player);
                    }
                    for (int j = ListX + 1; j < 9 && komaPosition(ListY, j, gm, Player); j++)
                    {
                        komaPoint(ListY, j, gm, Player);
                    }
                    for (int j = ListX - 1; j >= 0 && komaPosition(ListY, j, gm, Player); j--)
                    {
                        komaPoint(ListY, j, gm, Player);
                    }
                }

            }
            else if (komaName == "ou")
            {
                for (int i = -1; i <= 1; i++)
                {
                    if (komaPosition(ListY - 1, ListX + i, gm, Player))
                    {
                        komaPoint(ListY - 1, ListX + i, gm, Player);
                    }
                    if (komaPosition(ListY + 1, ListX + i, gm, Player))
                    {
                        komaPoint(ListY + 1, ListX + i, gm, Player);
                    }
                }
                for (int i = -1; i <= 1 && komaPosition(ListY, ListX + i, gm, Player); i += 2)
                {
                    komaPoint(ListY, ListX + i, gm, Player);
                }

            }
        }
    }

    void komaPoint(int Y, int X, GameManager gm, string Player)
    {
        Board b = new Board();
        b.X = X;
        b.Y = Y;
        AttackList.Add(b);
    }



    bool komaPosition(int Y, int X, GameManager gm, string Player)
    {
        if (0 <= Y && Y < 9 && 0 <= X && X < 9)//ボード内
        {
            for (int i = 0; i < gm.komas2.Count; i++)
            {
                //自分の駒の上には置けない
                if (gm.komas2[i].GetComponent<komaManager>().ListX == X && gm.komas2[i].GetComponent<komaManager>().ListY == Y && gm.komas2[i].GetComponent<komaManager>().PocketFlg == false)
                {
                    //if (gm.komas2[i].GetComponent<komaManager>().Player == Player)
                    //{

                    //}
                    Board b = new Board();
                    b.X = X;
                    b.Y = Y;
                    AttackList.Add(b);
                    return false;
                }
            }
            return true;
        }
        return false;

    }
}
