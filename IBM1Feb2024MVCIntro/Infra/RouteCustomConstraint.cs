﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace IBM1Feb2024MVCIntro.Infra
{
    public class NotEqual : IRouteConstraint
    {
        private string _value;

        public NotEqual(string value)
        {
            _value = value;
        }

        public bool Match
            (
                HttpContextBase httpContext,
                Route route,
                string parameterName,
                RouteValueDictionary values,
                RouteDirection routeDirection
            )
        {

            //if (routeDirection == RouteDirection.UrlGeneration)
            //    return true;


            ////if (httpContext.User.IsInRole(""))
            ////{

            ////}

            var paramValue = values[parameterName].ToString();
            return String.Compare(paramValue, _value, true) != 0;
        }

    }
}