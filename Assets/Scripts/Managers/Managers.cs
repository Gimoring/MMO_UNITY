using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    static Managers s_Instance; // ���ϼ��� ����ȴ�.
    static Managers Instance { get { Init();  return s_Instance; } } // ������ ���� �Ŵ����� �����´�.

    InputManager _input = new InputManager();
    public static InputManager Input { get { return Instance._input; } }

    ResourceManager _resource = new ResourceManager();
    public static ResourceManager Resource { get { return Instance._resource; } }

    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        Input.OnUpdate();
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
