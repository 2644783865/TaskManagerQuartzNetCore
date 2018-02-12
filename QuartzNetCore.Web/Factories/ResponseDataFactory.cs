﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuartzNetCore.Web.Models;

namespace QuartzNetCore.Web.Factories
{
    public class ResponseDataFactory
    {
        static AjaxResponseData _ajaxResponseData;
        public static AjaxResponseData CreateAjaxResponseData(string statusCode, string message, object data)
        {
            if (_ajaxResponseData == null)
            {
                _ajaxResponseData = new AjaxResponseData() { StausCode = statusCode, Message = message, Data = data };
            }
            else
            {
                _ajaxResponseData.StausCode = statusCode;
                _ajaxResponseData.Message = message;
                _ajaxResponseData.Data = data;
            }
            return _ajaxResponseData;
        }
    }
}
