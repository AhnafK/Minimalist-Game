using UnityEngine;

/*
 * Looping Music through Scenes
 * "How to Play or Stop Music Through Scenes in Unity"- Billy Man
 * https://www.youtube.com/watch?v=ha6U8jHl9ak, 2022, February 25th
 */

public class BGmusic : MonoBehaviour
{
    public static BGmusic instance;

    void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
