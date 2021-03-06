﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace NGLBCMS.Models
{
    public partial class SearchPlayerResult
    {
        private string _iconImg;
        
        /// <summary>
        /// Optional. Path to Player Platform Icon
        /// </summary>
        public string IconImg
        {
            get { return this._iconImg; }
            set { this._iconImg = value; }
        }
        
        private string _membershipId;
        
        /// <summary>
        /// Optional. The unique ID (numbers) that represent this player
        /// </summary>
        public string MembershipId
        {
            get { return this._membershipId; }
            set { this._membershipId = value; }
        }
        
        private string _platform;
        
        /// <summary>
        /// Optional. Platform (xbox,psn)
        /// </summary>
        public string Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }
        
        private string _playerName;
        
        /// <summary>
        /// Optional. Display Name (Gamertag)
        /// </summary>
        public string PlayerName
        {
            get { return this._playerName; }
            set { this._playerName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SearchPlayerResult class.
        /// </summary>
        public SearchPlayerResult()
        {
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken iconImgValue = inputObject["IconImg"];
                if (iconImgValue != null && iconImgValue.Type != JTokenType.Null)
                {
                    this.IconImg = ((string)iconImgValue);
                }
                JToken membershipIdValue = inputObject["MembershipId"];
                if (membershipIdValue != null && membershipIdValue.Type != JTokenType.Null)
                {
                    this.MembershipId = ((string)membershipIdValue);
                }
                JToken platformValue = inputObject["Platform"];
                if (platformValue != null && platformValue.Type != JTokenType.Null)
                {
                    this.Platform = ((string)platformValue);
                }
                JToken playerNameValue = inputObject["PlayerName"];
                if (playerNameValue != null && playerNameValue.Type != JTokenType.Null)
                {
                    this.PlayerName = ((string)playerNameValue);
                }
            }
        }
    }
}
