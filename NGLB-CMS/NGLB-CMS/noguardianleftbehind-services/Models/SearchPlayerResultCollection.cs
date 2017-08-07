﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using NGLBCMS.Models;
using Newtonsoft.Json.Linq;

namespace NGLBCMS.Models
{
    public static partial class SearchPlayerResultCollection
    {
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public static IList<SearchPlayerResult> DeserializeJson(JToken inputObject)
        {
            IList<SearchPlayerResult> deserializedObject = new List<SearchPlayerResult>();
            foreach (JToken iListValue in ((JArray)inputObject))
            {
                SearchPlayerResult searchPlayerResult = new SearchPlayerResult();
                searchPlayerResult.DeserializeJson(iListValue);
                deserializedObject.Add(searchPlayerResult);
            }
            return deserializedObject;
        }
    }
}
