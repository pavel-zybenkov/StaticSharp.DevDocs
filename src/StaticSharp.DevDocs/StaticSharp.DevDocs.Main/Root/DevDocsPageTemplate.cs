using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticSharp.DevDocs.Main.Root
{
    public abstract partial class DevDocsPageTemplate : PageSideMenus
    {
        //protected override void Setup(Context context)
        //{
        //    ContentWidth = 800;
        //    base.Setup(context);
        //}

        public override string PageLanguage => VirtualNode.Language.ToString().ToLower();

        //public override string Title
        //{
        //    get
        //    {
        //        var n = GetType().Namespace;
        //        return n[(n.LastIndexOf('.') + 1)..].Replace('_', ' ');
        //    }
        //}

        // public override object? MainVisual => throw new NotImplementedException();

        // public override Inlines? Description => throw new NotImplementedException();

        // protected override Blocks BodyContent => throw new NotImplementedException();


        // public override Block? Footer => new Paragraph($"1234567890");

        public override Block? LeftSideBar => new ScrollLayout
        {
            Content = new Column()
            {
                Children =
                {
                    {
                        "MenuTitle", new Paragraph ( "Menu")
                        {
                            Weight = FontWeight.Bold
                        }
                    },
                    {
                        "Home", new Paragraph ("Home")
                        {
                            InternalLink = Node
                        }
                    },
                    {
                        "GettingStarted", new Paragraph ("Getting started")
                        {
                            InternalLink = Node.GettingStarted
                        }
                    }
                }
            }
        };

        //protected override Blocks BodyContent => new Blocks
        //{
        //    { "LeftSideBar", LeftSideBar },
        //    new ScrollLayout 
        //    { 
        //        Content = new Block
        //        { 
        //            Children = { Content } 
        //        } 
        //    }
        //};
    }
}
