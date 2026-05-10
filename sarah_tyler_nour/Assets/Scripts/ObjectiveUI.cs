using System.Collections;
using UnityEngine;
using TMPro;

public class ObjectiveUI : MonoBehaviour
{
    public TextMeshProUGUI objectiveText;

    void Start()
    {
        Debug.Log("Objective UI using: " + objectiveText.name);

        objectiveText.gameObject.SetActive(true);
        objectiveText.color = new Color(objectiveText.color.r, objectiveText.color.g, objectiveText.color.b, 1f);
    }

    public void ShowObjective(string message, float duration)
    {
        StopAllCoroutines();

        if (objectiveText == null)
        {
            Debug.LogError("objectiveText is NOT assigned!");
            return;
        }

        objectiveText.gameObject.SetActive(true);
        objectiveText.text = message;

        StartCoroutine(FadeRoutine(duration));
    }

    IEnumerator FadeRoutine(float duration)
    {
        yield return StartCoroutine(Fade(0f, 1f, 0.5f));

        yield return new WaitForSeconds(duration);

        yield return StartCoroutine(Fade(1f, 0f, 0.5f));

        objectiveText.gameObject.SetActive(false);
    }

    IEnumerator Fade(float start, float end, float time)
    {
        float t = 0f;

        Color c = objectiveText.color;

        while (t < time)
        {
            t += Time.deltaTime;

            float a = Mathf.Lerp(start, end, t / time);
            objectiveText.color = new Color(c.r, c.g, c.b, a);

            yield return null;
        }

        objectiveText.color = new Color(c.r, c.g, c.b, end);
    }
}
