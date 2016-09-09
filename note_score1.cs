using UnityEngine;
using System.Collections;

public class note_score : MonoBehaviour {

    public GameObject SH_note;
    public GameObject L_note;
    public GameObject SL_note_L;
    public GameObject SL_note_R;
    public GameObject SL_note_U;
    public GameObject SL_note_D;
    float t = (float)5 / 202;//1t당 202비피엠에서 48비트(12*t당 사분의 일 박자) 

    Vector3 temp;

	void Start () {         // 처음 숫자 1:단노트 / 2:슬라이드L / 3: 슬라이드R / 4: 슬라이드U / 5:슬라이드D
        respawn(1, 2, 48*t);//1
        respawn(1, 8, 51*t);
        respawn(1, 2, 54*t);
        respawn(1, 8, 57*t);
        respawn(1, 2, 60*t);
        respawn(1, 8, 63*t);
        respawn(1, 2, 66*t);
        respawn(1, 8, 69*t);
        respawn(1, 2, 72*t);
        respawn(1, 8, 75*t);
        respawn(1, 2, 78*t);
        respawn(1, 8, 81*t);
        respawn(1, 2, 84*t);
        respawn(1, 8, 87*t);
        respawn(1, 2, 90*t);
        respawn(1, 8, 93*t);
        respawn(1, 4, 96*t);//2
        respawn(1, 6, 99*t);
        respawn(1, 4, 102*t);
        respawn(1, 6, 105*t);
        respawn(1, 4, 108*t);
        respawn(1, 6, 111*t);
        respawn(1, 4, 114*t);
        respawn(1, 6, 117*t);
        respawn(1, 4, 120*t);
        respawn(1, 6, 123*t);
        respawn(1, 4, 126*t);
        respawn(1, 6, 129*t);
        respawn(1, 4, 132*t);
        respawn(1, 6, 135*t);
        respawn(1, 4, 138*t);
        respawn(1, 6, 141*t);
        respawn(3, 4, (144) * t);//3
        respawn(2, 6, (144 + 24) * t);
        respawn(3, 4, (144 + 48) * t);//4
        respawn(3, 4, (144 + 78) * t);
        respawn(2, 6, (144 + 96) * t);//5
        respawn(3, 4, (144 + 138) * t);
        respawn(2, 6, (144 + 144) * t);//6
        respawn(2, 6, (144 + 174) * t);
        respawn(3, 4, (336) * t);//7
        respawn(2, 6, (336 + 24) * t);
        respawn(3, 4, (336 + 48) * t);//8
        respawn(3, 4, (336 + 78) * t);
        respawn(2, 6, (336 + 96) * t);//9
        respawn(3, 4, (336 + 138) * t);
        respawn(2, 6, (336 + 144) * t);//10
        respawn(2, 6, (336 + 174) * t);
        respawn(3, 4, (528) * t);//11
        respawn(2, 6, (528 + 24) * t);
        respawn(3, 4, (528 + 48) * t);//12
        respawn(3, 4, (528 + 78) * t);
        respawn(2, 6, (528 + 96) * t);//13
        respawn(3, 4, (528 + 138) * t);
        respawn(2, 6, (528 + 144) * t);//14
        respawn(2, 6, (528 + 174) * t);
        respawn(3, 4, (720) * t);//15
        respawn(2, 6, (720 + 24) * t);
        respawn(3, 4, (720 + 48) * t);//16
        respawn(3, 4, (720 + 78) * t);
        respawn(2, 6, (720 + 96) * t);//17
        respawn(3, 4, (720 + 138) * t);
        respawn(2, 6, (720 + 144) * t);//18
        respawn(2, 6, (720 + 174) * t);
        respawn(3, 4, 48*19* t);//19
        respawn(1, 3, (48 *20)* t);//20
        respawn(1, 7, (48 * 20) * t);
        respawn(1, 3, (48 * 20+4) * t);
        respawn(1, 7, (48 * 20+4) * t);
        respawn(1, 3, (48 * 20 + 8) * t);
        respawn(1, 7, (48 * 20 + 8) * t);
        respawn(1, 3, (48 * 20 + 12) * t);
        respawn(1, 7, (48 * 20 + 12) * t);
        respawn(1, 3, (48 * 20 + 16) * t);
        respawn(1, 7, (48 * 20 + 16) * t);
        respawn(1, 3, (48 * 20 + 20) * t);
        respawn(1, 7, (48 * 20 + 20) * t);
        respawn(1, 2, (48 * 20 + 24) * t);
        respawn(1, 8, (48 * 20 + 24) * t);
        respawn(1, 2, (48 * 20 + 28) * t);
        respawn(1, 8, (48 * 20 + 28) * t);
        respawn(1, 2, (48 * 20 + 32) * t);
        respawn(1, 8, (48 * 20 + 32) * t);
        respawn(1, 2, (48 * 20 + 36) * t);
        respawn(1, 8, (48 * 20 + 36) * t);
        respawn(1, 2, (48 * 20 + 40) * t);
        respawn(1, 8, (48 * 20 + 40) * t);
        respawn(1, 2, (48 * 20 + 44) * t);
        respawn(1, 8, (48 * 20 + 44) * t);
        respawn(4, 5, (48 * 21) * t);//21
        respawn(4, 5, (48 * 21+18) * t);
        respawn(4, 5, (48 * 21+36) * t);
        respawn(4, 5, (48 * 22+6) * t);//22
        respawn(4, 5, (48 * 22+24) * t);
        respawn(2, 3, (48 * 23) * t);//23
        respawn(2, 3, (48 * 23 + 18) * t);
        respawn(2, 3, (48 * 23 + 36) * t);
        respawn(2, 3, (48 * 24 + 6) * t);//24
        respawn(2, 3, (48 * 24 + 24) * t);
        respawn(3, 7, (48 * 25) * t);//25
        respawn(3, 7, (48 * 25 + 18) * t);
        respawn(3, 7, (48 * 25 + 36) * t);
        respawn(3, 7, (48 * 26 + 6) * t);//26
        respawn(3, 7, (48 * 26 + 24) * t);
        respawn(1, 4, (48 * 27) * t);//27 동치 중 왼쪽
        respawn(1, 4, (48 * 27 + 18) * t);
        respawn(1, 4, (48 * 27 + 36) * t);
        respawn(1, 4, (48 * 28 + 6) * t);//28 동치 중 왼쪽
        respawn(1, 4, (48 * 28 + 24) * t);
        respawn(1, 6, (48 * 27) * t);//27 동치 중 오른쪽
        respawn(1, 6, (48 * 27 + 18) * t);
        respawn(1, 6, (48 * 27 + 36) * t);
        respawn(1, 6, (48 * 28 + 6) * t);//28 동치 중 오른쪽
        respawn(1, 6, (48 * 28 + 24) * t);
        respawn(1, 4, (48 * 28 + 30) * t);
        respawn(2, 8, (48 * 28 + 36) * t);//28
        respawn(2, 4, (48 * 28 + 42) * t);
        respawn(1, 2, 1392 * t);//29
        respawn(3, 4, 1392 * t);
        respawn(1, 4, 1440 * t);
        respawn(3, 6, 1440 * t);
        respawn(1, 8, 1488 * t);
        respawn(2, 6, 1488 * t);
        respawn(1, 6, 1536 * t);
        respawn(2, 4, 1536 * t);
        respawn(4, 6, 1584 * t);
        respawn(2, 4, 1590 * t);
        respawn(3, 6, 1632 * t);
        respawn(4, 4, 1638 * t);
        respawn(1, 8, 1680 * t);
        respawn(1, 4, 1683 * t);
        respawn(1, 6, 1686 * t);
        respawn(1, 2, 1689 * t);
        respawn(1, 8, 1728 * t);
        respawn(1, 2, 1731 * t);
        respawn(1, 6, 1734 * t);
        respawn(1, 4, 1737 * t);
        respawn(1, 2, 1404 * t);
        respawn(3, 4, 1404 * t);
        respawn(1, 4, 1452 * t);
        respawn(3, 6, 1452 * t);
        respawn(1, 8, 1500 * t);
        respawn(2, 6, 1500 * t);
        respawn(1, 6, 1548 * t);
        respawn(2, 4, 1548 * t);
        respawn(4, 6, 1596 * t);
        respawn(2, 4, 1602 * t);
        respawn(3, 6, 1644 * t);
        respawn(4, 4, 1650 * t);
        respawn(1, 8, 1692 * t);
        respawn(1, 4, 1695 * t);
        respawn(1, 6, 1698 * t);
        respawn(1, 2, 1701 * t);
        respawn(1, 8, 1740 * t);
        respawn(1, 2, 1743 * t);
        respawn(1, 6, 1746 * t);
        respawn(1, 4, 1749 * t);
        respawn(1, 2, 1416 * t);
        respawn(3, 4, 1416 * t);
        respawn(1, 4, 1464 * t);
        respawn(3, 6, 1464 * t);
        respawn(1, 8, 1512 * t);
        respawn(2, 6, 1512 * t);
        respawn(1, 6, 1560 * t);
        respawn(2, 4, 1560 * t);
        respawn(4, 6, 1608 * t);
        respawn(2, 4, 1614 * t);
        respawn(3, 6, 1656 * t);
        respawn(4, 4, 1662 * t);
        respawn(1, 8, 1704 * t);
        respawn(1, 4, 1707 * t);
        respawn(1, 6, 1710 * t);
        respawn(1, 2, 1713 * t);
        respawn(1, 8, 1752 * t);
        respawn(1, 2, 1755 * t);
        respawn(1, 6, 1758 * t);
        respawn(1, 4, 1761 * t);
        respawn(1, 2, 1428 * t);
        respawn(3, 4, 1428 * t);
        respawn(1, 4, 1476 * t);
        respawn(3, 6, 1476 * t);
        respawn(1, 8, 1524 * t);
        respawn(2, 6, 1524 * t);
        respawn(1, 6, 1572 * t);
        respawn(2, 4, 1572 * t);
        respawn(4, 6, 1620 * t);
        respawn(2, 4, 1626 * t);
        respawn(3, 6, 1668 * t);
        respawn(4, 4, 1674 * t);
        respawn(1, 8, 1716 * t);
        respawn(1, 4, 1719 * t);
        respawn(1, 6, 1722 * t);
        respawn(1, 2, 1725 * t);
        respawn(1, 8, 1764 * t);
        respawn(1, 2, 1767 * t);
        respawn(1, 6, 1770 * t);
        respawn(1, 4, 1773 * t);
        respawn(1, 2, (48 * 37) * t);//37
        respawn(1, 2, (48 * 37+30) * t);
        respawn(1, 2, (48 * 37 + 42) * t);
    }


