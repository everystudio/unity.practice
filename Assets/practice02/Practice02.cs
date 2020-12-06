using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice02 : MonoBehaviour
{
	private int m_iHP;

	public int Damage( int _iAttack)
	{
		m_iHP -= _iAttack;
		if( m_iHP < 0)
		{
			m_iHP = 0;
		}
		return m_iHP;
	}
}


