using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Serialization;
using MediaBrowser.Channels.JupiterBroadcasting.Configuration;

namespace JupiterBroadcasting
{
	public class Plugin : BasePlugin<PluginConfiguration>
	{
		public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer) : base(applicationPaths, xmlSerializer)
		{
			Instance = this;
		}
		public override string Name
		{
			get { return "Jupiter Broadcasting"; }
		}

		public override string Description
		{
			get
			{
				return "Stream podcasts produced by the Jupiter Broacasting.";
			}
		}

		public static Plugin Instance { get; private set; }
	}
}

