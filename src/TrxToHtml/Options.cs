﻿using CommandLine;

namespace TrxToHtml
{
    public class Options
    {
        [Option("searchPattern", Default = "*.trx", HelpText = "search pattern to scan for trx files")]
        public string SearchPattern { get; set; } = default!;

        [Option("outputFileName", Default = "TestResults.html", HelpText = "name for the html file")]
        public string OutputFilename { get; set; } = default!;

        [Option("outputDirectory", Default = ".", HelpText = "target directory for the html file")]
        public string OutputDirectory { get; set; } = default!;

        [Option("workingDirectory", Default = ".", HelpText = "directory to scan recursive for trx files")]
        public string WorkingDirectory { get; set; } = default!;

        [Option("templateFile", Default = null, HelpText = "path of template file used to create the html file")]
        public string TemplateFile { get; set; } = null;

        [Option("verbose", Default = false, HelpText = "show some verbose output")]
        public bool Verbose { get; set; } = default!;
    }
}
