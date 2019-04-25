node {
	stage ('Checkout')
	{
		checkout scm
	}
	stage ('Build')
	{
		bat 'F:\\BuildTools\\nuget.exe restore Greylock.sln'
		bat "\"${tool 'VS2017'}\"\\MsBuild.exe Greylock.sln /p:Configuration=Debug /p:Platform=\"x64\""
	}

	// stage 'Archive'
		// archiveArtifacts artifacts: '**', fingerprint: true
}