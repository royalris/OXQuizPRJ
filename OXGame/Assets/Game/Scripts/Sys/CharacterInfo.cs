using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterInfo : MonoBehaviour
{
    [Header("캐릭터 이름")]
    public string character_name; // 캐릭터 이름
    [Header("캐릭터 모델링 오브젝트")]
    public GameObject model; // 캐릭터 모델

    [Header("캐릭터 일러스트")]
    public Sprite illust;

    [Header("캐릭터 설명")]
    public string describe;


    [Header("캐릭터 레벨")]
    public int level = 1; // 캐릭터 레벨
    [Header("캐릭터 최대 레벨")]
    public int max_level = 10; // 캐릭터 최대 레벨
    [Header("강화 가능 수치 도달까지 필요한 캐릭터 갯수")]
    public int[] need_to_combine_amount; //강화 가능 수치 도달까지 필요한 캐릭터 갯수
    [Header("현재 합쳐져 있는 양")]
    public int curr_combined_amount; // 현재 합쳐져 있는 양
    
    [HideInInspector]
    public int curr_need_combine_amount; // 현재 강화에 필요한 캐릭터 중첩 수

    [Header("레벨당 공격력 증가량")]
    public float[] atk_increase_value; // 레벨당 공격력 증가량
    [Header(" 현재 공격력")]
    public float curr_atk = 10; // 현재 공격력
    [Header("최초 설정 공격력")]
    public float init_atk = 10; // 최초 설정 공격력

    [Header("레어도")]
    [Tooltip("S = 0, A = 1 , B = 2 , C = 3")]
    public int rank; //레어도

    private const int s = 0;
    private const int a = 1;
    private const int b = 2;
    private const int c = 3;

    public void Start()
    {
        level = 1;
        curr_need_combine_amount = need_to_combine_amount[level - 1];
    }

    public void LevelUp()
    {
        print("작동함");
        curr_atk += atk_increase_value[level -1];
        curr_combined_amount = curr_combined_amount - need_to_combine_amount[level -1];
        level++;
        curr_need_combine_amount = need_to_combine_amount[level-1];
    }
}