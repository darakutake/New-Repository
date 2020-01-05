using UnityEngine;

public class MethodClass
{
    void Start()
    {
        int i;
        
        i = 1;
        Debug.Log("i=1:" + GetData(i).number.ToString() + "_" + GetData(i).name);
        
        i = 2;
        Debug.Log("i=2:" + GetData(i).number.ToString() + "_" + GetData(i).name);
    }
    
    public static (int number, string name) GetData(int n)
    {
        int number = 0;
        string name = "";
        switch(n)
        {
            case 1:
                number = 102;
                name = "豆腐";
                break;
            case 2:
                number = 877;
                name = "バナナ";
                break;
        }
        return (number, name);
}
