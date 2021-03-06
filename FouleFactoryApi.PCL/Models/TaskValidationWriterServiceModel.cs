/*
 * FouleFactoryApi.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 09/14/2016
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using FouleFactoryApi.PCL;

namespace FouleFactoryApi.PCL.Models
{
    public class TaskValidationWriterServiceModel : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int? idTask;
        private string state;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("IdTask")]
        public int? IdTask 
        { 
            get 
            {
                return this.idTask; 
            } 
            set 
            {
                this.idTask = value;
                onPropertyChanged("IdTask");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("State")]
        public string State 
        { 
            get 
            {
                return this.state; 
            } 
            set 
            {
                this.state = value;
                onPropertyChanged("State");
            }
        }

        /// <summary>
        /// Property changed event for observer pattern
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises event when a property is changed
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void onPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
} 