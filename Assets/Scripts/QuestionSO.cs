using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
  [TextArea(2, 6)]
  [SerializeField] string question = "Exter new question text here";

  [SerializeField] List<string> answers;
  [SerializeField] int correctAnswerIndex;

  public string GetQuestion()
  {
    return question;
  }
  public int GetCorrectAnswerIndex()
  {
    return correctAnswerIndex;
  }
  public string GetAnswer(int index)
  {
    return answers[index];
  }
}
