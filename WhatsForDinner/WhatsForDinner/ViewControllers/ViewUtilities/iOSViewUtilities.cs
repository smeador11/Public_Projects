using System;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Threading;
using System.Threading.Tasks;
using Foundation;
using GameController;
using UIKit;
using WhatsForDinner.JsonModels;
using WhatsForDinner.TableViewCells;
using WhatsForDinner.Utilities;
using static CoreFoundation.DispatchSource;

namespace WhatsForDinner.ViewControllers.ViewUtilities
{
    public class iOSViewUtilities
    {
        
        public static UIImage DownloadImageFromUrl(string imageUrl)
        {
            NSUrl url = new NSUrl(imageUrl);
            NSData data = NSData.FromUrl(url);
            return UIImage.LoadFromData(data);
        }
    }
}

