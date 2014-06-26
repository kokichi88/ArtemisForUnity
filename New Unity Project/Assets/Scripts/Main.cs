using UnityEngine;
using System.Collections;
using Artemis;
using Artemis.System;

public class Main : MonoBehaviour {
	EntityWorld world;
	// Use this for initialization
	void Awake () {
		world = new EntityWorld();

		for(int i = 0; i< 5; ++i){
			Entity e = world.CreateEntity();
			TestComp1 te = new TestComp1();
			e.AddComponent(te);
		}
		EntitySystem.BlackBoard.SetEntry<TestProcessor>("test1", new TestProcessor());
		//world.RefreshEntity();
		TestProcessor processor = new TestProcessor();
		TestProcessor2 processor2 = new TestProcessor2();
		world.SystemManager.SetSystem<TestProcessor>(processor,Artemis.Manager.GameLoopType.Update);
//		world.SystemManager.SetSystem<TestProcessor2>(processor2,Artemis.Manager.GameLoopType.Update);
	}
	
	// Update is called once per frame
	void Update () {
		world.Update(0);
		world.Draw();
	}
}
