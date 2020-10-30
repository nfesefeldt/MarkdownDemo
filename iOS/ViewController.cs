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

            button.TouchUpInside += Button_TouchUpInside;
        }

        private void Button_TouchUpInside(object sender, EventArgs e)
        {
            this.UpdateList();
        }

        private void UpdateList()
        {
            this.tableView.ReloadData();
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

                cell.label1.ApplyMarkdown(items[indexPath.Row].Item1);


                cell.label1.Layer.BorderColor = UIColor.Black.CGColor;
                cell.label1.Layer.BorderWidth = (nfloat)0.5;

                cell.label2.ApplyMarkdown(items[indexPath.Row].Item2);

                cell.label2.Layer.BorderColor = UIColor.Black.CGColor;
                cell.label2.Layer.BorderWidth = (nfloat)0.5;

                return cell;
            }

            public override nint RowsInSection(UITableView tableview, nint section)
            {
                return items.Count;
            }
        }

    }
}
