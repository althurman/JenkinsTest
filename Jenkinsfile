node {
	stage ('Checkout')
	{
		checkout scm
	}
	stage ('Build')
	{
		bat 'F:\\BuildTools\\nuget.exe restore ListFilesBySize.sln'
		bat "\"${tool 'VS2017'}\"\\MsBuild.exe ListFilesBySize.sln /p:Configuration=Debug /p:Platform=\"x64\" /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}"
	}
	stage ('UnitTests')
	{
		bat 'F:\\BuildTools\\xunit.runner.console.2.4.1\\tools\\net472\\xunit.console.exe %WORKSPACE%\\ListFilesTest\\bin\\Debug\\ListFilesTest.dll'
	}
	// stage 'Archive'
		// archiveArtifacts artifacts: '**', fingerprint: true
}