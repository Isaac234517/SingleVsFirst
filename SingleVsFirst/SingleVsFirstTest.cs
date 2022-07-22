using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;

namespace SingleVsFirst
{
    [SimpleJob(RunStrategy.ColdStart, targetCount: 500)]
    public class SingleVsFirstTest
    {
        private readonly QueryService _service;

        [Params(0,5000, 9999)]
        public int Id;

        public SingleVsFirstTest()
        {
            _service = new QueryService(10000);
        }

        [Benchmark]
        public Guest GetSingleByID() => _service.SingleOrDefaultByID(Id)!;

        [Benchmark]
        public Guest GetFirstByID() => _service.FirstOrDefaultByID(Id)!;

    }
}
