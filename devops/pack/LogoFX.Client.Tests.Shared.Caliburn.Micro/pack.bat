cd contents
rmdir /Q /S lib
mkdir lib
cd lib
mkdir net461\
robocopy ../../../../../src/Bin/netframework/Release net461 LogoFX.Client.Testing.Shared.Caliburn.Micro.* /E
robocopy ../../../../../src/Bin/netframework/Release net461 Caliburn.Micro.* /E
robocopy ../../../../../src/Bin/netframework/Release net461 System.Windows.Interactivity.* /E
mkdir net6.0
robocopy ../../../../../src/Bin/net/Release net6.0 LogoFX.Client.Testing.Shared.Caliburn.Micro.* /E
robocopy ../../../../../src/Bin/net/Release net6.0 Caliburn.Micro.* /E
robocopy ../../../../../src/Bin/net/Release net6.0 System.Windows.Interactivity.* /E
cd net6.0
rmdir /Q /S ref
cd ..
mkdir netcoreapp3.1
robocopy ../../../../../src/Bin/netcore/Release netcoreapp3.1 LogoFX.Client.Testing.Shared.Caliburn.Micro.* /E
robocopy ../../../../../src/Bin/netcore/Release netcoreapp3.1 Caliburn.Micro.* /E
robocopy ../../../../../src/Bin/netcore/Release netcoreapp3.1 System.Windows.Interactivity.* /E
cd ../../
nuget pack contents/LogoFX.Client.Tests.Shared.Caliburn.Micro.nuspec -OutputDirectory ../../../output