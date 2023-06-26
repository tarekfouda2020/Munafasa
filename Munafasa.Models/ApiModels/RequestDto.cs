using System;
using Munafasa.Models.Tables;
using Munafasa.Utilities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Munafasa.Models.ApiModels
{
	public class RequestDto
	{
        public int Id { get; set; }
        public ServiceDto Service { get; set; }
        public AuthModel Client { get; set; }
        public DateTime VisitDateFrom { get; set; }
        public DateTime VisitDateTo { get; set; }
        public string Desc { get; set; }
        public bool IsUrget { get; set; }
        public int Status { get; set; } = (int)StatusEnumeration.New;
        public int Rate { get; set; }
        public AuthModel? Technician { get; set; }
        public ContractDto Contract { get; set; }
        public IEnumerable<RequestImageDto> Images { get; set; }


        public static RequestDto FromRequest(Request request)
        {
            return new RequestDto()
            {
                Id = request.Id,
                Client = AuthModel.FromClient(request.Client),
                Service = ServiceDto.FromService(request.Service),
                Technician = (request.Technician != null) ? AuthModel.FromTechnician(request.Technician) : null,
                IsUrget =request.IsUrget,
                Rate = request.Rate,
                 VisitDateFrom = request.VisitDateFrom,
                VisitDateTo = request.VisitDateTo,
                Images = request.RequestImages.Select(RequestImageDto.FromRequestImage),
                Status = request.Status,
                Contract = ContractDto.FromContract(request.Client.Contract),
                Desc = request.Desc,
            };
        }
    }
}