    void Update () {
        temp = transform.position;
	
	}


    void respawn(int a, int b, float c)                                       // a = 노트 종류, b = 위치, c = 시간
    {
        if (a == 1)
        {
            if (b == 1)
            {
                Invoke("SH_res1", c);
            }
            if (b == 2)
            {
                Invoke("SH_res2", c);
            }
            if (b == 3)
            {
                Invoke("SH_res3", c);
            }
            if (b == 4)
            {
                Invoke("SH_res4", c);
            }
            if (b == 5)
            {
                Invoke("SH_res5", c);
            }
            if (b == 6)
            {
                Invoke("SH_res6", c);
            }
            if (b == 7)
            {
                Invoke("SH_res7", c);
            }
            if (b == 8)
            {
                Invoke("SH_res8", c);
            }
        }

        if (a == 2)
        {
            if (b == 1)
            {
                Invoke("SL_res1_L", c);
            }
            if (b == 2)
            {
                Invoke("SL_res2_L", c);
            }
            if (b == 3)
            {
                Invoke("SL_res3_L", c);
            }
            if (b == 4)
            {
                Invoke("SL_res4_L", c);
            }
            if (b == 5)
            {
                Invoke("SL_res5_L", c);
            }
            if (b == 6)
            {
                Invoke("SL_res6_L", c);
            }
            if (b == 7)
            {
                Invoke("SL_res7_L", c);
            }
            if (b == 8)
            {
                Invoke("SL_res8_L", c);
            }
        }

        if (a == 3)
        {
            if (b == 1)
            {
                Invoke("SL_res1_R", c);
            }
            if (b == 2)
            {
                Invoke("SL_res2_R", c);
            }
            if (b == 3)
            {
                Invoke("SL_res3_R", c);
            }
            if (b == 4)
            {
                Invoke("SL_res4_R", c);
            }
            if (b == 5)
            {
                Invoke("SL_res5_R", c);
            }
            if (b == 6)
            {
                Invoke("SL_res6_R", c);
            }
            if (b == 7)
            {
                Invoke("SL_res7_R", c);
            }
            if (b == 8)
            {
                Invoke("SL_res8_R", c);
            }
        }

        if (a == 4)
        {
            if (b == 1)
            {
                Invoke("SL_res1_U", c);
            }
            if (b == 2)
            {
                Invoke("SL_res2_U", c);
            }
            if (b == 3)
            {
                Invoke("SL_res3_U", c);
            }
            if (b == 4)
            {
                Invoke("SL_res4_U", c);
            }
            if (b == 5)
            {
                Invoke("SL_res5_U", c);
            }
            if (b == 6)
            {
                Invoke("SL_res6_U", c);
            }
            if (b == 7)
            {
                Invoke("SL_res7_U", c);
            }
            if (b == 8)
            {
                Invoke("SL_res8_U", c);
            }
        }
    }


    
    //////////////////////////////////////////////////////////////
    


