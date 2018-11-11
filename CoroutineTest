//Unity 2018.2.8f1

using System.Collections;
using UnityEngine;

public class CoroutineTest : MonoBehaviour {
     void Start () {
         StartCoroutine(Coroutine1());
     }
     IEnumerator Coroutine1()
     {
         Debug.Log("処理１");
         var coroutine2 = StartCoroutine(Coroutine2());
         yield return coroutine2;
         Debug.Log("処理３");
     }
     IEnumerator Coroutine2()
    {
         Debug.Log("処理２");
         yield return new WaitForSeconds(1f);
     }
}
