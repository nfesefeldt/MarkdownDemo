using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace MarkdownDemo.iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            tableView.Source = new TableSource(Util.GetTestItems());
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }

        class TableSource : UITableViewSource
        {
            public List<Tuple<string, string>> items;

            public TableSource(List<Tuple<string,string>> items)
            {
                this.items = items;
            }

            public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
            {
                var cell = tableView.DequeueReusableCell("CustomCell") as CustomCell;
//                cell.textLabel.Text = items[indexPath.Row].Item1;
              //  cell.textSubLabel.Text = items[indexPath.Row].Item2;
                
                return cell;
            }

            public override nint RowsInSection(UITableView tableview, nint section)
            {
                return items.Count;
            }
        }

    }
}
