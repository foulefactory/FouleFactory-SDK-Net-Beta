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
    public class TaskLinesWriterServiceModel : INotifyPropertyChanged 
    {
        // These fields hold the values for the public properties.
        private int idProject;
        private List<string> taskColumns;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("IdProject")]
        public int IdProject 
        { 
            get 
            {
                return this.idProject; 
            } 
            set 
            {
                this.idProject = value;
                onPropertyChanged("IdProject");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("TaskColumns")]
        public List<string> TaskColumns 
        { 
            get 
            {
                return this.taskColumns; 
            } 
            set 
            {
                this.taskColumns = value;
                onPropertyChanged("TaskColumns");
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