using EtumrepSeed.Lib;
using System.Dynamic;
using PKHeX.Core;

namespace seedwrapper
{
    public class Find_Seed : DynamicObject
    {
        private GroupSeedFinder functions;
        public Find_Seed()
        {
            functions = new GroupSeedFinder();
        }

        public ulong find_seed(string folder)
        {
            return functions.FindSeed(folder);
        }

        public ulong find_seed(List<string> data)
        {
            return functions.FindSeed(data);
        }

        public ulong find_seed(List<byte[]> data)
        {
            //List<string> strings = data.Select(s => (string)s).ToList();

            IEnumerable<byte[]> files = data as IEnumerable<byte[]>;

            return functions.FindSeed(files);
        }

        public ulong find_seed(List<Object> data)
        {
            List<string> strings = data.Select(s => (string)s).ToList();

            IEnumerable<string> files = strings as IEnumerable<string>;

            return functions.FindSeed(files);
        }
    }
}