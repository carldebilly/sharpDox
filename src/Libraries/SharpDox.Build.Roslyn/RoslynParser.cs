﻿using System;
using System.Collections.Generic;
using SharpDox.Model;
using SharpDox.Sdk.Config;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.MSBuild;

namespace SharpDox.Build.Roslyn
{
    public class RoslynParser : ICodeParser
    {
        public event Action<string> OnDocLanguageFound;
        public event Action<string> OnStepMessage;
        public event Action<int> OnStepProgress;

        private readonly ParserStrings _parserStrings;

        public RoslynParser(ParserStrings parserStrings)
        {
            _parserStrings = parserStrings;
        }

        public SDSolution GetFullParsedSolution(string solutionFile, ICoreConfigSection sharpDoxConfig, Dictionary<string, string> tokens)
        {
            throw new NotImplementedException();
        }

        public SDSolution GetStructureParsedSolution(string solutionFile)
        {
            throw new NotImplementedException();
            //http://www.codeproject.com/Articles/861548/Roslyn-Code-Analysis-in-Easy-Samples-Part
            //https://joshvarty.wordpress.com/2014/10/30/learn-roslyn-now-part-7-introducing-the-semantic-model/
        }

        private void ExecuteOnDocLanguageFound(string lang)
        {
            var handlers = OnDocLanguageFound;
            if (handlers != null)
            {
                handlers(lang);
            }
        }

        private void ExecuteOnStepMessage(string message)
        {
            var handlers = OnStepMessage;
            if (handlers != null)
            {
                handlers(message);
            }
        }

        private void ExecuteOnStepProgress(int progress)
        {
            var handlers = OnStepProgress;
            if (handlers != null)
            {
                handlers(progress);
            }
        }
    }
}