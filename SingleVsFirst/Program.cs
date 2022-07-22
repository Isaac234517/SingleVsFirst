// See https://aka.ms/new-console-template for more information
using SingleVsFirst;
using BenchmarkDotNet.Running;
var summary = BenchmarkRunner.Run<SingleVsFirstTest>();
