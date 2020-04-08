using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("血量"), Range(50, 500)]
    [Tooltip("怪物的血量")]
    public int 血量 ;
    [Header("魔力"), Range(10, 100)]
    [Tooltip("怪物的魔力")]
    public int 魔力 = 100;
    [Header("能力值")]
    [Range(1, 50.5f)]
    public float 移動速度 = 10.5F;
    [Range(20, 200)]
    public int 攻擊力 = 50;
    [Range(0, 100)]
    public int 防禦力;
    [Header("裝備")]
    public string 武器名稱;
    public string 裝備名稱 = "皮衣";
    [Header("其他資料")]
    [Tooltip("怪物是否帶有鑰匙")]
    public bool 是否帶有鑰匙 = false;
    [Tooltip("怪物是否帶有寶物")]
    public bool 是否掉落寶物 = false;



}
