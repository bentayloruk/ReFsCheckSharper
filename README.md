> This is a very simple project that can be used to demonstrate an apparent issuse between the latest ReSharper built in test runner and FsCheck.Xunit.

There appears to be an issue between VS 2017, ReSharper and FsCheck.Xunit tests.  The ReSharper test runner cannot "see" my FsCheck.Xunit tests in the latest VS and ReSharper RC.  However, they work fine together in VS 2015, ReSharper 10 and Matt Ellis' fantastic R# extension.

The tests use the FsCheck.Xunit `Property` attribute.  This inherits form the Xunit `Fact` attribute.  There is a [single test](https://github.com/bentayloruk/ReFsCheckSharper/blob/master/ReFsCheckSharper/ReproPropertyTest.fs) in this project.

## The setup that *can* run the FsCheck xUnit test:

With the setup below, the **Run Unit Tests** option is present on the project or solution menu and I can run the single test successfully:

* Microsoft Visual Studio Professional 2015 - Version 14.0.25425.01 Update 3
* JetBrains ReSharper Ultimate 10.0.2 Build 104.0.20151218.120627
* ReSharper 10.0.20151218.130009
* xUnit for ReSharper test support plugin - 2.3.4

## The setup that *cannot* run the FsCheck xUnit test:

With the setup below, the **Run Unit Tests** option is not present on the project or solution menu and I cannot run the test:

* Microsoft Visual Studio Professional 2017 RC - Version 15.0.26206.0 D15REL
* JetBrains ReSharper Ultimate 2016.3.2  Build 107.0.20170126.120331
* ReSharper 2016.3.20170126.121504

