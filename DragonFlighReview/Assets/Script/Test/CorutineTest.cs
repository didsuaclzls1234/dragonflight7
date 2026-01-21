using System.Collections;
using UnityEngine;

public class CorutineTest : MonoBehaviour
{
    
    
    void Start()
    {
        StartCoroutine(ChangeText());
    }
    IEnumerator ChangeText()
    {
        Debug.Log("1초 기다림");
        yield return new WaitForSeconds(1f);
        Debug.Log("시작");
        yield return new WaitForSeconds(2f);
        Debug.Log("끝");    
    }
    
}
