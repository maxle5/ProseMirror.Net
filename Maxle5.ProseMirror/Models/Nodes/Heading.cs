﻿using HtmlAgilityPack;
using System;
using System.Text.RegularExpressions;

namespace Maxle5.ProseMirror.Models.Nodes
{
    internal class HeadingAttributes : NodeAttributes
    {
        public int? Level { get; set; }
        public string TextAlign { get; set; } = "left";
    }

    internal class Heading : Node
    {
        public Heading(HtmlNode node) : base("heading")
        {
            Attrs = new HeadingAttributes
            {
                Level = GetLevel(node.Name)
            };
        }

        public new HeadingAttributes Attrs { get; protected set; }

        public static int? GetLevel(string tagName)
        {
            var match = Regex.Match(tagName, "^h([1-6])$");
            return match.Success ? (int?)Convert.ToInt32(match.Groups[1].Value) : null;
        }

        public override HtmlNode RenderHtmlNode()
        {
            return HtmlNode.CreateNode($"<h{Attrs?.Level}></h{Attrs?.Level}>");
        }
    }
}
