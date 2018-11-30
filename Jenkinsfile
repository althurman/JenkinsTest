def msbuild =  "C:/Program Files (x86)/Microsoft Visual Studio/2017/Enterprise/MSBuild/15.0/Bin/MsBuild.exe"
def exitStatus = bat(returnStatus: true, script: "${msbuild} ListFilesBySize.sln /p:Configuration=Debug /p:Platform=x64")
if (exitStatus != 0){
    currentBuild.result = 'FAILURE'
}
