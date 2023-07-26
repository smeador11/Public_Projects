using System;
using Foundation;
using UIKit;
using WhatsForDinner.JsonModels;
using WhatsForDinner.TableViewCells;

namespace WhatsForDinner.TableViewSources
{
    public class ShoppingListTableViewSource : UITableViewSource
    {
        IngredientJsonModel[] MissingIngredients;
        IngredientJsonModel[] UsedIngredients;

        public ShoppingListTableViewSource(IngredientJsonModel[] missingIngredients, IngredientJsonModel[] usedIngredients)
        {
            MissingIngredients = missingIngredients;
            UsedIngredients = usedIngredients;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell(ShoppingListTableViewCell.Key) as ShoppingListTableViewCell;
            var ingredient = indexPath.Section == 0 ? MissingIngredients[indexPath.Row] : UsedIngredients[indexPath.Row];
            cell.SetCellData(ingredient);
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return section == 0 ? MissingIngredients.Length : UsedIngredients.Length;
        }
        public override nint NumberOfSections(UITableView tableView)
        {
            return 2;
        }
        public override string TitleForHeader(UITableView tableView, nint section)
        {
            return section == 0 ? "Missing Ingredients" : "Used Ingredients";
        }
    }
}

