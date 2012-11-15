﻿//-----------------------------------------------------------------------
// <copyright file="WorkerListHandler.cs" company="Tasty Codes">
//     Copyright (c) 2011 Chad Burggraf.
// </copyright>
//-----------------------------------------------------------------------

namespace BlueCollar.Dashboard
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Web;

    /// <summary>
    /// Implements the worker list handler.
    /// </summary>
    public sealed class WorkerListHandler : JsonHandler
    {
        /// <summary>
        /// Initializes a new instance of the WorkerListHandler class.
        /// </summary>
        /// <param name="repositoryFactory">The repository factory to use.</param>
        public WorkerListHandler(IRepositoryFactory repositoryFactory)
            : base(repositoryFactory)
        {
        }

        /// <summary>
        /// Performs the concrete request operation and returns the output
        /// as a byte array.
        /// </summary>
        /// <param name="context">The HTTP context to perform the request for.</param>
        /// <returns>The response to write.</returns>
        protected override byte[] PerformRequest(HttpContextBase context)
        {
            return Json(
                Repository.GetWorkerList(
                    ApplicationName,
                    QueryString["q"],
                    Helper.PageSize,
                    Helper.PagingOffset(Helper.QueryIntValue("p"))));
        }
    }
}
