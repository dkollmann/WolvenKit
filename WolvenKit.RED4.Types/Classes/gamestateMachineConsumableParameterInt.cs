using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamestateMachineConsumableParameterInt : gamestateMachineActionParameterInt
	{
		[Ordinal(2)] 
		[RED("consumed")] 
		public CBool Consumed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
