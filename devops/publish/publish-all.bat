cd ../../src
nuget restore
cd ../devops/publish
PowerShell -NoProfile -ExecutionPolicy Bypass -Command "& '../build/build-all.ps1'"
SET package_version=2.2.7
cd ../pack
call pack-all
cd ../publish
call copy-all %package_version%
cd ../install
call uninstall-global-all.bat %package_version%
cd ..