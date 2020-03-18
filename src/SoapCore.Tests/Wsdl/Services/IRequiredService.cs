using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;

namespace SoapCore.Tests.Wsdl.Services
{
	[ServiceContract]
	public interface IRequiredService
	{
		[OperationContract]
		bool TestRequiredService(RequiredRequest request);
	}

	public class RequiredService : IRequiredService
	{
		public bool TestRequiredService(RequiredRequest request)
		{
			return true;
		}
	}
}
