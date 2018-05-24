using System.IO;

namespace ShellTester.CreatorsTestset
{
	public interface ITestOutputDataCreator
	{
		StreamReader Create(StreamReader inputData);
	}
}