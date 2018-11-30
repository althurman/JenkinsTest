node {
	stage 'Checkout'
		checkout scm

	stage 'Build'
		bat 'nuget restore ListFilesBySize.sln'

	stage 'Archive'
		archive 'ListFilesBySize/bin/Debug/**'
}
