node {

bat '''
set THISDIR=%~dp0
set MSBUILD=C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Enterprise\\MSBuild\\15.0\\Bin\\MSBuild.exe

echo **********************************************                   Building ListFilesBySize        ***********************************************
echo .
echo This dir is: %THISDIR%
echo .

echo env variables
set
echo .
echo .
echo .
echo .
echo .

pushd %WORKSPACE%

"%MSBUILD%" "%WORKSPACE%\\ListFileBySize.sln"  /t:Build /p:Configuration=Debug;Platform=x64

popd


'''
}