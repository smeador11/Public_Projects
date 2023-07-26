using System;
using WhatsForDinner.JsonModels;
using WhatsForDinner.ViewControllers.Contracts;

namespace WhatsForDinner.Presenters.Contracts
{
    public interface RecipePresenterInterface
    {
        void BindToView(RecipeViewControllerInterface view, RecipeJsonModel recipe);
    }
}

