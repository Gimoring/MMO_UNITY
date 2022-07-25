using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    static Managers s_Instance; // 유일성이 보장된다.
    public static Managers Instance { get { Init();  return s_Instance; } } // 유일한 게임 매니저를 가져온다.
    
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    static void Init()
    {
        if (s_Instance == null)
        {
            GameObject obj = GameObject.Find("@Managers");
            if (obj == null)
            {
                obj = new GameObject { name = "@managers" };
                obj.AddComponent<Managers>();

            }
            DontDestroyOnLoad(obj);
            s_Instance = obj.GetComponent<Managers>();
        }
    }
}
