﻿using System;
using Foundation;
using MapKit;

namespace WhatsForDinner.ViewControllers.ViewUtilities
{
    public class DonateFoodMapDelegate : MKMapViewDelegate
    {
        string pId = "PinAnnotation";

        [Export("mapView:viewForAnnotation:")]
        public override MKAnnotationView GetViewForAnnotation(MKMapView mapView, IMKAnnotation annotation)
        {
            if (annotation is MKUserLocation)
                return null;

            // create pin annotation view
            MKAnnotationView pinView = (MKPinAnnotationView)mapView.DequeueReusableAnnotation(pId);

            if (pinView == null)
                pinView = new MKPinAnnotationView(annotation, pId);

            ((MKPinAnnotationView)pinView).PinColor = MKPinAnnotationColor.Red;
            pinView.CanShowCallout = true;

            return pinView;
        }
    }
}

