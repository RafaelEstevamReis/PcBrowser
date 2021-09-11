# PcBrowser
A simple windows tool to browse performance counters on your local system. Nothing more, nothing less. Browse the performance counters on your system, which may be hard to find on certain locales.

- In the first column, the list of categories is shown
- Upon selection, the second column will show the list of instance
- After which the third column will show the actual list of performance counters

If you select an actual counter, the bottom right will show you a sample from the counter with a 1 second interval.

![ScreenShot](PerformanceCounterBrowser.png)

To learn more about the PerformanceCounter class used to access the data, see https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.performancecounter?view=netframework-4.8


