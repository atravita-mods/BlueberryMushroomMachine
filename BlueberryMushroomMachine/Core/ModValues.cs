﻿using System.IO;

namespace BlueberryMushroomMachine
{
	internal class ModValues
	{
		// Project
		internal const string AuthorName
			= "blueberry";
		internal const string PackageName
			= "BlueberryMushroomMachine";
		internal static readonly string PropagatorInternalName
			= $"{PackageName}.Propagator";

		// Files
		internal static readonly string MachinePath
			= Path.Combine("assets", "propagator.png");
		internal static readonly string OverlayPath
			= Path.Combine("assets", "overlay.png");
		internal static readonly string EventsPath
			= Path.Combine("assets", "events.json");

		// Objects
		internal static int PropagatorIndex = 0;
		internal static string ObjectData = "{0}/0/-300/Crafting -9/{1}/true/true/0";
		internal static string CraftingRecipeData = "388 20 709 1/Home/{0}/true/null";

		internal const int OverlayMushroomFrames = 3;
	}
}
