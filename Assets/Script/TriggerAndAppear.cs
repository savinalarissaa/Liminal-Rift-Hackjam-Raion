using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAndAppear : MonoBehaviour
{
    private SpriteRenderer sr;
    private float duration = 1f;
    private bool appeared = false;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !appeared)
        {
            StartCoroutine(Appear());
        }

        appeared = true;
    }

    private IEnumerator Appear()
    {
        float time = 0f;

        while(time < duration)
        {
            float alpha = Mathf.Lerp(1f, 0f, 1-(time/duration));
            Color newColor = sr.color;
            newColor.a = alpha;
            sr.color = newColor;

            time += Time.deltaTime;
            yield return null;
        }
    }


}
