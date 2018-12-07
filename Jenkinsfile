node {
	stage 'Checkout'
		checkout scm

	stage 'Build'
		bat 'F:\\BuildTools\\nuget.exe restore ListFilesBySize.sln'
		bat "\"${tool 'VS2017'}\"\\MsBuild.exe ListFilesBySize.sln /p:Configuration=Debug /p:Platform=\"x64\" /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}"

	// stage 'Archive'
		// archiveArtifacts artifacts: '**', fingerprint: true
}