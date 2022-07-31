using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class WordYT
{
    public char[] word = new char[5];
}
public class WorldController : MonoBehaviour
{
  
    public List<WordYT> wordList = new List<WordYT>();
    public string currentWord;
    public List<string> wordListString = new List<string>();


    private void Awake()
    {
        currentWord = wordListString[Random.Range(0,wordListString.Count)];
        Converter();
    }

    void Converter()
    {
        foreach(string word in wordListString)
        {
            WordYT temp = new WordYT();
            temp.word = word.ToCharArray();
            wordList.Add(temp);
        }
    }

}
