using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogDoor : Door
{
   // Start is called before the first frame update
   void Start(){}
   // Update is called once per frame
   void Update(){}

   override public void interact()
   {
      //Remove associated fog
      Debug.Log("Remove Fog");
   }
}