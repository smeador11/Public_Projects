using System;
using System.Threading;
using System.Threading.Tasks;
using Foundation;
using GameController;
using UIKit;
using WhatsForDinner.JsonModels;
using WhatsForDinner.TableViewCells;
using WhatsForDinner.Utilities;
using WhatsForDinner.ViewControllers;

namespace WhatsForDinner.TableViewSources
{
    public class RecipesTableViewSource : UITableViewSource
    {
        public Action<int> RecipeSelected { get; set; }
        RecipesViewController ViewController;

        public RecipesTableViewSource(RecipesViewController controller)
        {
            ViewController = controller;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell;
            if (ViewController.Recipes.Length == 0 && indexPath.Row == 0)
            {
                cell = tableView.DequeueReusableCell("Placeholder");
                if (cell == null)
                {
                    cell = new UITableViewCell(UITableViewCellStyle.Subtitle, "Placeholder");
                    cell.DetailTextLabel.TextAlignment = UITextAlignment.Center;
                    cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                    cell.DetailTextLabel.Text = "Loading";
                }
                return cell;
            }
            var recipeCell = tableView.DequeueReusableCell(RecipeTableViewCell.Key) as RecipeTableViewCell;
            var recipe = ViewController.Recipes[indexPath.Row];
            recipeCell.SetCellData(recipe);
            return recipeCell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return ViewController.Recipes.Length;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            RecipeSelected?.Invoke(ViewController.Recipes[indexPath.Row].RecipeId);
        }
    }
}

