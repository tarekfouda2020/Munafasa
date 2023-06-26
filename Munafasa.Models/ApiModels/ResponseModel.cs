using System;
namespace Munafasa.Models.ApiModels
{
	public class ResponseModel
	{
        public ResponseModel(bool success, object? data = null, object? errors = null, LocalizedValue? msg = null)
        {
            Success = success;
            Data = data;
            Errors = errors;
            Msg = msg;
        }
        public bool Success { get; set; }
        public object? Data { get; set; }
        public object? Errors { get; set; }
        public LocalizedValue? Msg { get; set; }


    }
}

