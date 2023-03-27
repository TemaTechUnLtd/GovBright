namespace GovBright.Components
{
    using Microsoft.AspNetCore.Components;

    public partial class WizardStep : ComponentBase
    {        
        [CascadingParameter]
        protected internal Wizard Parent { get; set; }
       
        [Parameter]
        public RenderFragment ChildContent { get; set; }
        
        [Parameter]
        public string Name { get; set; }

        protected override void OnInitialized()
        {
            Parent.AddStep(this);
        }
    }
}