    void SH_res1() {
        Instantiate(SH_note, transform.position, transform.rotation);
    }
    void SH_res2() {
        Instantiate(SH_note, new Vector3(temp.x + 1.5f, temp.y, temp.z), transform.rotation);
    }
    void SH_res3() {
        Instantiate(SH_note, new Vector3(temp.x + 3, temp.y, temp.z), transform.rotation);
    }
    void SH_res4() {
        Instantiate(SH_note, new Vector3(temp.x + 4.5f, temp.y, temp.z), transform.rotation);
    }
    void SH_res5() {
        Instantiate(SH_note, new Vector3(temp.x + 6, temp.y, temp.z), transform.rotation);
    }
    void SH_res6() {
        Instantiate(SH_note, new Vector3(temp.x + 7.5f, temp.y, temp.z), transform.rotation);
    }
    void SH_res7() {
        Instantiate(SH_note, new Vector3(temp.x + 9, temp.y, temp.z), transform.rotation);
    }
    void SH_res8() {
        Instantiate(SH_note, new Vector3(temp.x + 10.5f, temp.y, temp.z), transform.rotation);
    }
    void SL_res1_R() {
        Instantiate(SL_note_R, transform.position, transform.rotation);
    }
    void SL_res2_R() {
        Instantiate(SL_note_R, new Vector3(temp.x + 1.5f, temp.y, temp.z), transform.rotation);
    }
    void SL_res3_R() {
        Instantiate(SL_note_R, new Vector3(temp.x + 3, temp.y, temp.z), transform.rotation);
    }
    void SL_res4_R() {
        Instantiate(SL_note_R, new Vector3(temp.x + 4.5f, temp.y, temp.z), transform.rotation);
    }
    void SL_res5_R() {
        Instantiate(SL_note_R, new Vector3(temp.x + 6, temp.y, temp.z), transform.rotation);
    }
    void SL_res6_R() {
        Instantiate(SL_note_R, new Vector3(temp.x + 7.5f, temp.y, temp.z), transform.rotation);
    }
    void SL_res7_R() {
        Instantiate(SL_note_R, new Vector3(temp.x + 9, temp.y, temp.z), transform.rotation);
    }
    void SL_res8_R() {
        Instantiate(SL_note_R, new Vector3(temp.x + 10.5f, temp.y, temp.z), transform.rotation);
    }
    void SL_res1_L() {
        Instantiate(SL_note_L, transform.position, transform.rotation);
    }
    void SL_res2_L() {
        Instantiate(SL_note_L, new Vector3(temp.x + 1.5f, temp.y, temp.z), transform.rotation);
    }
    void SL_res3_L() {
        Instantiate(SL_note_L, new Vector3(temp.x + 3, temp.y, temp.z), transform.rotation);
    }
    void SL_res4_L() {
        Instantiate(SL_note_L, new Vector3(temp.x + 4.5f, temp.y, temp.z), transform.rotation);
    }
    void SL_res5_L() {
        Instantiate(SL_note_L, new Vector3(temp.x + 6, temp.y, temp.z), transform.rotation);
    }
    void SL_res6_L() {
        Instantiate(SL_note_L, new Vector3(temp.x + 7.5f, temp.y, temp.z), transform.rotation);
    }
    void SL_res7_L() {
        Instantiate(SL_note_L, new Vector3(temp.x + 9, temp.y, temp.z), transform.rotation);
    }
    void SL_res8_L() {
        Instantiate(SL_note_L, new Vector3(temp.x + 10.5f, temp.y, temp.z), transform.rotation);
    }
    void SL_res1_U()
    {
        Instantiate(SL_note_U, transform.position, transform.rotation);
    }
    void SL_res2_U()
    {
        Instantiate(SL_note_U, new Vector3(temp.x + 1.5f, temp.y, temp.z), transform.rotation);
    }
    void SL_res3_U()
    {
        Instantiate(SL_note_U, new Vector3(temp.x + 3, temp.y, temp.z), transform.rotation);
    }
    void SL_res4_U()
    {
        Instantiate(SL_note_U, new Vector3(temp.x + 4.5f, temp.y, temp.z), transform.rotation);
    }
    void SL_res5_U()
    {
        Instantiate(SL_note_U, new Vector3(temp.x + 6, temp.y, temp.z), transform.rotation);
    }
    void SL_res6_U()
    {
        Instantiate(SL_note_U, new Vector3(temp.x + 7.5f, temp.y, temp.z), transform.rotation);
    }
    void SL_res7_U()
    {
        Instantiate(SL_note_U, new Vector3(temp.x + 9, temp.y, temp.z), transform.rotation);
    }
    void SL_res8_U()
    {
        Instantiate(SL_note_U, new Vector3(temp.x + 10.5f, temp.y, temp.z), transform.rotation);
    }

    /////////////////////////////////////////////////////////////////////
}
