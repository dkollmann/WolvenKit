using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlaybackOptionsUpdateData : IScriptable
	{
		[Ordinal(0)] 
		[RED("playbackOptions")] 
		public inkanimPlaybackOptions PlaybackOptions
		{
			get => GetPropertyValue<inkanimPlaybackOptions>();
			set => SetPropertyValue<inkanimPlaybackOptions>(value);
		}

		public PlaybackOptionsUpdateData()
		{
			PlaybackOptions = new();
		}
	}
}