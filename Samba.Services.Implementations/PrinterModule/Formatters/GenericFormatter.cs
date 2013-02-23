﻿namespace Samba.Services.Implementations.PrinterModule.Formatters
{
    internal class GenericFormatter : AbstractLineFormatter
    {
        public GenericFormatter(string documentLine, int maxWidth)
            : base(documentLine, maxWidth)
        { }

        public override string GetFormattedLine()
        {
            var result = Tag.Tag + Line;
            if (!string.IsNullOrWhiteSpace(result)) return result;
            return "";
        }
    }
}