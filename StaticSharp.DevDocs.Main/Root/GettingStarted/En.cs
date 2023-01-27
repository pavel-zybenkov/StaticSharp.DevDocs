using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticSharp.DevDocs.Main.Root.GettingStarted
{
    [Representative]
    public partial class En : DevDocsPageTemplate
    {
        //public override Block? MainVisual => new Paragraph("Getting Started main visual");

        public override Inlines? Description => $"Creating a new web site with StaticSharp";

        public override Blocks? Content => new() 
        {
            $"Here are simple steps to create new site with StaticSharp:",
            $"1. Create new console application with {DefaultStyle.Code("dotnet new console")}",
            $"2. Reference the following nuget packages: MixinGenerator, StaticSharp, StaticSharpSever, StaticSharpSourceGenerator",
            $"3. Implement starting either server or generator in Program.cs (will be moved to project template?)",
            $"4. Append \"Root\" folder to project root. It will be a root of a site routing",
            $"5. Append {DefaultStyle.Code("ProtoNode")} to \"Root\" folder. In simplest case it has to be the following:",
            DefaultStyle.CodeBlock(
                """
                public abstract class ProtoNode : MultilanguageProtoNode<Language>
                {
                    protected ProtoNode(Language language) : base(language){}
                }
                """),
            $"6. Append your first root page \"Root/En.cs\". It must be a class, in a simplest case it should be the folowing:",
            DefaultStyle.CodeBlock(
                """
                [Representative]
                public partial class En : Page
                {
                    protected override Blocks BodyContent => new ()
                    {
                        "Text text text"
                    }
                }
                """),
            $"7. Your simple site is ready. Run dotnet project in Server mode and go to \"http://localhost:80\". You should be able to see:",
            new Image("GettingStartedScreenshot1.png")
            {
                Width = 400
            }.CenterHorizontally(),
            $"TODO: all above likely will be replaced with dotnet project template"
        };
    }
}
