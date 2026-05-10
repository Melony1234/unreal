using UnrealBuildTool;

public class MyProject3ClientTarget : TargetRules
{
	public MyProject3ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("MyProject3");
	}
}
