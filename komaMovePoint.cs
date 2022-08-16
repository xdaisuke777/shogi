using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class komaMovePoint
{
    public int X;
    public int Y;
    private string komaName;
    private string PlayerTurn;
    private GameManager gm;
    private komaManager koma;//�G���Ă����

    private GameObject ou;
    public komaMovePoint(komaManager koma, GameManager gm ,string PlayerTurn)//�I��������A���݂̋�̔z�u��
    {
        string Player = koma.Player;
        this.komaName = koma.komaName;
        this.PlayerTurn = PlayerTurn;

        this.gm = gm;
        this.koma = koma;

        this.X = koma.ListX;
        this.Y = koma.ListY;
        bool Pocket = koma.PocketFlg;

        //�����̉��𒲂ׂ�
        if (PlayerTurn == "red")
        {
            this.ou = GameObject.Find("RedOu");
        }
        else
        {
            this.ou = GameObject.Find("BlueOu");
        }


        if (true)//���肳��Ă��邩�ǂ��� !gm.nowOute
        {
            if (!Pocket)//�{�[�h��̋��I��
            {
                if (PlayerTurn == "red")
                {
                    if (komaName == "hu")
                    {
                        if (koma.nari)
                        {
                            for (int i = -1; i <= 1; i++)
                            {
                                if (MoveOuteCheck(Y - 1, X + i, ou) && komaPosition(Y - 1, X + i, gm, Player))
                                {
                                    komaPoint(Y - 1, X + i, gm, Player);
                                }
                            }
                            for (int i = -1; i <= 1; i += 2)
                            {
                                if (MoveOuteCheck(Y, X + i, ou) && komaPosition(Y, X + i, gm, Player))
                                {
                                    komaPoint(Y, X + i, gm, Player);
                                }
                            }
                            if (MoveOuteCheck(Y + 1, X, ou) && komaPosition(Y + 1, X, gm, Player))
                            {
                                komaPoint(Y + 1, X, gm, Player);
                            }
                        }
                        else
                        {
                            if (MoveOuteCheck(Y - 1,X,ou) && komaPosition(Y - 1, X, gm, Player))
                            {
                                komaPoint(Y - 1, X, gm, Player);
                            }
                        }

                    }
                    else if (komaName == "yari")
                    {
                        if (koma.nari)
                        {
                            for (int i = -1; i <= 1; i++)
                            {
                                if (MoveOuteCheck(Y - 1, X + i, ou) && komaPosition(Y - 1, X + i, gm, Player))
                                {
                                    komaPoint(Y - 1, X + i, gm, Player);
                                }
                            }
                            for (int i = -1; i <= 1; i += 2)
                            {
                                if (MoveOuteCheck(Y, X + i, ou) && komaPosition(Y, X + i, gm, Player))
                                {
                                    komaPoint(Y, X + i, gm, Player);
                                }
                            }
                            if (MoveOuteCheck(Y + 1, X, ou) && komaPosition(Y + 1, X, gm, Player))
                            {
                                komaPoint(Y + 1, X, gm, Player);
                            }
                        }
                        else
                        {
                            int ue = MovePointCount(Y, X, 1);
                            for (int i = Y - 1; i >= ue; i--)
                            {
                                if (MoveOuteCheck(i, X, ou) && komaPosition(i, X, gm, Player))
                                {
                                    komaPoint(i, X, gm, Player);
                                }

                            }
                        }

                    }
                    else if (komaName == "uma")
                    {
                        if (koma.nari)
                        {
                            for (int i = -1; i <= 1; i++)
                            {
                                if (MoveOuteCheck(Y - 1, X + i, ou) && komaPosition(Y - 1, X + i, gm, Player))
                                {
                                    komaPoint(Y - 1, X + i, gm, Player);
                                }
                            }
                            for (int i = -1; i <= 1; i += 2)
                            {
                                if (MoveOuteCheck(Y, X + i, ou) && komaPosition(Y, X + i, gm, Player))
                                {
                                    komaPoint(Y, X + i, gm, Player);
                                }
                            }
                            if (MoveOuteCheck(Y + 1, X, ou) && komaPosition(Y + 1, X, gm, Player))
                            {
                                komaPoint(Y + 1, X, gm, Player);
                            }
                        }
                        else
                        {
                            for (int i = -1; i <= 1; i += 2)
                            {
                                if (MoveOuteCheck(Y - 2,X +i,ou) && komaPosition(Y - 2, X + i, gm, Player))
                                {
                                    komaPoint(Y - 2, X + i, gm, Player);
                                }
                            }
                        }

                    }
                    else if (komaName == "gin")
                    {
                        if (koma.nari)
                        {
                            for (int i = -1; i <= 1; i++)
                            {
                                if (MoveOuteCheck(Y - 1, X + i, ou) && komaPosition(Y - 1, X + i, gm, Player))
                                {
                                    komaPoint(Y - 1, X + i, gm, Player);
                                }
                            }
                            for (int i = -1; i <= 1; i += 2)
                            {
                                if (MoveOuteCheck(Y, X + i, ou) && komaPosition(Y, X + i, gm, Player))
                                {
                                    komaPoint(Y, X + i, gm, Player);
                                }
                            }
                            if (MoveOuteCheck(Y + 1, X, ou) && komaPosition(Y + 1, X, gm, Player))
                            {
                                komaPoint(Y + 1, X, gm, Player);
                            }
                        }
                        else
                        {
                            for (int i = -1; i <= 1; i += 2)
                            {
                                if (MoveOuteCheck(Y - 1,X + i ,ou) && komaPosition(Y - 1, X + i, gm, Player))
                                {
                                    komaPoint(Y - 1, X + i, gm, Player);
                                }
                                if (MoveOuteCheck(Y + 1,X +i ,ou) && komaPosition(Y + 1, X + i, gm, Player))
                                {
                                    komaPoint(Y + 1, X + i, gm, Player);
                                }
                            }
                            if (MoveOuteCheck(Y - 1,X,ou) && komaPosition(Y - 1, X, gm, Player))
                            {
                                komaPoint(Y - 1, X, gm, Player);
                            }
                        }

                    }
                    else if (komaName == "kin")
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            if (MoveOuteCheck(Y -1,X +i,ou) && komaPosition(Y - 1, X + i, gm, Player))
                            {
                                komaPoint(Y - 1, X + i, gm, Player);
                            }
                        }
                        for (int i = -1; i <= 1; i += 2)
                        {
                            if (MoveOuteCheck(Y,X + i,ou) && komaPosition(Y, X + i, gm, Player))
                            {
                                komaPoint(Y, X + i, gm, Player);
                            }
                        }
                        if (MoveOuteCheck(Y + 1,X,ou) && komaPosition(Y + 1, X, gm, Player))
                        {
                            komaPoint(Y + 1, X, gm, Player);
                        }
                    }
                    else if (komaName == "kaku")
                    {
                        if (koma.nari)
                        {
                            for (int i = -1; i <= 1; i += 2)
                            {
                                if (MoveOuteCheck(Y + i,X,ou) && komaPosition(Y + i, X, gm, Player))
                                {
                                    komaPoint(Y + i, X, gm, Player);
                                }

                            }
                            for (int j = -1; j <= 1; j += 2)
                            {
                                if (MoveOuteCheck(Y,X +j,ou) && komaPosition(Y, X + j, gm, Player))
                                {
                                    komaPoint(Y, X + j, gm, Player);
                                }

                            }
                            for (int i = Y - 1, j = X - 1; i >= 0 && j >= 0 && MoveOuteCheck(i,j,ou) && komaPosition(i, j, gm, Player); i--, j--)
                            {
                                komaPoint(i, j, gm, Player);
                            }
                            for (int i = Y - 1, j = X + 1; i >= 0 && j < 9 && MoveOuteCheck(i,j,ou) && komaPosition(i, j, gm, Player); i--, j++)
                            {
                                komaPoint(i, j, gm, Player);
                            }
                            for (int i = Y + 1, j = X - 1; i < 9 && j >= 0 && MoveOuteCheck(i,j,ou) && komaPosition(i, j, gm, Player); i++, j--)
                            {
                                komaPoint(i, j, gm, Player);
                            }
                            for (int i = Y + 1, j = X + 1; i < 9 && j < 9 && MoveOuteCheck(i,j,ou) && komaPosition(i, j, gm, Player); i++, j++)
                            {
                                komaPoint(i, j, gm, Player);
                            }
                        }
                        else
                        {
                            for (int i = Y - 1, j = X - 1; i >= 0 && j >= 0 && MoveOuteCheck(i,j,ou) && komaPosition(i, j, gm, Player); i--, j--)
                            {
                                komaPoint(i, j, gm, Player);
                            }
                            for (int i = Y - 1, j = X + 1; i >= 0 && j < 9 && MoveOuteCheck(i,j,ou) && komaPosition(i, j, gm, Player); i--, j++)
                            {
                                komaPoint(i, j, gm, Player);
                            }
                            for (int i = Y + 1, j = X - 1; i < 9 && j >= 0 && MoveOuteCheck(i,j,ou) && komaPosition(i, j, gm, Player); i++, j--)
                            {
                                komaPoint(i, j, gm, Player);
                            }
                            for (int i = Y + 1, j = X + 1; i < 9 && j < 9 && MoveOuteCheck(i,j,ou) && komaPosition(i, j, gm, Player); i++, j++)
                            {
                                komaPoint(i, j, gm, Player);
                            }
                        }

                    }
                    else if (komaName == "hisha")
                    {
                        if (koma.nari)
                        {
                            for (int i = -1, j = -1; i <= 1; i += 2)
                            {
                                if (MoveOuteCheck(Y + i,X + j,ou) && komaPosition(Y + i, X + j, gm, Player))
                                {
                                    komaPoint(Y + i, X + j, gm, Player);
                                }

                            }
                            for (int i = -1, j = +1; i <= 1; i += 2)
                            {
                                if (MoveOuteCheck(Y + i,X + j,ou) && komaPosition(Y + i, X + j, gm, Player))
                                {
                                    komaPoint(Y + i, X + j, gm, Player);
                                }

                            }
                            int sita = MovePointCount(Y, X, 3);
                            for (int i = Y + 1; i <= sita; i++)
                            {
                                if (MoveOuteCheck(i, X, ou) && komaPosition(i, X, gm, Player))
                                {
                                    komaPoint(i, X, gm, Player);
                                }

                            }
                            int ue = MovePointCount(Y, X, 1);
                            for (int i = Y - 1; i >= ue; i--)
                            {
                                if (MoveOuteCheck(i, X, ou) && komaPosition(i, X, gm, Player))
                                {
                                    komaPoint(i, X, gm, Player);
                                }

                            }
                            int migi = MovePointCount(Y, X, 2);
                            for (int j = X + 1; j <= migi; j++)
                            {
                                if (MoveOuteCheck(Y, j, ou) && komaPosition(Y, j, gm, Player))
                                {
                                    komaPoint(Y, j, gm, Player);
                                }

                            }
                            int hidari = MovePointCount(Y, X, 4);
                            for (int j = X - 1; j >= hidari; j--)
                            {
                                if (MoveOuteCheck(Y, j, ou) && komaPosition(Y, j, gm, Player))
                                {
                                    komaPoint(Y, j, gm, Player);
                                }

                            }
                        }
                        else
                        {
                            int sita = MovePointCount(Y, X, 3);
                            for (int i = Y + 1; i <= sita; i++)
                            {
                                if (MoveOuteCheck(i, X, ou) && komaPosition(i, X, gm, Player))
                                {
                                    komaPoint(i, X, gm, Player);
                                }

                            }
                            int ue = MovePointCount(Y, X, 1);
                            for (int i = Y - 1; i >= ue; i--)
                            {
                                if (MoveOuteCheck(i, X, ou) && komaPosition(i, X, gm, Player))
                                {
                                    komaPoint(i, X, gm, Player);
                                }

                            }
                            int migi = MovePointCount(Y, X, 2);
                            for (int j = X + 1; j <= migi; j++)
                            {
                                if (MoveOuteCheck(Y, j, ou) && komaPosition(Y, j, gm, Player))
                                {
                                    komaPoint(Y, j, gm, Player);
                                }

                            }
                            int hidari = MovePointCount(Y, X, 4);
                            for (int j = X - 1; j >= hidari; j--)
                            {
                                if (MoveOuteCheck(Y, j, ou) && komaPosition(Y, j, gm, Player))
                                {
                                    komaPoint(Y, j, gm, Player);
                                }

                            }
                        }

                    }
                    else if (komaName == "ou")
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            if (MoveOuteCheck(Y - 1, X + i,ou) && komaPosition(Y - 1, X + i, gm, Player))
                            {
                                komaPoint(Y - 1, X + i, gm, Player);
                            }
                            if (MoveOuteCheck(Y + 1,X + i,ou) && komaPosition(Y + 1, X + i, gm, Player))
                            {
                                komaPoint(Y + 1, X + i, gm, Player);
                            }
                        }
                        for (int i = -1; i <= 1; i += 2)
                        {
                            if (MoveOuteCheck(Y ,X + i,ou) && komaPosition(Y, X + i, gm, Player))
                            {
                                komaPoint(Y, X + i, gm, Player);
                            }          
                        }

                    }
                }






                else//����^�[��
                {
                    if (komaName == "hu")
                    {
                        if (koma.nari)
                        {
                            for (int i = -1; i <= 1; i++)
                            {
                                if (MoveOuteCheck(Y + 1, X + i, ou) && komaPosition(Y + 1, X + i, gm, Player))
                                {
                                    komaPoint(Y + 1, X + i, gm, Player);
                                }
                            }
                            for (int i = -1; i <= 1; i += 2)
                            {
                                if (MoveOuteCheck(Y, X + i, ou) && komaPosition(Y, X + i, gm, Player))
                                {
                                    komaPoint(Y, X + i, gm, Player);
                                }
                            }
                            if (MoveOuteCheck(Y - 1, X, ou) && komaPosition(Y - 1, X, gm, Player))
                            {
                                komaPoint(Y - 1, X, gm, Player);
                            }
                        }
                        else
                        {
                            if (MoveOuteCheck(Y + 1,X,ou) && komaPosition(Y + 1, X, gm, Player))
                            {
                                komaPoint(Y + 1, X, gm, Player);
                            }
                        }

                    }
                    else if (komaName == "yari")
                    {
                        if (koma.nari)
                        {
                            for (int i = -1; i <= 1; i++)
                            {
                                if (MoveOuteCheck(Y + 1, X + i, ou) && komaPosition(Y + 1, X + i, gm, Player))
                                {
                                    komaPoint(Y + 1, X + i, gm, Player);
                                }
                            }
                            for (int i = -1; i <= 1; i += 2)
                            {
                                if (MoveOuteCheck(Y, X + i, ou) && komaPosition(Y, X + i, gm, Player))
                                {
                                    komaPoint(Y, X + i, gm, Player);
                                }
                            }
                            if (MoveOuteCheck(Y - 1, X, ou) && komaPosition(Y - 1, X, gm, Player))
                            {
                                komaPoint(Y - 1, X, gm, Player);
                            }
                        }
                        else
                        {
                            int sita = MovePointCount(Y, X, 3);
                            for (int i = Y + 1; i <= sita; i++)
                            {
                                if (MoveOuteCheck(i, X, ou) && komaPosition(i, X, gm, Player))
                                {
                                    komaPoint(i, X, gm, Player);
                                }

                            }
                        }

                    }
                    else if (komaName == "uma")
                    {
                        if (koma.nari)
                        {
                            for (int i = -1; i <= 1; i++)
                            {
                                if (MoveOuteCheck(Y + 1, X + i, ou) && komaPosition(Y + 1, X + i, gm, Player))
                                {
                                    komaPoint(Y + 1, X + i, gm, Player);
                                }
                            }
                            for (int i = -1; i <= 1; i += 2)
                            {
                                if (MoveOuteCheck(Y, X + i, ou) && komaPosition(Y, X + i, gm, Player))
                                {
                                    komaPoint(Y, X + i, gm, Player);
                                }
                            }
                            if (MoveOuteCheck(Y - 1, X, ou) && komaPosition(Y - 1, X, gm, Player))
                            {
                                komaPoint(Y - 1, X, gm, Player);
                            }
                        }
                        else
                        {
                            for (int i = -1; i <= 1; i += 2)
                            {
                                if (MoveOuteCheck(Y + 2,X + i,ou) && komaPosition(Y + 2, X + i, gm, Player))
                                {
                                    komaPoint(Y + 2, X + i, gm, Player);
                                }

                            }
                        }

                    }
                    else if (komaName == "gin")
                    {
                        if (koma.nari)
                        {
                            for (int i = -1; i <= 1; i++)
                            {
                                if (MoveOuteCheck(Y + 1, X + i,ou) && komaPosition(Y + 1, X + i, gm, Player))
                                {
                                    komaPoint(Y + 1, X + i, gm, Player);
                                }
                            }
                            for (int i = -1; i <= 1; i += 2)
                            {
                                if (MoveOuteCheck(Y, X + i,ou) && komaPosition(Y, X + i, gm, Player))
                                {
                                    komaPoint(Y, X + i, gm, Player);
                                }
                            }
                            if (MoveOuteCheck(Y - 1,X,ou) && komaPosition(Y - 1, X, gm, Player))
                            {
                                komaPoint(Y - 1, X, gm, Player);
                            }
                        }
                        else
                        {
                            for (int i = -1; i <= 1; i += 2)
                            {
                                if (MoveOuteCheck(Y - 1,X + i,ou) && komaPosition(Y - 1, X + i, gm, Player))
                                {
                                    komaPoint(Y - 1, X + i, gm, Player);
                                }
                                if (MoveOuteCheck(Y + 1,X + i,ou) && komaPosition(Y + 1, X + i, gm, Player))
                                {
                                    komaPoint(Y + 1, X + i, gm, Player);
                                }
                            }
                            if (MoveOuteCheck(Y + 1,X,ou) && komaPosition(Y + 1, X, gm, Player))
                            {
                                komaPoint(Y + 1, X, gm, Player);
                            }
                        }

                    }
                    else if (komaName == "kin")
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            if (MoveOuteCheck(Y + 1,X + i,ou) && komaPosition(Y + 1, X + i, gm, Player))
                            {
                                komaPoint(Y + 1, X + i, gm, Player);
                            }
                        }
                        for (int i = -1; i <= 1; i += 2)
                        {
                            if (MoveOuteCheck(Y,X+i,ou) && komaPosition(Y, X + i, gm, Player))
                            {
                                komaPoint(Y, X + i, gm, Player);
                            }
                        }
                        if (MoveOuteCheck(Y - 1,X,ou) && komaPosition(Y - 1, X, gm, Player))
                        {
                            komaPoint(Y - 1, X, gm, Player);
                        }
                    }
                    else if (komaName == "kaku")
                    {
                        if (koma.nari)
                        {
                            for (int i = -1; i <= 1; i += 2)
                            {
                                if (MoveOuteCheck(Y + i,X,ou) && komaPosition(Y + i, X, gm, Player))
                                {
                                    komaPoint(Y + i, X, gm, Player);
                                }
                            }
                            for (int j = -1; j <= 1; j += 2)
                            {
                                if (MoveOuteCheck(Y,X + j,ou) && komaPosition(Y, X + j, gm, Player))
                                {
                                    komaPoint(Y, X + j, gm, Player);
                                }

                            }
                            for (int i = Y - 1, j = X - 1; i >= 0 && j >= 0 && MoveOuteCheck(i, j, ou) && komaPosition(i, j, gm, Player); i--, j--)
                            {
                                komaPoint(i, j, gm, Player);
                            }
                            for (int i = Y - 1, j = X + 1; i >= 0 && j < 9 && MoveOuteCheck(i, j, ou) && komaPosition(i, j, gm, Player); i--, j++)
                            {
                                komaPoint(i, j, gm, Player);
                            }
                            for (int i = Y + 1, j = X - 1; i < 9 && j >= 0 && MoveOuteCheck(i, j, ou) && komaPosition(i, j, gm, Player); i++, j--)
                            {
                                komaPoint(i, j, gm, Player);
                            }
                            for (int i = Y + 1, j = X + 1; i < 9 && j < 9 && MoveOuteCheck(i, j, ou) && komaPosition(i, j, gm, Player); i++, j++)
                            {
                                komaPoint(i, j, gm, Player);
                            }
                        }
                        else
                        {
                            (int y1,int x1) = MovePointCount2(Y, X, 1);//�E��
                            (int y2, int x2) = MovePointCount2(Y, X, 2);//�E��
                            (int y3, int x3) = MovePointCount2(Y, X, 3);//����
                            (int y4, int x4) = MovePointCount2(Y, X, 4);//����
                            for (int i = Y - 1, j = X - 1; i >= y4 && j >= x4 ; i--, j--)
                            {
                                if (MoveOuteCheck(i, j, ou) && komaPosition(i, j, gm, Player))
                                {
                                    komaPoint(i, j, gm, Player);
                                }
                                
                            }
                            for (int i = Y - 1, j = X + 1; i >= y1 && j <= x1; i--, j++)
                            {
                                if (MoveOuteCheck(i, j, ou) && komaPosition(i, j, gm, Player))
                                {
                                    komaPoint(i, j, gm, Player);
                                }
                                
                            }
                            for (int i = Y + 1, j = X - 1; i <= y3 && j >= x3; i++, j--)
                            {
                                if (MoveOuteCheck(i, j, ou) && komaPosition(i, j, gm, Player))
                                {
                                    komaPoint(i, j, gm, Player);
                                }                
                            }
                            for (int i = Y + 1, j = X + 1; i <= y2 && j <= x2; i++, j++)
                            {
                                if (MoveOuteCheck(i, j, ou) && komaPosition(i, j, gm, Player))
                                {
                                    komaPoint(i, j, gm, Player);
                                }
                                
                            }
                        }

                    }
                    else if (komaName == "hisha")
                    {
                        if (koma.nari)
                        {
                            for (int i = -1, j = -1; i <= 1; i += 2)
                            {
                                if (MoveOuteCheck(Y + i, X + j, ou) && komaPosition(Y + i, X + j, gm, Player))
                                {
                                    komaPoint(Y + i, X + j, gm, Player);
                                }

                            }
                            for (int i = -1, j = 1; i <= 1; i += 2)
                            {
                                if (MoveOuteCheck(Y + i,X + j,ou) && komaPosition(Y + i, X + j, gm, Player))
                                {
                                    komaPoint(Y + i, X + j, gm, Player);
                                }

                            }
                            int sita = MovePointCount(Y, X, 3);
                            for (int i = Y + 1; i <= sita; i++)
                            {
                                if (MoveOuteCheck(i, X, ou) && komaPosition(i, X, gm, Player))
                                {
                                    komaPoint(i, X, gm, Player);
                                }

                            }
                            int ue = MovePointCount(Y, X, 1);
                            for (int i = Y - 1; i >= ue; i--)
                            {
                                if (MoveOuteCheck(i, X, ou) && komaPosition(i, X, gm, Player))
                                {
                                    komaPoint(i, X, gm, Player);
                                }

                            }
                            int migi = MovePointCount(Y, X, 2);
                            for (int j = X + 1; j <= migi; j++)
                            {
                                if (MoveOuteCheck(Y, j, ou) && komaPosition(Y, j, gm, Player))
                                {
                                    komaPoint(Y, j, gm, Player);
                                }

                            }
                            int hidari = MovePointCount(Y, X, 4);
                            for (int j = X - 1; j >= hidari; j--)
                            {
                                if (MoveOuteCheck(Y, j, ou) && komaPosition(Y, j, gm, Player))
                                {
                                    komaPoint(Y, j, gm, Player);
                                }

                            }
                        }
                        else
                        {
                            int sita = MovePointCount(Y,X,3);
                            for (int i = Y + 1; i <= sita; i++)
                            {
                                if (MoveOuteCheck(i, X, ou) && komaPosition(i, X, gm, Player))
                                {
                                    komaPoint(i, X, gm, Player);
                                }
                                
                            }
                            int ue = MovePointCount(Y, X, 1);
                            for (int i = Y - 1; i >= ue; i--)
                            {
                                if (MoveOuteCheck(i, X, ou) && komaPosition(i, X, gm, Player))
                                {
                                    komaPoint(i, X, gm, Player);
                                }
                                
                            }
                            int migi = MovePointCount(Y, X, 2);
                            for (int j = X + 1; j <= migi ; j++)
                            {
                                if (MoveOuteCheck(Y, j, ou) && komaPosition(Y, j, gm, Player))
                                {
                                    komaPoint(Y, j, gm, Player);
                                }
                                
                            }
                            int hidari = MovePointCount(Y, X, 4);
                            for (int j = X - 1; j >= hidari; j--)
                            {
                                if (MoveOuteCheck(Y, j, ou) && komaPosition(Y, j, gm, Player))
                                {
                                    komaPoint(Y, j, gm, Player);
                                }
                                
                            }
                        }

                    }
                    else if (komaName == "ou")
                    {
                        for (int i = -1; i <= 1; i++)
                        {
                            if (MoveOuteCheck(Y - 1,X + i,ou) && komaPosition(Y - 1, X + i, gm, Player))
                            {
                                komaPoint(Y - 1, X + i, gm, Player);
                            }
                            if (MoveOuteCheck(Y + 1,X + i,ou) && komaPosition(Y + 1, X + i, gm, Player))
                            {
                                komaPoint(Y + 1, X + i, gm, Player);
                            }
                        }
                        for (int i = -1; i <= 1; i += 2)
                        {
                            if (MoveOuteCheck(Y,X + i,ou) && komaPosition(Y, X + i, gm, Player))
                            {
                                komaPoint(Y, X + i, gm, Player);
                            }            
                        }

                    }
                }
            }
            else//�|�P�b�g�̋��I��
            {
                //koma.PocketFlg = false;//�|�P�b�g������
                komaPointPocket(gm, Player);//���ׂĂ�ON�ɂ���
            }

        }
        else
        {

        }


    }
    void komaPoint(int Y, int X, GameManager gm, string Player)
    {

        gm.boads[Y][X].GetComponent<Renderer>().material.color = Color.yellow;
        gm.boads[Y][X].GetComponent<BoardManager>().PaintSelect = true;
        //Debug.Log("���点��");
    }

    void komaPointPocket(GameManager gm, string Player)
    {
        bool flg;
        List<GameObject> bm = new List<GameObject> { };
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                flg = true;
                //��𒲂ׂ�
                for (int p = 0; p < gm.komas2.Count; p++)
                {         
                    //�|�P�b�g�͊܂߂Ȃ�
                    if (!gm.komas2[p].GetComponent<komaManager>().PocketFlg)
                    {
                        //���̋�̏�ɂ͂����Ȃ�
                        //gm.boads[i][j].GetComponent<BoardManager>().BoardY
                        if (i == gm.komas2[p].GetComponent<komaManager>().ListY)
                        {
                            if (j == gm.komas2[p].GetComponent<komaManager>().ListX)
                            {
                                if (flg)//��ł��d�Ȃ��Ă�����̂�����Ί܂߂Ȃ�
                                {
                                    flg = false;
                                }                  
                            }
                        }
                    }
                }
                if (flg)
                {
                    if (roleCheak(Player,gm, gm.boads[i][j]))//���[���`�F�b�N
                    {
                        koma.PocketFlg = false;//��x���̎�����̃t���O���O��
                        //����u���b�N
                        if ( MoveOuteCheck(i, j, ou))//Y,X
                        {
                            bm.Add(gm.boads[i][j]);
                        }
                        koma.PocketFlg = true;
                    }       
                }           
            }
        }
        foreach (var b in bm)
        {
            b.GetComponent<Renderer>().material.color = Color.yellow;
            b.GetComponent<BoardManager>().PaintSelect = true;
        }
        //gm.boads[i][j].GetComponent<Renderer>().material.color = Color.yellow;
    }

    bool komaPosition(int Y, int X, GameManager gm,string Player)
    {
        if (0 <= Y && Y < 9 && 0 <= X && X < 9)//�{�[�h��
        {
            for (int i = 0; i < gm.komas2.Count; i++)
            {
                //�����̋�̏�ɂ͒u���Ȃ�
                if (gm.komas2[i].GetComponent<komaManager>().ListX == X && gm.komas2[i].GetComponent<komaManager>().ListY == Y && gm.komas2[i].GetComponent<komaManager>().PocketFlg == false)
                {
                    if (gm.komas2[i].GetComponent<komaManager>().Player != Player)
                    {
                        gm.boads[Y][X].GetComponent<Renderer>().material.color = Color.yellow;
                        gm.boads[Y][X].GetComponent<BoardManager>().PaintSelect = true;
                        gm.komas2[i].GetComponent<komaManager>().PaintSelect = true;
                    }
                    return false;
                }
            }
            return true;
        }
        return false;

    }


    //BoardY,BoardX�ɒu���邩�ǂ���
    bool roleCheak(string Player, GameManager gm,GameObject go)
    {

        if (Player == "red")
        {
            if (komaName == "hu")
            {
                List<GameObject> huList = new List<GameObject> { };
                for (int i = 0; i < gm.komas2.Count; i++)
                {
                    if (gm.komas2[i].GetComponent<komaManager>().komaName == "hu" && gm.komas2[i].GetComponent<komaManager>().Player == Player && gm.komas2[i].GetComponent<komaManager>().PocketFlg == false)
                    {
                        huList.Add(gm.komas2[i]);
                    }
                }
                if (go.GetComponent<BoardManager>().BoardY != 0)
                {        
                    if (huList != null)
                    {
                        bool flg = true;
                        for (int i = 0; i < huList.Count;i++)
                        {                       
                            if (huList[i].GetComponent<komaManager>().ListX == go.GetComponent<BoardManager>().BoardX && huList[i].GetComponent<komaManager>().nari == false)
                            {
                                flg = false;
                            }               
                        }
                        return flg;
                    }

                }      
            }
            else if (komaName == "yari")
            {
                if (go.GetComponent<BoardManager>().BoardY != 0)
                {
                    return true;
                }
            }
            else if (komaName == "uma")
            {
                if (go.GetComponent<BoardManager>().BoardY > 1)
                {
                    return true;
                }
            }
            else//����ȊO�̋�͉����ɂ����Ă��悢
            {
                return true;
            }
            return false;
        }
        else
        {
            if (komaName == "hu")
            {
                List<GameObject> huList = new List<GameObject> { };
                for (int i = 0; i < gm.komas2.Count; i++)
                {
                    if (gm.komas2[i].GetComponent<komaManager>().komaName == "hu" && gm.komas2[i].GetComponent<komaManager>().Player == Player && gm.komas2[i].GetComponent<komaManager>().PocketFlg == false)
                    {
                        huList.Add(gm.komas2[i]);
                    }
                }
                if (go.GetComponent<BoardManager>().BoardY != 8)
                {
                    if (huList != null)
                    {
                        bool flg = true;
                        for (int i = 0; i < huList.Count; i++)
                        {

                            if (huList[i].GetComponent<komaManager>().ListX == go.GetComponent<BoardManager>().BoardX && huList[i].GetComponent<komaManager>().nari == false)
                            {
                                flg = false;
                            }                  
                        }
                        return flg;
                    }
                }
            }
            else if (komaName == "yari")
            {
                if (go.GetComponent<BoardManager>().BoardY != 8)
                {
                    return true;
                }
            }
            else if (komaName == "uma")
            {
                if (go.GetComponent<BoardManager>().BoardY < 7)
                {
                    return true;
                }
            }
            else//����ȊO�̋�͂ǂ��ɒu���Ă��悢
            {
                return true;
            }
            return false;
        }
    }

    bool MoveOuteCheck(int Y,int X,GameObject ou)//�G���Ă����̓��������Ƃ��Ă�����W�A�����̉��̏ꏊ
    {
        int beforeX = koma.GetComponent<komaManager>().ListX;
        int beforeY = koma.GetComponent<komaManager>().ListY;
        //���̋�����Ɉړ������Ă݂�
        koma.GetComponent<komaManager>().ListX = X;
        koma.GetComponent<komaManager>().ListY = Y;
        PlayerContrlloer.UpdateKoma(gm);

        foreach (var km in gm.komas2)
        {
            if (km.GetComponent<komaManager>().Player != PlayerTurn)//����̋�
            {
                //����̋�̃A�^�b�N���X�g���X�V km.GetComponent<komaManager>().komaName == "hisha" || km.GetComponent<komaManager>().komaName == "kaku" || km.GetComponent<komaManager>().komaName == "yari"
                if (true)
                {
                    bool flg = false;
                    if (km.GetComponent<komaManager>().ListX == X && km.GetComponent<komaManager>().ListY == Y)//������ɑ���̋�������瑊��̋�����
                    {
                        km.GetComponent<komaManager>().ListX = -1;
                        km.GetComponent<komaManager>().ListY = -1;
                        km.GetComponent<komaManager>().PocketFlg = true;
                        km.GetComponent<komaManager>().AttackList.Clear();
                        flg = true;
                        PlayerContrlloer.UpdateKoma(gm);
                    }
                    for (int j = 0; j < km.GetComponent<komaManager>().AttackList.Count; j++)
                    {
                        //�A�^�b�N���X�g�ɓ����Ă�����
                        if (ou.GetComponent<komaManager>().ListX == km.GetComponent<komaManager>().AttackList[j].X && ou.GetComponent<komaManager>().ListY == km.GetComponent<komaManager>().AttackList[j].Y)
                        {
                            //���̍��W�ɖ߂�
                            if (flg)
                            {
                                km.GetComponent<komaManager>().ListX = X;
                                km.GetComponent<komaManager>().ListY = Y;
                                km.GetComponent<komaManager>().PocketFlg = false;
                            }


                            koma.GetComponent<komaManager>().ListX = beforeX;
                            koma.GetComponent<komaManager>().ListY = beforeY;
                            PlayerContrlloer.UpdateKoma(gm);
                            return false;
                        }
                    }
                    if (flg)
                    {
                        km.GetComponent<komaManager>().ListX = X;
                        km.GetComponent<komaManager>().ListY = Y;
                        km.GetComponent<komaManager>().PocketFlg = false;
                        PlayerContrlloer.UpdateKoma(gm);
                        flg = false;
                    }
                }
            }
        }

        //���̍��W�ɖ߂�
        koma.GetComponent<komaManager>().ListX = beforeX;
        koma.GetComponent<komaManager>().ListY = beforeY;

        PlayerContrlloer.UpdateKoma(gm);
        return true;
    }

    int MovePointCount(int Y, int X,int arrow)
    {
        int point = 0;
        if (arrow == 1)//��
        {
            for (int y = Y - 1; y >= 0; y--)//���Y�����炵�Ă���
            {
                for (int i = 0; i < gm.komas2.Count; i++)
                {
                    if (gm.komas2[i].GetComponent<komaManager>().ListY == y && gm.komas2[i].GetComponent<komaManager>().ListX == X)
                    {
                        point = y;
                        break;
                    }
                }
                if (point != 0)
                {
                    break;
                }
            }
        }
        if (arrow == 2)//�E
        {
            for (int x = X + 1; x < 9; x++)//�E��X�𑝂₵�Ă���
            {
                for (int i = 0; i < gm.komas2.Count; i++)
                {
                    if (gm.komas2[i].GetComponent<komaManager>().ListY == Y && gm.komas2[i].GetComponent<komaManager>().ListX == x)
                    {
                        point = x;
                        break;
                    }
                }
                if (point != 0)
                {
                    break;
                }
            }
            if (point == 0)
            {
                point = 8;
            }
        }
        if (arrow == 3)//��
        {
            for (int y = Y + 1; y < 9; y++)//����Y�𑝂₵�Ă���
            {
                for (int i = 0; i < gm.komas2.Count; i++)
                {
                    if (gm.komas2[i].GetComponent<komaManager>().ListY == y && gm.komas2[i].GetComponent<komaManager>().ListX == X)
                    {
                        point = y;
                        break;
                    }
                }
                if (point != 0)
                {
                    break;
                }
            }
            if (point == 0)
            {
                point = 8;
            }

        }
        if (arrow == 4)//��
        {
            for (int x = X - 1; x >= 0; x--)//����X�����炵�Ă���
            {
                for (int i = 0; i < gm.komas2.Count; i++)
                {
                    if (gm.komas2[i].GetComponent<komaManager>().ListY == Y && gm.komas2[i].GetComponent<komaManager>().ListX == x)
                    {
                        point = x;
                        break;
                    }
                }
                if (point != 0)
                {
                    break;
                }
            }

        }

        return point;
    }

    (int y,int x ) MovePointCount2(int Y, int X, int arrow)
    {
        int pointY = 0;
        int pointX = 0;
        if (arrow == 1)//��
        {
            for (int y = Y - 1,x = X + 1; y >= 0&& x < 9; y--, x++)//�E���Y�����炵�Ă���
            {
                for (int i = 0; i < gm.komas2.Count; i++)
                {
                    if (gm.komas2[i].GetComponent<komaManager>().ListY == y && gm.komas2[i].GetComponent<komaManager>().ListX == x)
                    {
                        pointY = y;
                        pointX = x;
                        break;
                    }
                }
                if (pointY != 0 && pointX != 0)
                {
                    break;
                }
            }
            if (pointX == 0)
            {
                pointX = 8;
            }
        }
        if (arrow == 2)//�E
        {
            for (int x = X + 1, y = Y + 1; y < 9 && x < 9; y++, x++)//�E����X�𑝂₵�Ă���
            {
                for (int i = 0; i < gm.komas2.Count; i++)
                {
                    if (gm.komas2[i].GetComponent<komaManager>().ListY == y && gm.komas2[i].GetComponent<komaManager>().ListX == x)
                    {
                        pointY = Y;
                        pointX = x;
                        break;
                    }

                }
                if (pointY != 0 && pointX != 0)
                {
                    break;
                }
            }
            if (pointX == 0 && pointY == 0)
            {
                pointX = 8;
                pointY = 8;
            }
        }
        if (arrow == 3)//��
        {
            for (int y = Y + 1, x = X - 1; y < 9 && x >= 0; y++, x--)//������Y�𑝂₵�Ă���
            {
                for (int i = 0; i < gm.komas2.Count; i++)
                {
                    if (gm.komas2[i].GetComponent<komaManager>().ListY == y && gm.komas2[i].GetComponent<komaManager>().ListX == x)
                    {
                        pointY = y;
                        pointX = x;
                        break;
                    }
                }
                if (pointY != 0 && pointX != 0)
                {
                    break;
                }
            }
            if (pointY == 0)
            {
                pointY = 8;
            }
        }
        if (arrow == 4)//��
        {
            for (int y = Y - 1,x = X - 1; y >= 0 && x >= 0;y--, x--)//�����X�����炵�Ă���
            {
                for (int i = 0; i < gm.komas2.Count; i++)
                {
                    if (gm.komas2[i].GetComponent<komaManager>().ListY == y && gm.komas2[i].GetComponent<komaManager>().ListX == x)
                    {
                        pointY = y;
                        pointX = x;
                        break;
                    }
                }
                if (pointY != 0 && pointX != 0)
                {
                    break;
                }
            }
        }

        return (pointY,pointX);
    }

}
