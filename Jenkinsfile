node {

bat '''
set THISDIR=%~dp0
set MSBUILD=C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Enterprise\\MSBuild\\15.0\\Bin\\MSBuild.exe

echo **********************************************                   Building ListFilesBySize        ***********************************************
echo .
echo This dir is: %THISDIR%
echo .

pushd %THISDIR%\..\


dir /s /b *.*

popd


'''
}