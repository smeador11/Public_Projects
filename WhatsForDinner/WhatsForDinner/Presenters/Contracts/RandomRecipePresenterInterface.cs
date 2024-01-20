using System;
using WhatsForDinner.ViewControllers.Contracts;

namespace WhatsForDinner.Presenters.Contracts
{
    public interface RandomRecipePresenterInterface
    {
        void BindToView(RandomRecipeViewControllerInterface view);
    }
}

