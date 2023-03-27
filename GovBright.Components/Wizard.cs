namespace GovBright.Components
{
    using Microsoft.AspNetCore.Components;

    public partial class Wizard : ComponentBase
    {
         protected internal List<WizardStep> Steps = new List<WizardStep>();

       
        [Parameter]
        public string Id { get; set; }

      
        [Parameter]
        public RenderFragment ChildContent { get; set; }

       
        [Parameter]
        public WizardStep ActiveStep { get; set; }

       
        [Parameter]
        public int ActiveStepIx { get; set; }

        public bool IsLastStep { get; set; }

        protected internal void GoBack()
        {
            if (ActiveStepIx > 0)
                SetActive(Steps[ActiveStepIx - 1]);
        }

        protected internal void GoNext()
        {
            if (ActiveStepIx < Steps.Count - 1)
                SetActive(Steps[(Steps.IndexOf(ActiveStep) + 1)]);
        }

       
        protected internal void SetActive(WizardStep step)
        {
            ActiveStep = step ?? throw new ArgumentNullException(nameof(step));

            ActiveStepIx = StepsIndex(step);
            if (ActiveStepIx == Steps.Count - 1)
                IsLastStep = true;
            else
                IsLastStep = false;
        }

 public int StepsIndex(WizardStep step) => StepsIndexInternal(step);
        protected int StepsIndexInternal(WizardStep step)
        {
            if (step == null)
                throw new ArgumentNullException(nameof(step));

            return Steps.IndexOf(step);
        }

        protected internal void AddStep(WizardStep step)
        {
            Steps.Add(step);
        }

        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                SetActive(Steps[0]);
                StateHasChanged();
            }
        }
    }
}
