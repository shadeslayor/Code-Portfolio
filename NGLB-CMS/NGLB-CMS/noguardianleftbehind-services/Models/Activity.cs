﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Rest;
using NGLBCMS.Models;
using Newtonsoft.Json.Linq;

namespace NGLBCMS.Models
{
    public partial class Activity
    {
        private string _activityID;
        
        /// <summary>
        /// Optional. Activity Unique ID (number/hash)
        /// </summary>
        public string ActivityID
        {
            get { return this._activityID; }
            set { this._activityID = value; }
        }
        
        private ActivityType _activityType;
        
        /// <summary>
        /// Optional. Activity Type ID (number/hash)
        /// </summary>
        public ActivityType ActivityType
        {
            get { return this._activityType; }
            set { this._activityType = value; }
        }
        
        private string _description;
        
        /// <summary>
        /// Optional. Activity Description (Launches a random Heroic strike,
        /// etc)
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private string _iconPath;
        
        /// <summary>
        /// Optional. Absolute Image Path of Activity Icon
        /// </summary>
        public string IconPath
        {
            get { return this._iconPath; }
            set { this._iconPath = value; }
        }
        
        private int? _level;
        
        /// <summary>
        /// Optional. Activity Level (41, etc)
        /// </summary>
        public int? Level
        {
            get { return this._level; }
            set { this._level = value; }
        }
        
        private int? _maxParty;
        
        /// <summary>
        /// Optional. Max Player Party Size
        /// </summary>
        public int? MaxParty
        {
            get { return this._maxParty; }
            set { this._maxParty = value; }
        }
        
        private int? _maxPlayers;
        
        /// <summary>
        /// Optional. Maximum Players in Activity
        /// </summary>
        public int? MaxPlayers
        {
            get { return this._maxPlayers; }
            set { this._maxPlayers = value; }
        }
        
        private int? _minParty;
        
        /// <summary>
        /// Optional. Minimum Party Size
        /// </summary>
        public int? MinParty
        {
            get { return this._minParty; }
            set { this._minParty = value; }
        }
        
        private IList<Skull> _modifiers;
        
        /// <summary>
        /// Optional. A list of objects that reprsent the Skull Modifiers
        /// </summary>
        public IList<Skull> Modifiers
        {
            get { return this._modifiers; }
            set { this._modifiers = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. Activity Name (Vanguard Heroic Strikes, Nightfall, etc)
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _pageBannerImagePath;
        
        /// <summary>
        /// Optional. Absolute Image Path of Activity Page Banner Image
        /// </summary>
        public string PageBannerImagePath
        {
            get { return this._pageBannerImagePath; }
            set { this._pageBannerImagePath = value; }
        }
        
        private DateTimeOffset? _resetTime;
        
        /// <summary>
        /// Optional. This is the DateTime that the Activity will Reset At
        /// </summary>
        public DateTimeOffset? ResetTime
        {
            get { return this._resetTime; }
            set { this._resetTime = value; }
        }
        
        private int? _tier;
        
        /// <summary>
        /// Optional. The Content Tier (Max Level Daily/Weekly/Level 30
        /// content, etc)
        /// </summary>
        public int? Tier
        {
            get { return this._tier; }
            set { this._tier = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Activity class.
        /// </summary>
        public Activity()
        {
            this.Modifiers = new LazyList<Skull>();
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken activityIDValue = inputObject["ActivityID"];
                if (activityIDValue != null && activityIDValue.Type != JTokenType.Null)
                {
                    this.ActivityID = ((string)activityIDValue);
                }
                JToken activityTypeValue = inputObject["ActivityType"];
                if (activityTypeValue != null && activityTypeValue.Type != JTokenType.Null)
                {
                    ActivityType activityType = new ActivityType();
                    activityType.DeserializeJson(activityTypeValue);
                    this.ActivityType = activityType;
                }
                JToken descriptionValue = inputObject["Description"];
                if (descriptionValue != null && descriptionValue.Type != JTokenType.Null)
                {
                    this.Description = ((string)descriptionValue);
                }
                JToken iconPathValue = inputObject["IconPath"];
                if (iconPathValue != null && iconPathValue.Type != JTokenType.Null)
                {
                    this.IconPath = ((string)iconPathValue);
                }
                JToken levelValue = inputObject["Level"];
                if (levelValue != null && levelValue.Type != JTokenType.Null)
                {
                    this.Level = ((int)levelValue);
                }
                JToken maxPartyValue = inputObject["MaxParty"];
                if (maxPartyValue != null && maxPartyValue.Type != JTokenType.Null)
                {
                    this.MaxParty = ((int)maxPartyValue);
                }
                JToken maxPlayersValue = inputObject["MaxPlayers"];
                if (maxPlayersValue != null && maxPlayersValue.Type != JTokenType.Null)
                {
                    this.MaxPlayers = ((int)maxPlayersValue);
                }
                JToken minPartyValue = inputObject["MinParty"];
                if (minPartyValue != null && minPartyValue.Type != JTokenType.Null)
                {
                    this.MinParty = ((int)minPartyValue);
                }
                JToken modifiersSequence = ((JToken)inputObject["Modifiers"]);
                if (modifiersSequence != null && modifiersSequence.Type != JTokenType.Null)
                {
                    foreach (JToken modifiersValue in ((JArray)modifiersSequence))
                    {
                        Skull skull = new Skull();
                        skull.DeserializeJson(modifiersValue);
                        this.Modifiers.Add(skull);
                    }
                }
                JToken nameValue = inputObject["Name"];
                if (nameValue != null && nameValue.Type != JTokenType.Null)
                {
                    this.Name = ((string)nameValue);
                }
                JToken pageBannerImagePathValue = inputObject["PageBannerImagePath"];
                if (pageBannerImagePathValue != null && pageBannerImagePathValue.Type != JTokenType.Null)
                {
                    this.PageBannerImagePath = ((string)pageBannerImagePathValue);
                }
                JToken resetTimeValue = inputObject["ResetTime"];
                if (resetTimeValue != null && resetTimeValue.Type != JTokenType.Null)
                {
                    this.ResetTime = ((DateTimeOffset)resetTimeValue);
                }
                JToken tierValue = inputObject["Tier"];
                if (tierValue != null && tierValue.Type != JTokenType.Null)
                {
                    this.Tier = ((int)tierValue);
                }
            }
        }
    }
}
