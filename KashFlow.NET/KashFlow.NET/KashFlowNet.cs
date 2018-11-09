using System;

namespace KashFlow.NET
{
	public partial class KashFlowNet
	{
		private string _username { get; set; }
		private string _password { get; set; }

		private static KashFlowAPISoapClient.EndpointConfiguration _endpointConfiguration = KashFlowAPISoapClient.EndpointConfiguration.KashFlowAPISoap12;
		private KashFlowAPISoapClient _kashflowClient { get; set; }

		public KashFlowNet(string username, string password) : this(username, password, "https://securedwebapp.com/api/service.asmx")
		{
		}

		public KashFlowNet(string username, string password, string endpoint)
		{
			_username = username;
			_password = password;

			_kashflowClient = new KashFlowAPISoapClient(_endpointConfiguration, endpoint);
		}
	}
}
