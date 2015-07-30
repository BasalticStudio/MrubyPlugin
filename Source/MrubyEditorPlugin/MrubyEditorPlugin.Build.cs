// Copyright 2015 Basaltic Studio. All Rights Reserved.

namespace UnrealBuildTool.Rules
{
	public class MrubyEditorPlugin : ModuleRules
	{
		public MrubyEditorPlugin(TargetInfo Target)
		{
			PublicIncludePaths.AddRange(
				new string[] {
					//"Programs/UnrealHeaderTool/Public",
					// ... add other public include paths required here ...
				}
				);

			PrivateIncludePaths.AddRange(
				new string[] {
					// ... add other private include paths required here ...
				}
				);

			PublicDependencyModuleNames.AddRange(
				new string[]
				{
					"Core",
					"CoreUObject",
					"Engine",
					"InputCore",
					"UnrealEd",
					"AssetTools",
					"MrubyPlugin",
					"ClassViewer",
					"KismetCompiler",
					"Kismet",
					"BlueprintGraph"
					// ... add other public dependencies that you statically link with here ...
				}
				);

			PrivateDependencyModuleNames.AddRange(
				new string[]
				{
					// ... add private dependencies that you statically link with here ...
				}
				);

			DynamicallyLoadedModuleNames.AddRange(
				new string[]
				{
					// ... add any modules that your module loads dynamically here ...
				}
				);
		}
	}
}
