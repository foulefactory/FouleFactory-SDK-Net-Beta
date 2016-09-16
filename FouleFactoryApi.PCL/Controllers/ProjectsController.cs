/*
 * FouleFactoryApi.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ) on 09/14/2016
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FouleFactoryApi.PCL;
using FouleFactoryApi.PCL.Http.Request;
using FouleFactoryApi.PCL.Http.Response;
using FouleFactoryApi.PCL.Http.Client;
using FouleFactoryApi.PCL.Exceptions;
using FouleFactoryApi.PCL.Models;

namespace FouleFactoryApi.PCL.Controllers
{
    public partial class ProjectsController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static ProjectsController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static ProjectsController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new ProjectsController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Create new project
        /// </summary>
        /// <param name="project">Required parameter: Example: </param>
        /// <param name="acceptLanguage">Optional parameter: Example: fr</param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic CreateProjectsCreateProject(ProjectWriterServiceModel project, string acceptLanguage = "fr")
        {
            Task<dynamic> t = CreateProjectsCreateProjectAsync(project, acceptLanguage);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Create new project
        /// </summary>
        /// <param name="project">Required parameter: Example: </param>
        /// <param name="acceptLanguage">Optional parameter: Example: fr</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> CreateProjectsCreateProjectAsync(ProjectWriterServiceModel project, string acceptLanguage = "fr")
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1.1/projects");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" },
                { "content-type", "application/json; charset=utf-8" },
                { "Accept-Language", (null != acceptLanguage) ? acceptLanguage : "fr" }
            };

            //append body params
            var _body = APIHelper.JsonSerialize(project);

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.PostBody(_queryUrl, _headers, _body, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Get All projects
        /// </summary>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetProjectsGetUserProjects()
        {
            Task<dynamic> t = GetProjectsGetUserProjectsAsync();
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Get All projects
        /// </summary>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetProjectsGetUserProjectsAsync()
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1.1/projects");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Get csv files by project id
        /// </summary>
        /// <param name="id">Required parameter: Example: </param>
        /// <param name="acceptLanguage">Optional parameter: Example: fr</param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetProjectsGetProjectFiles(int id, string acceptLanguage = "fr")
        {
            Task<dynamic> t = GetProjectsGetProjectFilesAsync(id, acceptLanguage);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Get csv files by project id
        /// </summary>
        /// <param name="id">Required parameter: Example: </param>
        /// <param name="acceptLanguage">Optional parameter: Example: fr</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetProjectsGetProjectFilesAsync(int id, string acceptLanguage = "fr")
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1.1/projects/{id}/urlCsvFiles");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "id", id }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" },
                { "Accept-Language", (null != acceptLanguage) ? acceptLanguage : "fr" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Get task lines by project id
        /// </summary>
        /// <param name="id">Required parameter: Example: </param>
        /// <param name="acceptLanguage">Optional parameter: Example: fr</param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetProjectsGetProjectTaskLines(int id, string acceptLanguage = "fr")
        {
            Task<dynamic> t = GetProjectsGetProjectTaskLinesAsync(id, acceptLanguage);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Get task lines by project id
        /// </summary>
        /// <param name="id">Required parameter: Example: </param>
        /// <param name="acceptLanguage">Optional parameter: Example: fr</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetProjectsGetProjectTaskLinesAsync(int id, string acceptLanguage = "fr")
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1.1/projects/{id}/taskLines");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "id", id }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" },
                { "Accept-Language", (null != acceptLanguage) ? acceptLanguage : "fr" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Get tasks by project id
        /// </summary>
        /// <param name="id">Required parameter: Example: </param>
        /// <param name="acceptLanguage">Optional parameter: Example: fr</param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetProjectsGetProjectTasks(int id, string acceptLanguage = "fr")
        {
            Task<dynamic> t = GetProjectsGetProjectTasksAsync(id, acceptLanguage);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Get tasks by project id
        /// </summary>
        /// <param name="id">Required parameter: Example: </param>
        /// <param name="acceptLanguage">Optional parameter: Example: fr</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetProjectsGetProjectTasksAsync(int id, string acceptLanguage = "fr")
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1.1/projects/{id}/tasks");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "id", id }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" },
                { "Accept-Language", (null != acceptLanguage) ? acceptLanguage : "fr" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Get project by id
        /// </summary>
        /// <param name="id">Required parameter: Example: </param>
        /// <param name="acceptLanguage">Optional parameter: Example: fr</param>
        /// <return>Returns the dynamic response from the API call</return>
        public dynamic GetProjectsGet(int id, string acceptLanguage = "fr")
        {
            Task<dynamic> t = GetProjectsGetAsync(id, acceptLanguage);
            Task.WaitAll(t);
            return t.Result;
        }

        /// <summary>
        /// Get project by id
        /// </summary>
        /// <param name="id">Required parameter: Example: </param>
        /// <param name="acceptLanguage">Optional parameter: Example: fr</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetProjectsGetAsync(int id, string acceptLanguage = "fr")
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1.1/projects/{id}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "id", id }
            });


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" },
                { "Accept-Language", (null != acceptLanguage) ? acceptLanguage : "fr" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 