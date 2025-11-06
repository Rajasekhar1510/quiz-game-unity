using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "QuestionData", menuName = "QuestionData")]
public class QuizDataScriptable : ScriptableObject
{
    [Header("Questions")]
    public List<Question> questions;
}
