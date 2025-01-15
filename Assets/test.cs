using UnityEngine;

public class test : MonoBehaviour
{
    // https://github.com/gilbutITbook/080267

    //private void Awake()
    //{
    //    Debug.Log("Awake");
    //}

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int intVal = 0;
        float floatVal = 0f;
        double doubleVal = 0;
        bool boolVal = true;
        char charVal = 'a';
        string stringVal = "a";
        long longVal = 0L;

        //for (int i = 0; i < 3; i += 1)
        //{
        //    Debug.Log("for, i = " + i);
        //}

        //string[] stringArray = new string[3];
        //stringArray[0] = "a";
        //stringArray[1] = "b";
        //stringArray[2] = "c";
        //for (int i = 0; i < stringArray.Length; i += 1)
        //{
        //    Debug.Log("stringArray = " + stringArray[i]);
        //}

        //int[] intArray = { 10, 20, 30 };
        //for (int i = 0; i < intArray.Length; i += 1)
        //{
        //    Debug.Log("intArray = " + intArray[i]);
        //}

        //int val = add(1, 2);
        //Debug.Log("val = " + val);

        //Player player = new Player();
        //player.attack();

        //player.Name = "name";
        //Debug.Log("name = " + player.Name);

        //player.nickName = "nickname";
        //Debug.Log("nickName = " + player.nickName);

        Vector2 pos1 = new Vector2(1, 1);
        Vector2 pos2 = new Vector2(1, 2);

        Vector2 sum = pos1 + pos2;
        Debug.Log("sum = " + sum);
        Debug.Log("sum[0] = " + sum[0] + "sum[1] = " + sum[1]);

        

        Debug.Log("Start");
    }

    // Update is called once per frame, before Update()
    //private void FixedUpdate()
    //{
    //    Debug.Log("FixedUpdate");
    //}

    // Update is called once per frame
    //void Update()
    //{
    //    Debug.Log("Update");
    //}

    // Update is called once per frame, after Update()
    //private void LateUpdate()
    //{
    //    Debug.Log("LateUpdate");
    //}


    /*
     * funtion
     */
    int add(int a, int b)
    {
        return a + b;
    }

}

public class Player
{
    string name;
    //int power;
    //int hp;

    public string nickName {  get; set; }

    public void attack()
    {
        Debug.Log("player attack");
    }

    public void damage()
    {
        Debug.Log("player damage");
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

}





