param(
	[parameter(Mandatory = $true)]
	[String]
	$name = ''
)

$fullPathIncFileName = $MyInvocation.MyCommand.Definition
$currentScriptName = $MyInvocation.MyCommand.Name
$currentExecutingPath = $fullPathIncFileName.Replace($currentScriptName, "")

pushd $currentExecutingPath

dotnet ef migrations `
	   add $name `
	   --output-dir .\Data\Migrations\ `
	   --project ..\..\

popd