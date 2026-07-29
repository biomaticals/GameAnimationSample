// MCP tooling scaffold — 최소 게임 모듈 빌드 규칙.
using UnrealBuildTool;

public class GameAnimationSample : ModuleRules
{
	public GameAnimationSample(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });
	}
}
