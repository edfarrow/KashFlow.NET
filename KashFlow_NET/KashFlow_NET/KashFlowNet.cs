using System;

namespace KashFlow_NET
{
	public partial class KashFlowNet
	{
		private string _username { get; set; }
		private string _password { get; set; }

		private static KashFlow.KashFlowAPISoapClient.EndpointConfiguration _endpointConfiguration = KashFlow.KashFlowAPISoapClient.EndpointConfiguration.KashFlowAPISoap12;
		private KashFlow.KashFlowAPISoapClient _kashflowClient { get; set; }

		public KashFlowNet(string username, string password) : this(username, password, "https://securedwebapp.com/api/service.asmx")
		{
		}

		public KashFlowNet(string username, string password, string endpoint)
		{
			_username = username;
			_password = password;

			_kashflowClient = new KashFlow.KashFlowAPISoapClient(_endpointConfiguration, endpoint);
		}
	}
}
