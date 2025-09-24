using System.Collections;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class CoroutineSample : MonoBehaviour
{
    [SerializeField] private Image bg;
    [SerializeField] private Image ball;
    void Start()
    {
        StartCoroutine(ChangeColor());
        ball.DOColor(new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f)), 5f);
    }

    private IEnumerator ChangeColor()
    {
        // for (int i = 5; i > 0; i--)
        // {
        //     text = i;
        //     yield return new WaitForSeconds(1f);
        // }
        
        //text = "5";
        //yield return new WaitForSeconds(1f);
        //text = "4";
        //yield return new WaitForSeconds(1f);
        //text = "3";
        //yield return new WaitForSeconds(1f);
        // asdasd.SetActive()
        // asdasd.SetActive()
        // asdasd.SetActive()
        // yield return new WaitForSeconds(5f);
        
        while (true)
        {
            //bg.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
            ball.DOColor(new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f)), 1f);
            ball.transform.DOMoveX(150, 1f);
            yield return new WaitForSeconds(1f);
            
            ball.DOColor(new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f)), 1f);
            ball.transform.DOMoveX(-150, 1f);
            yield return new WaitForSeconds(1f);
        }

        // for (int j = 0; j < 5; j++)
        // {
        //     bg.color = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
        //     yield return new WaitForSeconds(1f);
        // }
    }
}
