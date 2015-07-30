// Copyright 2015 Basaltic Studio. All Rights Reserved.
using System.IO;
using UnrealBuildTool;

namespace UnrealBuildTool.Rules
{
	public class MrubyPlugin : ModuleRules
	{
    private string ModulePath
    {
      get { return Path.GetDirectoryName(RulesCompiler.GetModuleFilename(this.GetType().Name)); }
    }

    private string ThirdPartyPath
    {
      get { return Path.GetFullPath(Path.Combine(ModulePath, "../../ThirdParty")); }
    }

		public MrubyPlugin(TargetInfo Target)
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
					"SlateCore",
					// ... add other public dependencies that you statically link with here ...
				}
				);

			if (UEBuildConfiguration.bBuildEditor == true)
			{

				PublicDependencyModuleNames.AddRange(
					new string[]
					{
						"UnrealEd",
					}
				);

			}


			DynamicallyLoadedModuleNames.AddRange(
				new string[]
				{
					// ... add any modules that your module loads dynamically here ...
				}
				);

			var MrubyPath = Path.Combine(ThirdPartyPath, "mruby");
			var MrubyLibDirectory = Path.Combine(MrubyPath, "build", "host", "lib");
			var MrubyLibPath = Path.Combine(MrubyLibDirectory, "libmruby.a");
			if (File.Exists(MrubyLibPath))
			{
				Definitions.Add("WITH_MRUBY=1");

				// Path to Mruby include files
				var IncludePath = Path.GetFullPath(Path.Combine(MrubyPath, "include"));
				PrivateIncludePaths.Add(IncludePath);

				// Lib file
				PublicLibraryPaths.Add(MrubyLibDirectory);
				PublicAdditionalLibraries.Add(MrubyLibPath);

				Log.TraceVerbose("Mruby Integration enabled: {0}", IncludePath);
			}
			else
			{
				Log.TraceVerbose("Mruby Integration NOT enabled");
			}
		}
	}
}
