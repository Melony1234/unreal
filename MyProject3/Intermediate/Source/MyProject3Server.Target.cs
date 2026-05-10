using UnrealBuildTool;

public class MyProject3ServerTarget : TargetRules
{
	public MyProject3ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("MyProject3");
	}
}
