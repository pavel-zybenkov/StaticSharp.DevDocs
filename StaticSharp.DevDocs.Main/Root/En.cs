using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticSharp.DevDocs.Main.Root
{
    [Representative]
    public partial class En : DevDocsPageTemplate
    {
        public override Inlines? Description => $"Home page";

        //public override Block? Footer => new Paragraph($"qwerty");

        protected override void Setup(Context context)
        {
            base.Setup(context);
        }

        //public override Block? MainVisual => new Paragraph("<Main text>");

        public override Blocks? Content => new ()
        {
            $"Start from {Node.GettingStarted}",
            new Flipper
            {
                First = new Paragraph("First block"),
                Second = new Paragraph("Second block"),
                Children = { "Flipper child" },
                X = 30
            }
        };
    }
}
