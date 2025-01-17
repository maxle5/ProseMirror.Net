﻿using HtmlAgilityPack;

namespace Maxle5.ProseMirror.Models.Nodes
{
    internal class Blockquote : Node
    {
        public Blockquote() : base("blockquote")
        {
        }

        public override HtmlNode RenderHtmlNode()
        {
            return HtmlNode.CreateNode("<blockquote></blockquote>");
        }
    }
}
