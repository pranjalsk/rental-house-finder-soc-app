﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;

namespace SOAPServices
{
    public class ServiceNearByStores : IServiceNearByStores
    {

        public string findNearestStore(string zip, string storeType)
        {
            WebToStringService.ServiceClient proxyWebToString = new WebToStringService.ServiceClient();
            string longLat = getLatLong(zip);
            string radius = "5000"; //5 km

            string url = "https://maps.googleapis.com/maps/api/place/nearbysearch/xml?location=" + longLat + "&radius=" + radius + "&type=" + storeType + "&key=AIzaSyDd4VayFwaSkajfB2HtiFz71A70uSthM4A";

            string webContent = proxyWebToString.GetWebContent(url);

            XmlDocument xmldoc = new XmlDocument();
            xmldoc.LoadXml(webContent);

            XmlNodeList elemList = xmldoc.GetElementsByTagName("name");

            // List<string> storeNames = new List<string>();
            string result = "";

            for (int i = 0; i < elemList.Count; i++)
            {
                //  storeNames.Add(elemList[i].InnerXml);
                result += elemList[i].InnerXml + ", ";
            }
            return result;
        }


        public string getLatLong(string zip)
        {
            WebToStringService.ServiceClient proxyWebToString = new WebToStringService.ServiceClient();
            //Find latitude longitude using google api;
            string locationApi = "https://maps.googleapis.com/maps/api/geocode/xml?address=" + zip;
            string xmlLocContent = proxyWebToString.GetWebContent(locationApi);

            XmlDocument xmlDocLocApi = new XmlDocument();
            xmlDocLocApi.LoadXml(xmlLocContent);
            XmlNodeList parentNode = xmlDocLocApi.GetElementsByTagName("location");
            string latlng = "";
            foreach (XmlNode childNode in parentNode)
            {
                string lat = childNode.SelectSingleNode("lat").InnerXml;
                string lng = childNode.SelectSingleNode("lng").InnerXml;
                latlng = lat + "," + lng;
            }
            return latlng;
        }




    }
}
