using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Card Events", order = 1)]
public class CardEvents : ScriptableObject
{
   public string cardName = "";
   public string description = "";
   public string effectDescription = "";
   public int influenceTime = 0;
   public int influenceKnowledge = 0;
   public int influenceMatter = 0;
   public int influenceAnomaly = 0;
   public int influenceCreation = 0;
   public int influenceEntropy = 0;
   public bool objectSummon = false;
   public bool specialEffect = false;
   public string summonedObject1 = "";
   public bool randomObject = false;
   public string summonedObject2 = "";
   public string summonedObject3 = "";
   public string summonedObject4 = "";
   public string summonedObject5 = "";
   public bool objectDestruction = false;
   public string destroyedObjectType = "";
   public bool objectChoose = false;
   public int minNumberObjectsDestroyed = 0;
   public int maxNumberObjectsDestroyed = 0;
   public string summonedObject6 = "";
   public bool effectDependency = false;
   public bool influenceAvailable = false;
   public bool affectedObjectByType = false;
   public bool affectedObjectByClass = false;
   public string affectedObjectType = "";
   public string affectedObjectClass = "";
   public bool affectFewObjects = false;
   public int affectedObjectsNumber = 0;
   public bool affectAllMatchingObgects = false;
   public bool allMatchingObjectsDestroy = false;
}