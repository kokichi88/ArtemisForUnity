// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using Artemis.System;
using UnityEngine;
using Artemis;
using System;

public class TestProcessor2 : EntityProcessingSystem
{
	public TestProcessor2()
		: base(Aspect.Empty())
	{
	}


	public override void Process (Artemis.Entity entity)
	{
		Debug.Log("TestProcessor2 " + entityWorld.Delta);
	}
}


