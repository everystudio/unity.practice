using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 次のクラスのうち、
 * メンバー変数はいくつあるでしょう？
 * */
public class Practice01 : MonoBehaviour
{

}

public class Practice01_1 : MonoBehaviour
{
    public int m_iAttack;
    int m_iDefence;
    void Start()
    {
    }

    protected int m_iHp;
    void Update()
    {
    }
    int m_iMp;
}

public class Practice01_2 : MonoBehaviour
{
    public int m_iAttack;
    void Start()
    {
        int m_iDefence;
    }

    protected int m_iHp;
    void Update()
    {
        int m_iMp;
    }
    int m_iTp;
}




