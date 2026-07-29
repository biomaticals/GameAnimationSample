// MCP tooling scaffold — GAS 를 코드 프로젝트로 승격시켜 MCPUnreal 플러그인을 컴파일하기 위한 최소 게임 모듈.
using UnrealBuildTool;
using System.Collections.Generic;

public class GameAnimationSampleTarget : TargetRules
{
	public GameAnimationSampleTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		ExtraModuleNames.Add("GameAnimationSample");
	}
}
