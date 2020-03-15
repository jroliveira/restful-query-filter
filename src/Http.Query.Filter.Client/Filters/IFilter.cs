﻿namespace Http.Query.Filter.Client.Filters
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using static System.String;
    using static System.Threading.Tasks.Task;

    using static Http.Query.Filter.Client.Util;

    public interface IFilter
    {
        ICollection<string> Filters { get; }

        /// <summary>
        /// Performs the operation with selected filters.
        /// </summary>
        /// <param name="done">done is a function that will be executed after compiling the filters.</param>
        /// <returns>Returns task.</returns>
        Task Build(Func<string, Task> done) => this.Build(queryString =>
        {
            done(queryString);
            return FromResult(Unit());
        });

        /// <summary>
        /// Performs the operation with selected filters.
        /// </summary>
        /// <param name="done">done is a function that will be executed after compiling the filters.</param>
        /// <returns>Returns the API data.</returns>
        Task<TReturn> Build<TReturn>(Func<string, Task<TReturn>> done) => done(this.Build());

        /// <summary>
        /// Performs the operation with selected filters.
        /// </summary>
        /// <returns>Returns the query string.</returns>
        string Build() => Join("&", this.Filters);

        protected void AddFilter(string filter) => this.Filters.Add(filter);
    }
}
