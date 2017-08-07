﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using NGLBCMS.Models;
using Newtonsoft.Json.Linq;

namespace NGLBCMS.Models
{
    public static partial class CharacterSelectionCollection
    {
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public static IList<CharacterSelection> DeserializeJson(JToken inputObject)
        {
            IList<CharacterSelection> deserializedObject = new List<CharacterSelection>();
            foreach (JToken iListValue in ((JArray)inputObject))
            {
                CharacterSelection characterSelection = new CharacterSelection();
                characterSelection.DeserializeJson(iListValue);
                deserializedObject.Add(characterSelection);
            }
            return deserializedObject;
        }
    }
}
