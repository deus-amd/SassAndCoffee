namespace SassAndCoffee.Core.Caching
{
    using System;

    public class NoCache : ICompiledCache
    {
        public CompilationResult GetOrAdd(string filename, Func<string, CompilationResult> compilationDelegate)
        {
            return compilationDelegate.Invoke(filename);
        }

        public void Clear()
        {
        }
    }
}