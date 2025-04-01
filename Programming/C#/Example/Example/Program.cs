#define EXAMPLE
#define PRACTICE

namespace Example
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if EXAMPLE
			//_03020103000101_SBS_Weekday_Engine_0001.E01.Example.Classes.Runtime.Example_01.CE01Example_01.Start(args);
			//_03020103000101_SBS_Weekday_Engine_0001.E01.Example.Classes.Runtime.Example_02.CE01Example_02.Start(args);
			_03020103000101_SBS_Weekday_Engine_0001.E01.Example.Classes.Runtime.Example_03.CE01Example_03.Start(args);
#elif PRACTICE
			//_03020103000101_SBS_Weekday_Engine_0001.E01.Practice.Classes.Runtime.Practice_01.CP01Practice_01.Start(args);
			_03020103000101_SBS_Weekday_Engine_0001.E01.Practice.Classes.Runtime.Practice_02.CP01Practice_02.Start(args);
#endif // #if EXAMPLE
		}
	}
}
