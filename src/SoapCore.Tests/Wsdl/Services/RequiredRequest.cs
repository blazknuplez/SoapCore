using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace SoapCore.Tests.Wsdl.Services
{
	[DataContract]
	public class RequiredRequest
	{
		[DataMember]
		[Required]
		public int Id { get; set; }

		[DataMember]
		[Required]
		public string Name { get; set; }
	}
}
