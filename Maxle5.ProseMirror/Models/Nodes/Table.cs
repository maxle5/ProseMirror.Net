﻿using HtmlAgilityPack;

namespace Maxle5.ProseMirror.Models.Nodes
{
    internal class Table : Node
    {
        public Table() : base("table")
        {
        }

        public override HtmlNode RenderHtmlNode()
        {
            return HtmlNode.CreateNode("<table></table>").AppendChild(HtmlNode.CreateNode("<tbody></tbody>"));
        }
    }
}
